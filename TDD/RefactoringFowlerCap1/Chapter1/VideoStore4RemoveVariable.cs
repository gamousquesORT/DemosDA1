// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Chapter1
{
    /// <summary>
    /// Remove the format variable
    /// </summary>
    public class VideoStore4RemoveVariable : IVideoStore
    {
        public string Statement(Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            int totalAmount = 0;
            int volumeCredits = 0;

            var resultStatement = new StringBuilder().AppendLine($"Statement for {invoice.Customer}");

            foreach (var perf in invoice.Performances)
            {
                volumeCredits += VolumeCreditsFor(perf);

                // print line for this order
                resultStatement.AppendLine($"  {PlayFor(perf).Name}: {Usd(AmountFor(perf))} ({perf.Audience} seats)");
                totalAmount += AmountFor(perf);
            }

            resultStatement.AppendLine($"Amount owed is {Usd(totalAmount)}");
            resultStatement.Append($"You earned {volumeCredits} credits");
            return resultStatement.ToString();

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