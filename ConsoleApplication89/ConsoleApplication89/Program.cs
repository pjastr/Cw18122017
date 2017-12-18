using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication89
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<DateTime, string> historia = new Dictionary<DateTime, string>();
            historia.Add(new DateTime(1969, 7, 16), "Pierwsze lądowanie człowieka na Księżycu");
            historia.Add(new DateTime(1918, 11, 11), "Odzyskanie niepodległości");
            historia.Add(new DateTime(1410, 7, 15), "Bitwa pod Grunwaldem");
            historia.Add(new DateTime(1683, 9, 12), "Bitwa pod Wiedniem");
            for (int i = 0; i < 21; i++)
            {
                Console.WriteLine("Stulenie {0}00-{0}99",i);
                foreach (var element in historia)
                {
                    if (element.Key.Year >= i*100 && element.Key.Year <= i*100+99)
                    {
                        Console.WriteLine("[ {0} ,{1} ]", element.Key.ToString("dd.MM.yyyy"), element.Value);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
