using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ot10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int brSys = num[0];
            int chislo = num[1];
            List<int> res = new List<int>();
            while (chislo>0)
            {
                res.Add(chislo % brSys);
                chislo = chislo / brSys;
            }
            res.Reverse();
            Console.WriteLine(string.Join("",res));
        }
    }
}
