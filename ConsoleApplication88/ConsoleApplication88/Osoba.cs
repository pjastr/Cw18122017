using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication88
{
    class Osoba
    {
        string imie;
        int wiek;
        Plec plec;
        DateTime dataUrodzenia;

        public Osoba(string imie, Plec plec, DateTime data)
        {
            this.imie = imie;
            this.plec = plec;
            this.dataUrodzenia = data;
            this.wiek = DateTime.Now.Year - data.Year;
        }

        public override string ToString()
        {
            return String.Format("Imię: {0}, Płeć: {1}, Data urodzenia: {2}, wiek: {3}",imie,plec,dataUrodzenia.ToString("dd.MM.yyyy"),wiek);
        }

    }
}
