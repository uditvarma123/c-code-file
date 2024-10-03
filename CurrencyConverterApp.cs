
using System;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Currency Converter App!");
            ConvertCurrency();
        }

        static void ConvertCurrency()
        {
            Console.WriteLine("Enter amount in USD: ");
            double usdAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose the currency to convert to (EUR, GBP, INR): ");
            string currency = Console.ReadLine().ToUpper();

            double convertedAmount = 0;

            switch (currency)
            {
                case "EUR":
                    convertedAmount = usdAmount * 0.85; // Example conversion rate
                    break;
                case "GBP":
                    convertedAmount = usdAmount * 0.75; // Example conversion rate
                    break;
                case "INR":
                    convertedAmount = usdAmount * 75; // Example conversion rate
                    break;
                default:
                    Console.WriteLine("Currency not supported.");
                    return;
            }

            Console.WriteLine($"Converted amount: {convertedAmount} {currency}");
        }
    }
}
