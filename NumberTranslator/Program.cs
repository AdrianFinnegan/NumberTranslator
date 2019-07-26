using System;
using TranslationService;

namespace NumberTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parseNumber = new ParseNumber();


            Console.WriteLine("Enter a whole number between 1 and 999:");
            var input = Console.ReadLine();

            var response = parseNumber.GetText(Int32.Parse(input));
            Console.WriteLine($"Converts to: {response}" );

            Console.WriteLine("Any key to close.");
            Console.ReadKey();
        }
    }
}
