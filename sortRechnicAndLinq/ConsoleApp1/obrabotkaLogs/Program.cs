using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obrabotkaLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());
            List<string> logs = new List<string>();
            for (int i = 0; i < num; i++)
            {
                string line = Console.ReadLine();
                logs.Add(line);
            }
            //logs.Sort();
            List<string> nff = new List<string>();
            List<string> all = new List<string>();
            int time = 0;
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < logs.Count; i++)
            {
                List<string> otdelno = logs[i].Split(' ').ToList();
                string pin = otdelno[0];
                string user = otdelno[1];
                int vreme = int.Parse(otdelno[2]);
                
                //proverka ima li go ili ne
                if (!dic.ContainsKey(user))
                {
                    time = vreme;
                    nff.Add(time.ToString());
                    nff.Add(pin);
                    Console.WriteLine(string.Join(">>", nff));
                    dic[user] = nff.ToList();
                    Console.WriteLine(nff.Count);
                }
                else
                {
                    foreach (var pair in dic)
                    {
                        if (pair.Equals(user))
                        {
                            nff.Remove(time.ToString());
                    time += vreme;
                    
                    if (!nff.Contains(pin))
                    {
                        nff.Add(pin);
                    }
                    dic[user] = nff.ToList();
                    Console.WriteLine(string.Join(", ", nff));


                        }
                    }
                    //Console.WriteLine(nff.Count);
                    //nff[time] += vreme;
                    

                }
                //Console.WriteLine(string.Join(">>", otdelno));
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} //// {string.Join(" ", item.Value)}");
            }
        }
    }
}
