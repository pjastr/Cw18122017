using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication88
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Osoba> kolejka = new Queue<Osoba>();
            kolejka.Enqueue(new Osoba("Jan", Plec.M, new DateTime(1990, 2, 23)));
            kolejka.Enqueue(new Osoba("Anna", Plec.K, new DateTime(1973, 11, 2)));
            kolejka.Enqueue(new Osoba("Sylwia", Plec.K, new DateTime(2000, 1, 4)));
            foreach(var element in kolejka)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
