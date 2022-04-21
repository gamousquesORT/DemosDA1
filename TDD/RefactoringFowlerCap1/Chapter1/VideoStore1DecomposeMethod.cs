// This is an open source non-commercial project. Dear PVS-Studio, please check it.

// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Chapter1
{
    /// <summary>
    /// Decomposing the Statement() method
    /// </summary>
    public class VideoStore1DecomposeMethod : IVideoStore
    {
        public string Statement(Invoice invoice, IReadOnlyDictionary<string, Play> plays)
        {
            int totalAmount = 0;
            int volumeCredits = 0;

            IFormatProvider format = new CultureInfo("en-US");

            var resultStatement = new StringBuilder().AppendLine($"Statement for {invoice.Customer}");

            foreach (var perf in invoice.Performances)
            {
                // *** Segundo refactor ver variables perfromance y play
                var play = plays[perf.PlayId];
                int thisAmount = AmountFor(perf, play);  //** refactor Extract method

                // add volume credits
                volumeCredits += Math.Max(perf.Audience - 30, 0);
                // add extra credit for every ten comedy attendees
                if (PayType.Comedy == play.PayType) volumeCredits += (int)Math.Floor((decimal) perf.Audience / 5);

                // print line for this order
                resultStatement.AppendFormat(format, $"  {play.Name}: {thisAmount / 100:C}");
                resultStatement.AppendLine($" ({perf.Audience} seats)");
                totalAmount += thisAmount;
            }

            resultStatement.AppendFormat(format, $"Amount owed is {totalAmount / 100:C}");
            resultStatement.AppendLine("");
            resultStatement.Append($"You earned {volumeCredits} credits");
            return resultStatement.ToString();

            //******* Segundo refactoreo, se necesita Performance y Play?
            int AmountFor(Performance aPerformance, Play play)
            {
                //*** No se podrá usar un mejor nombre de varaible
                int result;

                switch (play.PayType)
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
                        throw new Exception($"unknown type: {play.PayType}");
                }

                return result;
            }
        }
    }
}