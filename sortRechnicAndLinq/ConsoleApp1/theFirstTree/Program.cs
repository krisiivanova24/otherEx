using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theFirstTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<byte> nums = Console.ReadLine().Split(' ').Select(byte.Parse).ToList();
             nums = nums.OrderByDescending(num => num).Take(3).ToList();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
