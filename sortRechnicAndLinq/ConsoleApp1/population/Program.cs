using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace population
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            List<string> allDanni = new List<string>();
            while (start != "report")
            {
                allDanni.Add(start);
                start = Console.ReadLine();
            }
            List<string> resAl = new List<string>();
            List<string> res = new List<string>();
            int total = 0;
            for (int i = 0; i < allDanni.Count; i++)
            {
                List<string> gradDyrj = allDanni[i].Split('|').ToList();
                string country = gradDyrj[1];
                string city = gradDyrj[0];
                string population = gradDyrj[2];
                if (resAl.Contains(country))
                {
                    total += int.Parse(gradDyrj[2]);
                    string num = resAl[1].ToString();
                    string sofiq = (resAl[3].ToString());
                    resAl.Remove(num);
                    resAl.Remove(sofiq);
                    resAl.Remove(resAl[1]);
                    resAl.Add(total.ToString());
                    resAl.Add(city);
                    resAl.Add(population);
                    resAl.Add(sofiq);
                    resAl.Add(num);
                    res.Add(string.Join(" ", resAl));
                    resAl = new List<string>();
                    total = 0;


                }
                else
                {

                    resAl.Add(country);
                    total = int.Parse(gradDyrj[2]);
                    resAl.Add(total.ToString());
                    resAl.Add(population);
                    resAl.Add(city);
                    if (country != "Bulgaria")
                    {
                        res.Add(string.Join(" ", resAl));
                        // Console.WriteLine(string.Join(" >> ", resAl));
                        resAl = new List<string>();
                        total = 0;
                        res.Sort();
                        res.Reverse();
                    }

                }
                // Console.WriteLine(string.Join(" >> ", resAl));               

            }

            Console.WriteLine(string.Join(" --- ", res));
            for (int i = 0; i < res.Count; i++)
            {
                //resAl = new List<string>();
                resAl = res[i].Split(' ').ToList();
                // Console.WriteLine(string.Join(" == ", resAl));
                if (resAl.Count == 4)
                {
                    // Console.WriteLine(resAl.Count);
                    Console.WriteLine($"{resAl[0]} ( total population :{resAl[1]})");
                    Console.WriteLine($"=>{resAl[3]}: {resAl[2]}");
                }
                else
                {
                    //Console.WriteLine($"{resAl[0]} ( total population :{resAl[1]}) \n=>{res[3]}: {resAl[2]} \n=>{res[5]}: {resAl[4]}");
                    Console.WriteLine($"{resAl[0]} (total population :{resAl[1]})");
                    Console.WriteLine($"=>{resAl[2]} {resAl[3]}: {resAl[4]}");
                    Console.WriteLine($"=>{resAl[5]}: {resAl[6]}");
                }
            }
        }
    }
}
