/*
 4. Написать программу, которая считывает символы с кла-
виатуры(Console.Read()), пока не будет введена точка. Программа должна
сосчитать количество введенных пользователем пробелов, 
количество цифр, букв, знаков(char.IsDigit(), char.IsLetter(), ...). 
 */


using System;

namespace _04_string_read
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = '\0';
            int digit = 0;
            int letter = 0;
            int space = 0;
            int punctuation = 0;
            Console.Write("Enter string and last symbol must be point '.'\n");
            while (c != '.')
            {
                c = Convert.ToChar(Console.Read());
                if (char.IsDigit(c))
                    ++digit;
                if (char.IsLetter(c))
                    ++letter;
                if (char.IsPunctuation(c))
                    ++punctuation;
                if (c == ' ') //(char.IsWhiteSpace(c))
                    ++space;
            }

            Console.WriteLine($"\nDigit(s):\t{digit}\nLetter(s):\t{letter}\nPunctuation(s):\t{punctuation}\nSpace(s):\t{space}");

            Console.ReadLine();
        }
    }
}
