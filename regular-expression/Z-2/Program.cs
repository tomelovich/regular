using System;
using System.Text.RegularExpressions;

namespace Z_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            text = Regex.Replace(text, @"о", "оОк");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
