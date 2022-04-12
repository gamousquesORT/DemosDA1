// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Chapter1
{
    /// <summary>
    /// Remove loops
    /// </summary>
    public class VideoStore5RemoveLoops : IVideoStore
    {
        public string Statement(Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            var resultStatement = new StringBuilder().AppendLine($"Statement for {invoice.Customer}");
            foreach (var perf in invoice.Performances)
            {
                resultStatement.AppendLine($"  {PlayFor(perf).Name}: {Usd(AmountFor(perf))} ({perf.Audience} seats)");
            }
            resultStatement.AppendLine($"Amount owed is {Usd(TotalAmount())}");
            resultStatement.Append($"You earned {TotalVolumeCredits()} credits");
            return resultStatement.ToString();

            int TotalAmount()
            {
                int result = 0;
                foreach (var perf in invoice.Performances)
                {
                    result += AmountFor(perf);
                }

                return result;
            }

            int TotalVolumeCredits()
            {
                int result = 0;
                foreach (var perf in invoice.Performances)
                {
                    result += VolumeCreditsFor(perf);
                }

                return result;
            }

            string Usd(int aNumber)
            {
                return string.Format(new CultureInfo("en-US"), $"{aNumber / 100:C}");
            }

            int VolumeCreditsFor(Performance aPerformance)
            {
                var result = Math.Max(aPerformance.Audience - 30, 0);
                // add extra credit for every ten comedy attendees
                if (PayType.Comedy == PlayFor(aPerformance).PayType) result += (int)Math.Floor((decimal)aPerformance.Audience / 5);
                return result;
            }

            Play PlayFor(Performance aPerformance)
            {
                return plays[aPerformance.PlayId];
            }

            int AmountFor(Performance aPerformance)
            {
                int result;

                switch (PlayFor(aPerformance).PayType)
                {
                    case PayType.Tragedy:
                        result = 40000;
                        if (aPerformance.Audience > 30) result += 1000 * (aPerformance.Audience - 30);

                        break;

                    case PayType.Comedy:
                        result = 30000;
                        if (aPerformance.Audience > 20) result += 10000 + 500 * (aPerformance.Audience - 20);
                        result += 300 * aPerformance.Audience;
                        break;

                    default:
                        throw new Exception($"unknown type: {PlayFor(aPerformance).PayType}");
                }

                return result;
            }
        }
    }
}