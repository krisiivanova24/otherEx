using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string email = null;
            List<string> names = new List<string>();
            List<string> emails = new List<string>();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            while (name != "stop")
            {
                name = Console.ReadLine();
                names.Add(name);
                if (name!="stop")
                {
                    email = Console.ReadLine();
                    emails.Add(email);

                }             

            }
            names.RemoveAt(names.Count - 1);
            //emails.RemoveAt(emails.Count - 1);
            //Console.WriteLine(string.Join("====", emails));
            for (int i = 0; i < names.Count; i++)
            {
                if (!emails[i].Contains("us") || emails[i].Contains("uk"))
                {
                    dic[names[i]] = emails[i];
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
