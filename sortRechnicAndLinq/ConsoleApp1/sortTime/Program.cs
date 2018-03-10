using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortTime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> times = Console.ReadLine().Split(' ').Select(DateTime.Parse).ToList();
           times =  times.OrderBy(time => time).ToList();
           // Console.WriteLine(string.Join("{0:hh:mm} ", times));
            for (int i = 0; i < times.Count; i++)
            {
               
                    Console.Write("{0:hh:mm}, ",times[i]);
               
            }
        }
    }
}
