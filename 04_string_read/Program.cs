/*
 4. Написать программу, которая считывает символы с кла-
виатуры(Console.Read()), пока не будет введена точка. Программа должна
сосчитать количество введенных пользователем пробелов, 
количество цифр, букв, знаков(char.IsDigit(), char.IsLetter(), ...). 
 */


using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _04_string_read
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input chars and last char enter point:\t");
            string line = Console.ReadLine();
            char chars;// = Console.ReadLine();
            while (Console.Read() != '.')
            {
                chars = Console.Read();
            }

            //Console.ReadLine();
        }
    }
}
