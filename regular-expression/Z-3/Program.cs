using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            MatchCollection m = new Regex(@"\d+").Matches(text);
            int multilpy = 1;
            for (int i = 0; i < m.Count; i++)
            {
                Console.Write($"{m[i].Value} * ");
                multilpy *= int.Parse(m[i].Value);
            }
            Console.WriteLine($"= {multilpy}");
        }
    }
}