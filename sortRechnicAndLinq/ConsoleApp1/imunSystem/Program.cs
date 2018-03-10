using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imunSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            short power = short.Parse(Console.ReadLine());
            string virus = null;
            List<string> input = new List<string>();
            while (virus != "end")
            {
                virus = Console.ReadLine();
                input.Add(virus);
            }
            input.RemoveAt(input.Count - 1);
            List<string> res = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                char[] list1 = input[i].ToCharArray();
                char num = ' ';
                int num2 = 0;
                int chasto3 = 0;
                int vremeDyl = 0; ;
                if (res.Contains(input[i]))
                {
                    for (int j = 0; j < list1.Length; j++)
                    {
                        num = list1[j];
                        // Console.WriteLine(num);
                        num2 += (int)num;
                        //Console.WriteLine(num2);
                        //chasto3 = num2 / 3;
                        chasto3 = num2 / 3;
                        vremeDyl = (chasto3 * input[i].Length)/3;
                        
                    }
                    //Console.WriteLine(vremeDyl);
                        var mm = (Math.Floor(vremeDyl / 60.0) % 60).ToString("0");
                        var ss = Convert.ToInt32(vremeDyl % 60).ToString("00");
                        //Console.WriteLine($"{mm}m {ss}s");
                        Console.WriteLine($"Virus {input[i]}: {chasto3} => {vremeDyl} seconds");
                        Console.WriteLine($"{input[i]} defeated in {mm}m {ss}s.");
                        

                }
                else
                {
                    res.Add(input[i]);
                    for (int j = 0; j < list1.Length; j++)
                    {
                        num = list1[j];
                        // Console.WriteLine(num);
                        num2 += (int)num;
                        //Console.WriteLine(num2);
                    }

                     chasto3 = num2 / 3;
                    vremeDyl = chasto3 * input[i].Length;
                    //Console.WriteLine(vremeDyl);
                    var mm = (Math.Floor(vremeDyl / 60.0) % 60).ToString("0");
                    var ss = Convert.ToInt32(vremeDyl % 60).ToString("00");
                    //Console.WriteLine($"{mm}m {ss}s");
                    Console.WriteLine($"Virus {input[i]}: {chasto3} => {vremeDyl} seconds");
                    Console.WriteLine($"{input[i]} defeated in {mm}m {ss}s.");
                    
                }
            }

           

            }
        }
    }

