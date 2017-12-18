using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication79
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liczby = new Queue<int>();
            liczby.Enqueue(4);
            liczby.Enqueue(5);
            liczby.Enqueue(-2);
            Console.WriteLine(liczby.Contains(4));
            //liczby.Reverse();
            Queue<Osoba> osoby = new Queue<Osoba>();
            osoby.Enqueue(new Osoba("Anna"));
            osoby.Enqueue(new Osoba("Jan"));
            osoby.Enqueue(new Osoba("Jan"));
            foreach(var element in osoby)
            {
                Console.WriteLine(element);
            }
            //for (int i = 0; i < osoby.Count; i++ )
            //{
            //    osoby.Dequeue();
            //}
            while(osoby.Count>0)
            {
                osoby.Dequeue();
            }
                Console.WriteLine(osoby.Count);
        }
    }

    class Osoba
    {
        string imie;

        public Osoba(string imie)
        { 
            this.imie = imie;
        }

        public override string ToString()
        {
            return imie;
        }
    }
}
