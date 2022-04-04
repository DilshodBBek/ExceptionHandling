using System;

namespace Task2
{
    public static class Task_2
    {
        public static void Run()
        {
            INumberParser parser = new NumberParser();
            Console.WriteLine($"Input number value between {int.MinValue} and {int.MaxValue}");
            string stringNumber = Console.ReadLine();

            try
            {
                int parseNumber = parser.Parse(stringNumber);
                Console.WriteLine($"Parse number value is {parseNumber}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
