using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication87
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            Dictionary<int, Osoba> dictionary2 = new Dictionary<int, Osoba>();

            dictionary1.Add(1, "wartosc");
            dictionary1[2] = "wartosc2";
            dictionary1[100] = "wartosc100";
            foreach (var item in dictionary1)
            {
                Console.WriteLine("< {0}, {1} >",item.Value, item.Key);
            }
            Console.WriteLine(dictionary1.First());
            Console.WriteLine(dictionary1.Last());

            Console.WriteLine(dictionary1[2]);
            
            Console.WriteLine(dictionary1.Count);
            Console.ReadKey();
        }
    }
    class Osoba
    {

    }
}
