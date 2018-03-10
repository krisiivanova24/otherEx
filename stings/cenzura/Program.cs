using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cenzura
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string dumi = Console.ReadLine();
            List<string> list = dumi.Split(' ').ToList();
            if (list.Contains(word))
            {
                string newWord = new string('*', word.Length);
                //Console.WriteLine( newWord);
                for (int i = 0; i < list.Count; i++)
                {
                    if (String.Equals(list[i], word))
                    {
                        list[i] = newWord;
                    }
                    else
                    {
                        if (list[i].Contains(word))
                        {
                            list[i] = newWord;
                        }
                    }
                }
            }
            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
