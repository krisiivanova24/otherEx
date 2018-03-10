using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (!list.Contains("stocked"))
            {
                string str = Console.ReadLine();
                list.Add(str);
            }
            list.Remove(list[list.Count-1]);
            //Console.WriteLine(string.Join(",,,", list)); 
            float result = 0f;
            for (int i = 0; i < list.Count; i++)
            {               
                List<string> res = list[i].Split(' ').ToList();
                //Console.WriteLine(string.Join(", ,", res)); 
                            
                string product = res[0];
               // Console.WriteLine(product);                
                res.Remove(res[0]);                
                //Console.WriteLine(string.Join(">>", res));

                List<float> intL = new List<float>();
                intL.Add(float.Parse(res[0]));
                intL.Add(float.Parse(res[1]));
                float num1 = intL[0];
                float num2 = intL[1];
                float sum = num1 * num2;               

                Console.WriteLine($"{product}: ${num1:f2} * {num2} = ${sum:f2}");
                result += sum;
            }
            string tire = new string('-', 30);
            Console.WriteLine(tire);
            Console.WriteLine("Grand Total: {0:f2}",result);
        }
    }
}
