using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace times
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numbers = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            var counts = new SortedDictionary<float, byte>();
            foreach (var key in numbers)
            {
                if (counts.ContainsKey(key))
                {
                    counts[key]++;
                }
                else
                {
                    counts[key] = 1;
                }
            }
            foreach (var key in counts)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }

        }
    }
}
