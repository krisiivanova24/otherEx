using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min
{
    class Program
    {
        static void Main(string[] args)
        {
            byte row = byte.Parse(Console.ReadLine());
            byte col = byte.Parse(Console.ReadLine());
            byte[,] arr = new byte[row, col];
            byte[] minCol = new byte[col];
            for (int i = 0; i < row; i++)
            {
                byte[] masiv = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    arr[i, j] = masiv[j];
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("{0,2}",arr[i,j]);
                }
                Console.WriteLine();
            }
            List<byte> res = new List<byte>();
            for (int j = 0; j < col; j++)
            {
                byte min = arr[0, j]; 
                for (int i = 0; i < row; i++)
                {
                    if (min > arr[i,j])
                    {
                        min = arr[i, j];
                    }
                }
                minCol[j] = min;
            }
            for (int i = 0; i < col; i++)
            {
                Console.Write("{0,2}", minCol[i]);
            }
        }
    }
}
