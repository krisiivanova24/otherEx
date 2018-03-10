
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karti
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            List<string> store = new List<string>();
            while (input != "JOKER")
            {
                input = Console.ReadLine();
                store.Add(input);
            }
            Console.WriteLine(string.Join("====", store));
            store.RemoveAt(store.Count - 1);
            int res1 = 0;
            int res = 0;
            int ress = 0;
            for (int i = 0; i < store.Count; i++)
            {
                List<string> num = store[i].Split(' ', ',', ':').ToList();

                for (int j = 1; j < num.Count; j++)
                {
                    List<string> otdelno = num[j].Split(null).ToList();
                    List<string> idk = new List<string>();

                    for (int a = 0; a < otdelno.Count; a++)
                    {
                        //if (!idk.Contains(otdelno[a].Concat(otdelno[a + 1])))
                        {
                            idk.Add(otdelno[a] + otdelno[a + 1]);

                            if (otdelno[a] == "J")
                            {
                                res1 = 11;
                            }
                            else
                            {
                                if (otdelno[a] == "Q")
                                {
                                    res1 = 12;
                                }
                                else
                                {
                                    if (otdelno[a] == "K")
                                    {
                                        res1 = 13;
                                    }
                                    else
                                    {
                                        if (otdelno[a] == "A")
                                        {
                                            res1 = 14;
                                        }
                                        else
                                        {
                                            res1 = int.Parse(otdelno[a]);
                                        }
                                    }
                                }
                            }
                            if (otdelno[a + 1] == "S")
                            {
                                res = 4;
                            }
                            else
                            {
                                if (otdelno[a + 1] == "H")
                                {
                                    res1 = 4;
                                }
                                else
                                {
                                    if (otdelno[a] == "D")
                                    {
                                        res1 = 2;
                                    }
                                    else
                                    {
                                        res1 = 1;
                                    }
                                }
                            }
                            ress = res * res1;
                        }
                    }
                }
                Console.WriteLine($"num[i]: {ress}");

            }
        }
    }
}
