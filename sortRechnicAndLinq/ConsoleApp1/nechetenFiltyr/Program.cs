using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nechetenFiltyr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < input.Count; i++)
            {
               
                if (input[i] % 2== 1)
                {
                    input.Remove(input[i]);
                }
            }
            //Console.WriteLine(string.Join(" ",input));

            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
                
                
            }
            List<int> output = new List<int>();
            sum = sum / input.Count;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]>sum)
                {
                    input[i] += 1;
                }
                else
                {
                    input[i] -= 1;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
