using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication85
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liczby = new Queue<int>();
            liczby.Enqueue(44);
            liczby.Enqueue(22);
            liczby.Enqueue(-1);
            Console.WriteLine(liczby.Contains(100));
            //liczby.Reverse();
            Queue<Osoba> osoby = new Queue<Osoba>();
            //byte x = 7;
            //liczby.Enqueue(x);
            osoby.Enqueue(new Osoba(55));
            osoby.Enqueue(new Osoba(22));
            osoby.Enqueue(new Osoba(44));
            foreach(var element in osoby)
            {
                Console.WriteLine(element);
            }
            

            Console.WriteLine("Pierwszy {0}", osoby.Peek());
            Console.WriteLine("Rozmiar: {0}", osoby.Count);
            while(osoby.Count>0)
            {
                osoby.Dequeue();
            }
                Console.ReadKey();
        }
    }

    class Osoba
    {
        int wiek;

        public Osoba(int wiek)
        {
            this.wiek = wiek;
        }

        public override string ToString()
        {
            return wiek.ToString();
        }
    }
}
