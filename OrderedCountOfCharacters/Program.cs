using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderedCountOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                var list = OrderedCount(str);
                if (list.Count() != 0)
                {
                    foreach (var item in list)
                        Console.WriteLine($"{item.Item1} {item.Item2}");
                }
                else
                    Console.WriteLine("Must write from A-Z");
            }
        }
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            var list = new List<Tuple<char, int>>();
            if (input.All(x => char.IsLetter(x) || x == ' '))
            {
                var countLetter = input.GroupBy(x => x).Select(x => $"{x.Count()}{x.Key}");

                foreach (var item in countLetter)
                {
                    var charArray = item.ToCharArray();
                    int intVal = (int)Char.GetNumericValue(charArray[0]);
                    list.Add(Tuple.Create(charArray[1], intVal));
                }
            }
            return list;
        }
    }
}
