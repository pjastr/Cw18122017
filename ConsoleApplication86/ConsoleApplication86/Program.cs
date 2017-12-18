using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication86
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            lista.Add(566);
            lista.Add(23);
            lista.Add(-1);
            lista.Insert(1, 88);
            lista.Add(-1);
            for(int i =0; i<lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            foreach(var element in lista)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista.First());
            Console.WriteLine(lista[lista.Count-1]);
            Console.WriteLine(lista.Last());
            lista.Sort();

            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(new Osoba("Jan"));
            osoby.Add(new Osoba("Anna"));
            osoby.Add(new Osoba("Krzysztof"));
            //osoby.Sort();
            Osoba o1 = new Osoba("Tomasz");
            osoby.Insert(1, o1);
            osoby.Reverse();
            Console.WriteLine(osoby.Contains(o1));
            osoby.Clear();


            ArrayList lista1 = new ArrayList();
            lista1.Add(1);
            lista1.Add("string");
            lista1.Insert(0, new Osoba("Patryk"));
            Console.WriteLine(lista1[0]);
            Console.WriteLine(lista1[lista1.Count-1]);
            //lista1.Sort();

            ArrayList liczby = new ArrayList();
            liczby.Add(3d);
            liczby.Add(-2d);
            liczby.Add(7d);
            liczby.Add(7.2d);
            //liczby.Sort();
            liczby.Reverse();
            lista1.Remove(7d);
            lista1.RemoveAt(0);
            lista1.Clear();
            Console.WriteLine(liczby.Contains(3d));
        }
    }

    class Osoba:IComparable<Osoba>
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

        public int CompareTo(Osoba other)
        {
            return other.imie.CompareTo(this.imie);
        }
    }
}
