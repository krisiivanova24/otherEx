using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minior
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = null;
            List<string> list = new List<string>();
            while (word != "stop")
            {
                word = Console.ReadLine();
                list.Add(word);
            }
            list.Remove(list[list.Count - 1]);
            var dic = new Dictionary<string, int>();


            for (int i = 0; i < list.Count - 1; i++)
            {
                
                
                if (i % 2 == 0)
                {
                  
                    if (dic.ContainsKey(list[i]))
                    {
                        dic[list[i]]+= int.Parse(list[i+1]);
                        
                    }else
                    dic.Add(list[i], int.Parse(list[i + 1]));
                   
                }                
                else
                {
                    continue;
                }
            }
            foreach (var pair in dic)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

            //Console.WriteLine();
        }
    }
}
