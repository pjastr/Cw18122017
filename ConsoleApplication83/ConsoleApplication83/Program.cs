using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication83
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Osoba> kolejka = new Queue<Osoba>();
            kolejka.Enqueue(new Osoba("Anna", Plec.K, new DateTime(1990, 4, 13)));
            kolejka.Enqueue(new Osoba("Jan", Plec.M, new DateTime(1995, 7, 22)));
            kolejka.Enqueue(new Osoba("Krzysztof", Plec.M, new DateTime(1980, 1, 30)));
            foreach(var element in kolejka)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
