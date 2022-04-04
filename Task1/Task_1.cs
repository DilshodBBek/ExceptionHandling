using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public static class Task_1
    {
        public static void Run()
        {
            string InputWord;
            do
            {
                Console.WriteLine("Input any word ...");
                InputWord = Console.ReadLine();
            } while (PrintFirstCharacter(InputWord));
            Console.ReadKey();
        }

        private static bool PrintFirstCharacter(string _inputWord)
        {
            try
            {
                if (string.IsNullOrEmpty(_inputWord))
                    throw new NullReferenceException();
                Console.WriteLine(_inputWord.Substring(0, 1));
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                return false;
            }
            return true;
        }
    }
}
