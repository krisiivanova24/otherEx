using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortBriefWords
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] split = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> text = Console.ReadLine().ToLower().Split(split).ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].Length<5)
                {
                    result.Add(text[i]);
                }
            }
            result = result.OrderBy(text1 => text1).Distinct().ToList();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
