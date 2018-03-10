using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortPhonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            List<string> imena = new List<string>();
            while (name != "ListAll")
            {
                name = Console.ReadLine();
                imena.Add(name);
            }
            imena.RemoveAt(imena.Count - 1);
            var res2 = new SortedDictionary<string, string>();
            for (int i = 0; i < imena.Count; i++)
            {
                imena.Sort();
                List<string> res1 = imena[i].Split(' ').ToList();
                res1.RemoveAt(0);

                res2[res1[0]] = res1[1];
                Console.WriteLine($"{res1[0]} -> {res1[1]}");

            }

        }
    }
}
