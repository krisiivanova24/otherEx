using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obir
{
    class Program
    {
        static void Main(string[] args)
        {
            short[] ceni = Console.ReadLine().Split(' ').Select(short.Parse).ToArray();
            List<string> whaT = new List<string>();
            byte times = 0;
            byte times2 = 0;
            string what = null;
            while (what!= "Jail Time")
            {
                what = Console.ReadLine();
                whaT.Add(what);
            }
            whaT.Remove(whaT[whaT.Count - 1]);
            List<string> newList = whaT[0].Split(' ').ToList();
            List<string> newList2 = whaT[1].Split(' ').ToList();

            for (int i = 0; i < whaT.Count; i++)
            {
                if (newList[0].Contains("%"));
                {
                    times++;
                }
                while (times<=2)
                {
                    continue;
                }
                if (newList[1].Contains("$")) ;
                {
                    times2++;
                }
                while (times2 <= 2)
                {
                    continue;
                }
                Console.WriteLine(times);
                Console.WriteLine(times2);
            }
        }
    }
}
