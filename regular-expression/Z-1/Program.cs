using System;
using System.Text.RegularExpressions;

namespace Z_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            Regex regex = new Regex(@"((1\d\d|2([0-4]\d|5[0-5])|\D\d\d?)\.?){4}$");
            MatchCollection matches = regex.Matches(text);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine("IP-адрес - {0}", match.Value);
            }
            else
            {
                Console.WriteLine("IP-адрес не найден");
            }
        }
    }
}
