using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication80
{
    public class Osoba:IComparable<Osoba>
    {
        private string imie;

        public Osoba(string imie)
        {
            this.imie = imie;
        }

        public int CompareTo(Osoba other)
        {
            return other.imie.CompareTo(this.imie);
        }
    }
}
