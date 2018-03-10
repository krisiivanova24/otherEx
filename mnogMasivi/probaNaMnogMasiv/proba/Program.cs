using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            List<string> list = new List<string>();
            while (input != "END")
            {
                input = Console.ReadLine();
                list.Add(input);
            }
            list.RemoveAt(list.Count - 1);
            //Console.WriteLine(string.Join(" ==> ", list));
            List<string> list1 = new List<string>();
            var dic = new Dictionary<string, int>();
            for (int i = 0; i <= list.Count - 1; i++)
            {
                string[] arr1 = list[i].Split(' ').ToArray();
                //Console.WriteLine(string.Join(">>>",arr1));
                if (arr1[0] == "A")
                {
                   //list1.Clear();
                   list1.Add(arr1[1]);
                   list1.Add(arr1[2]);
                    

                }
                else
                {

                    if (dic.ContainsKey(arr1[1]))
                    {
                        Console.WriteLine("{0} -> {1}", arr1[1], dic.GetType().GetProperty(arr1[1]) == null ? null : arr1[1].GetType().GetProperty(arr1[1]).GetValue(arr1[1], null));

                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", arr1[1]);
                    }

                }

            }
        }
    }
}
