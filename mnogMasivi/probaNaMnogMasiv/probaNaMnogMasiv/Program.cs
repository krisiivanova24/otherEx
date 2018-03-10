using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaNaMnogMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            byte row = byte.Parse(Console.ReadLine());
            byte col = byte.Parse(Console.ReadLine());
            byte[,] tabl = new byte[row, col];
            for (int i = 0; i < row; i++)
            {
                //byte[] masiv = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    tabl[i, j] = byte.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row; i++)
            {
                float sum = 0f;
                for (int j = 0; j < col; j++)
                {
                    sum += tabl[i, j];
                    Console.Write("{0,2}",tabl[i,j]);
                }
                Console.WriteLine("{0,2}",sum/col);
            }
        }
    }
}
