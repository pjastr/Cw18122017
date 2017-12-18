using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication81
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("pierwszy");
            myAL.Add(2);

            myAL.Insert(1, 5);
            myAL.Add(2);

            foreach(var element in myAL)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(myAL[0]);
            
            Console.WriteLine(myAL[myAL.Count-1]);
            Console.WriteLine("{0}", myAL[1]);
            //myAL.Sort();
            Console.WriteLine("{0}", myAL.Count);


            ArrayList liczby = new ArrayList();
            liczby.Add(45d);
            liczby.Add(-2d);
            liczby.Add(3d);
            liczby.Add(5.2d);
            liczby.Sort();
                
            Console.ReadKey();
        }
    }
}
