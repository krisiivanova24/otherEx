using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<string> list = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                list.Add(word[i].ToString());
            }
            string nom1 = list[0];
            string nom2 = list[1];
            string nom3 = list[2];
            string nom4 = list[3];
            string slep = String.Concat(nom2, nom3);
            int number = int.Parse(slep);
            Console.WriteLine(number);
            int result = 0;
           
            if (Convert.ToInt32(nom1, 16)+55>= 65 && Convert.ToInt32(nom1, 16)+55 <= 90)
            {
               int delimo = Convert.ToInt32(nom1, 16)+55-64;
                result = number / delimo;
                Console.WriteLine(delimo);
                Console.WriteLine();
                Console.WriteLine(Convert.ToInt32(nom1, 16) + 55);
                Console.WriteLine(Convert.ToInt32(nom4, 16) + 55);
                if (Convert.ToInt32(nom4, 16)+55 >= 65 && Convert.ToInt32(nom4, 16)+55 <= 90)
                {

                    int delit = Convert.ToInt32(nom4, 16) + 55;
                    Console.WriteLine(delit);
                    result = result - delit;
                    Console.WriteLine(result);
                }
                else
                {
                    int delit = Convert.ToInt32(nom4,16)+55-64;
                    result = result + delit;

                }
            }
            else
            {
                int delimo = Convert.ToInt32(nom1, 16)+55-64;
                 result = number * delimo;
                if (Convert.ToInt32(nom4, 16)+55 >= 65 && Convert.ToInt32(nom4,16)+55 <= 90)
                {
                    int delit = Convert.ToInt32(nom4,16)+55-64;
                    result = result - delit;
                }
                else
                {
                    int delit = Convert.ToInt32(nom4,16)+55-64;
                    result = result + delit;

                }
            }
            Console.WriteLine(result);
        }
    }
}
