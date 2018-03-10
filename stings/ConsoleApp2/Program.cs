using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            long[] num = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            double[] price = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<string> list = new List<string>();
            List<int> words = new List<int>();
            List<double> result1 = new List<double>();
            List<long> result2 = new List<long>();
            string word = null;
            while (word != "done")
            {
                word = Console.ReadLine();
                list.Add(word);
            }
            list.Remove(list[list.Count - 1]);
            //Console.WriteLine(string.Join(" . ", list));
            for (int j = 0; j < arr1.Length; j++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == arr1[j])
                    {
                        int index = Array.IndexOf(arr1, arr1[j]);
                        words.Add(index);
                        // Console.WriteLine(index);
                    }

                }

            }

            for (int i = 0; i < words.Count; i++)
            {
                double number = price.ElementAt(words[i]);
                result1.Add(number);
                long number2 = num.ElementAt(words[i]);
                result2.Add(number2);
                Console.WriteLine($"{list[i]} costs: {result1[i]}; Available quantity: {result2[i]}");
            }

        }
    }
}
