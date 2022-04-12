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
    /// Splitting the phases of calculating and formatting
    /// </summary>
    public class VideoStore6SplitPhase : IVideoStore, IHtmlVideoStore
    {
        #region Corresponds to createStatementData.js 

        internal StatementData CreateStatementData(
                Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            var statementData =
                new StatementData(invoice.Performances.ConvertAll(EnrichPerformance), invoice.Customer);
            statementData.TotalAmount = TotalAmount(statementData);
            statementData.TotalVolumeCredits = TotalVolumeCredits(statementData);
            return statementData;

            EnrichedPerformance EnrichPerformance(Performance aPerformance)
            {
                var result = new EnrichedPerformance(aPerformance, PlayFor(aPerformance));
                // Note that it is safest to set Play in the constructor as AmountFor and VolumeCreditsFor
                // rely on it being set
                result.Amount = AmountFor(result);
                result.VolumeCredits = VolumeCreditsFor(result);
                return result;
            }

            Play PlayFor(Performance aPerformance)
            {
                return plays[aPerformance.PlayId];
            }

            int AmountFor(EnrichedPerformance aPerformance)
            {
                int result;

                switch (aPerformance.Play.PayType)
                {
                    case PayType.Tragedy:
                        result = 40000;
                        if (aPerformance.Audience > 30)
                        {
                            result += 1000 * (aPerformance.Audience - 30);
                        }

                        break;

                    case PayType.Comedy:
                        result = 30000;
                        if (aPerformance.Audience > 20)
                        {
                            result += 10000 + 500 * (aPerformance.Audience - 20);
                        }
                        result += 300 * aPerformance.Audience;
                        break;

                    default:
                        throw new Exception($"unknown type: {aPerformance.Play.PayType}");
                }

                return result;
            }

            int VolumeCreditsFor(EnrichedPerformance aPerformance)
            {
                var result = Math.Max(aPerformance.Audience - 30, 0);
                // add extra credit for every ten comedy attendees
                if (PayType.Comedy == aPerformance.Play.PayType)
                {
                    result += (int)Math.Floor((decimal)aPerformance.Audience / 5);
                }
                return result;
            }

            int TotalAmount(StatementData data)
            {
                return data.Performances.Sum(element => element.Amount);
            }

            int TotalVolumeCredits(StatementData data)
            {
                return data.Performances.Sum(element => element.VolumeCredits);
            }
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