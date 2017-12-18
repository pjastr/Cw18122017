using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication82
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> all = new Dictionary<string, string>();
            all.Add("slowo", "slowooo");
            all["slowo2"] = "dasdxxx";
            all.Add("slowo3", "dasdas");

            //foreach (var element in all)
            //{
            //    Console.WriteLine("{0} {1}", element.Key, element.Value);
            //}
            foreach(var element in all)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(all.First());
            Console.WriteLine(all.Last());
            Console.WriteLine(all.ElementAt(0));
            Console.WriteLine(all.ElementAt(all.Count - 1));
            string wyraz;
            all.TryGetValue("slowo", out wyraz);
            Console.WriteLine(all.ContainsValue("słowo"));
            Console.WriteLine(all.Count());
            all.Reverse();
            all.Remove("slowo2");
            all.Clear();

            



            Console.ReadKey();
        }
    }
}
