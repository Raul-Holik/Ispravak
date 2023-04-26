using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispravak2
{
    internal class Program
    {
        class Stablo
        {
            bool otpadajuListovi;
            string vrstaStabla;

            public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }

            public Stablo(bool otpadajuListovi)
            {
                OtpadajuListovi=otpadajuListovi;
            }

            public override string ToString()
            {
                if (otpadajuListovi == true)
                {
                     vrstaStabla="Vrsta stabla je bijelogorično";
                }

                if (otpadajuListovi == false)
                {
                    vrstaStabla = "Vrsta stabla je crnogorično";
                }
                return vrstaStabla;
            }
        }
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(true);
            Stablo stablo2 = new Stablo(false);

            Console.WriteLine(stablo1);
            Console.WriteLine(stablo2);

            Console.ReadKey();
        }
    }
}
