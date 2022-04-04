using System;
namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if(stringValue == null)
                throw new ArgumentNullException("input value must not be null or empty");

            if (string.IsNullOrWhiteSpace(stringValue))
                throw new FormatException("input value must not be null or empty");
            
            while(stringValue.EndsWith(" "))
            {
                stringValue = stringValue.Remove(stringValue.Length - 1, 1);
            }
            bool isNegative = false;
            if (stringValue.StartsWith("-"))
            {
                isNegative = true;
                stringValue = stringValue.Remove(0, 1);
            }
            else if(stringValue.StartsWith("+")) 
                stringValue = stringValue.Remove(0, 1);
            
            Int64 ParseNumber = 0;
            foreach (char item in stringValue.ToCharArray())
            {
                Console.WriteLine(item);
                switch (item.ToString())
                {
                    case "0": { ParseNumber *= 10; break; }
                    case "1": { ParseNumber *= 10; ParseNumber += 1; break; }
                    case "2": { ParseNumber *= 10; ParseNumber += 2; break; }
                    case "3": { ParseNumber *= 10; ParseNumber += 3; break; }
                    case "4": { ParseNumber *= 10; ParseNumber += 4; break; }
                    case "5": { ParseNumber *= 10; ParseNumber += 5; break; }
                    case "6": { ParseNumber *= 10; ParseNumber += 6; break; }
                    case "7": { ParseNumber *= 10; ParseNumber += 7; break; }
                    case "8": { ParseNumber *= 10; ParseNumber += 8; break; }
                    case "9": { ParseNumber *= 10; ParseNumber += 9; break; }
                    default:
                        throw new FormatException("Invalid input value format");
                }

            }
            if (isNegative)
                ParseNumber *= -1;
            if (ParseNumber > Int32.MaxValue || ParseNumber < Int32.MinValue)
            {
                throw new OverflowException($"input value must be between {int.MinValue} and {int.MaxValue}");
            }
            Console.WriteLine(ParseNumber);
            return (int)ParseNumber;

        }
    }
}