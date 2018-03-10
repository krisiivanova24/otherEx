using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            List<string> list = new List<string>();
            while (input!="END")
            {
                input = Console.ReadLine();
                list.Add(input);
            }
            list.RemoveAt(list.Count-1);
            //Console.WriteLine(string.Join(" ==> ", list));
            List<string> list1 = new List<string>();
            for (int i = 0; i <= list.Count-1; i++)
            {
                string[] arr1 = list[i].Split(' ').ToArray();
                //Console.WriteLine(string.Join(">>>",arr1));
                if (arr1[0] == "A")
                {
                    //list.Clear();
                    list1.Add(arr1[1]);
                    list1.Add(arr1[2]);
                    
                }                
                else
                {
                   // Console.WriteLine(string.Join(">>>>",list));
                    
                    if (list1.Contains(arr1[1]))
                    {
                        Console.WriteLine("{0} -> {1}", arr1[1], list1[list1.Count-1]);
                        
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
