using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v10
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            string[] res = Console.ReadLine().Split(' ').ToArray();
            
          Array.Reverse(res);
            Console.WriteLine(string.Join(" ", res));
            
        }
    }
}
