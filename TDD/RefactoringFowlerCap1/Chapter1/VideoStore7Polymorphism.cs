// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Chapter1
{
    /// <summary>
    /// Reorganizing the calculations by Type
    /// </summary>
    /// 
    public class VideoStore7Polymorphism : IVideoStore, IHtmlVideoStore
    {
        #region Corresponds to createStatementData.js 

        internal StatementData CreateStatementData(
                Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            var result = new StatementData(invoice.Performances.ConvertAll(EnrichPerformance), invoice.Customer);
            result.TotalAmount = TotalAmount(result);
            result.TotalVolumeCredits = TotalVolumeCredits(result);
            return result;

            EnrichedPerformance EnrichPerformance(Performance aPerformance)
            {
                var calculator = CreatePerformanceCalculator(aPerformance, PlayFor(aPerformance));
                return new EnrichedPerformance(aPerformance, calculator.Play)
                {
                    Amount = calculator.Amount, VolumeCredits = calculator.VolumeCredits
                };
            }

            Play PlayFor(Performance aPerformance)
            {
                return plays[aPerformance.PlayId];
            }

            int TotalAmount(StatementData data)
            {
                return data.Performances.Sum(element => element.Amount);
            }

            int TotalVolumeCredits(StatementData data)
            {
                return data.Performances.Sum(element => element.VolumeCredits);
            }

            PerformanceCalculator CreatePerformanceCalculator(Performance aPerformance, Play aPlay)
            {
                switch (aPlay.PayType)
                {
                    case PayType.Tragedy:
                        return new TragedyCalculator(aPerformance, aPlay);

                    case PayType.Comedy:
                        return new ComedyCalculator(aPerformance, aPlay);

                    default:
                        throw new Exception($"unknown type: {aPlay.PayType}");
                }
            }
        }

        protected class PerformanceCalculator
        {
            protected readonly Performance Performance;
            internal readonly Play Play;

            internal PerformanceCalculator(Performance aPerformance, Play aPlay)
            {
                Performance = aPerformance;
                Play = aPlay;
            }

            internal virtual int Amount => throw new Exception("subclass responsibility");

            internal virtual int VolumeCredits => Math.Max(Performance.Audience - 30, 0);
        }

        protected class TragedyCalculator : PerformanceCalculator
        {
            internal TragedyCalculator(Performance aPerformance, Play aPlay) : base(aPerformance, aPlay)
            {
            }

            internal override int Amount
            {
                get
                {
                    var result = 40000;
                    if (Performance.Audience > 30)
                    {
                        result += 1000 * (Performance.Audience - 30);
                    }

                    return result;
                }
            }
        }

        protected class ComedyCalculator : PerformanceCalculator
        {
            internal ComedyCalculator(Performance aPerformance, Play aPlay) : base(aPerformance, aPlay)
            {
            }

            internal override int Amount
            {
                get
                {
                    var result = 30000;
                    if (Performance.Audience > 20)
                    {
                        result += 10000 + 500 * (Performance.Audience - 20);
                    }

                    result += 300 * Performance.Audience;
                    return result;
                }
            }

            internal override int VolumeCredits => base.VolumeCredits + (int)Math.Floor((decimal)Performance.Audience / 5);
        }

        internal class EnrichedPerformance : Performance
        {
            internal readonly Play Play;

            internal int Amount;

            internal int VolumeCredits;

            internal EnrichedPerformance(Performance aPerformance, Play play) 
                : base(aPerformance.PlayId, aPerformance.Audience)
            {
                Play = play;
            }
        }

        internal class StatementData
        {
            internal readonly ImmutableList<EnrichedPerformance> Performances;

            internal readonly string Customer;

            internal int TotalAmount;

            internal int TotalVolumeCredits;

            internal StatementData(ImmutableList<EnrichedPerformance> performances, string customer)
            {
                Performances = performances;
                Customer = customer;
            }
        }
        #endregion

        #region Corresponds to statement.js

        public string Statement(Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            return RenderPlainText(CreateStatementData(invoice, plays));
        }

        private string RenderPlainText(StatementData data)
        {
            var result = new StringBuilder().AppendLine($"Statement for {data.Customer}");
            foreach (var perf in data.Performances)
            {
                result.AppendLine($"  {perf.Play.Name}: {Usd(perf.Amount)} ({perf.Audience} seats)");
            }
            result.AppendLine($"Amount owed is {Usd(data.TotalAmount)}");
            result.Append($"You earned {data.TotalVolumeCredits} credits");
            return result.ToString();
        }

        public string HtmlStatement(Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            return RenderHtml(CreateStatementData(invoice, plays));
        }

        private string RenderHtml(StatementData data)
        {
            var result = new StringBuilder().AppendLine($"<h1>Statement for {data.Customer}</h1>");
            result.AppendLine("<table>");
            result.Append("<tr><th>play</th><th>seats</th><th>cost</th></tr>");
            foreach (var perf in data.Performances)
            {
                result.Append($"  <tr><td>{perf.Play.Name}</td><td>{perf.Audience}</td>");
                result.AppendLine($"<td>{Usd(perf.Amount)}</td></tr>");
            }
            result.AppendLine("</table>");
            result.AppendLine($"<p>Amount owed is <em>{Usd(data.TotalAmount)}</em></p>");
            result.AppendLine($"<p>You earned <em>{data.TotalVolumeCredits}</em> credits</p>");
            return result.ToString();
        }

        private string Usd(int aNumber)
        {
            return string.Format(new CultureInfo("en-US"), $"{aNumber / 100:C}");
        }
        #endregion
    }
}