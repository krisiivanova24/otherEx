using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicUncountNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string lotWords = Console.ReadLine().ToLower();
            string[] arr = lotWords.Split(' ').ToArray();
            var dic = new Dictionary<string, byte>();
            foreach (var key in arr)
            {
                if (dic.ContainsKey(key))
                {
                    dic[key]++;
                }
                else
                {
                    dic[key] = 1;
                }
            }
            Console.WriteLine(string.Join(" => ",dic));
            var result = new List<string>();
            foreach (var keys in dic)
            {
                if (keys.Value % 2 != 0)
                {
                    result.Add(keys.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
