// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Chapter1
{
    /// <summary>
    /// Initial code before any refactor
    /// </summary>
    public class VideoStore0BeforeRefactor : IVideoStore
    {
        public string Statement(Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            int totalAmount = 0;
            int volumeCredits = 0;

            IFormatProvider format = new CultureInfo("en-US");

            var result = new StringBuilder().AppendLine($"Statement for {invoice.Customer}");

            foreach (var perf in invoice.Performances)
            {
                var play = plays[perf.PlayId];
                int thisAmount;
                
                //******** Primer Refactoreo
                
                switch (play.PayType)
                {
                    case PayType.Tragedy:
                        thisAmount = 40000;
                        if (perf.Audience > 30) thisAmount += 1000 * (perf.Audience - 30);

                        break;

                    case PayType.Comedy:
                        thisAmount = 30000;
                        if (perf.Audience > 20) thisAmount += 10000 + 500 * (perf.Audience - 20);
                        thisAmount += 300 * perf.Audience;
                        break;

                    default:
                        throw new Exception($"unknown type: {play.PayType}");
                }

                // add volume credits
                volumeCredits += Math.Max(perf.Audience - 30, 0);
                // add extra credit for every ten comedy attendees
                if (PayType.Comedy == play.PayType) volumeCredits += (int)Math.Floor((decimal) perf.Audience / 5);

                // print line for this order
                result.AppendFormat(format, $"  {play.Name}: {thisAmount / 100:C}");
                result.AppendLine($" ({perf.Audience} seats)");
                totalAmount += thisAmount;
            }

            result.AppendFormat(format, $"Amount owed is {totalAmount / 100:C}");
            result.AppendLine("");
            result.Append($"You earned {volumeCredits} credits");
            return result.ToString();
        }
    }
}