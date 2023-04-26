using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispravak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prvi, drugi, treci;

            Console.WriteLine("Unesite 3 dvoznamenkasta broja");

            prvi=Convert.ToInt32(Console.ReadLine());
            drugi=Convert.ToInt32(Console.ReadLine());
            treci=Convert.ToInt32(Console.ReadLine());

            if(prvi>drugi && prvi>treci)
            {
                Console.WriteLine("Broj " + prvi + " je najveći.");
            }

            if (drugi > prvi && drugi> treci)
            {
                Console.WriteLine("Broj " + drugi + " je najveći.");
            }

            if (treci > prvi && treci > drugi)
            {
                Console.WriteLine("Broj " + treci + " je najveći.");
            }

            Console.ReadKey();
        }
    }
}
