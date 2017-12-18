using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication80
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista1 = new List<string>();
            lista1.Add("Nazwa");
            lista1.Add("sdghsdh");
            lista1.Add("ostatni");
            lista1.Add("ostatni");

            lista1.Insert(1, "drugi");
            lista1.Sort();
            foreach (var item in lista1)
                Console.WriteLine(item);

            //Console.WriteLine(lista1[0]);
            //Console.WriteLine(lista1[lista1.Count-1]);
            //lista1.First();
            //lista1.Last();
            //Console.ReadKey();
            List<Osoba> lista2 = new List<Osoba>();
            lista2.Add(new Osoba("Jan"));
            lista2.Add(new Osoba("Anna"));
            lista2.Add(new Osoba("Zofia"));
            lista2.Sort();
            Console.WriteLine("{0}", lista1.Contains("Zofia"));
            lista1.Reverse();
            //lista1.Clear();
            lista1.RemoveAt(1);
            lista1.Remove("drugi");

        }
    }
}
