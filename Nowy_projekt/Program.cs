using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowy_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Danie> dania = new List<Danie>();

            dania.Add(new DanieGlowne("Kotlet Schabowy", 20.00));
            dania.Add(new Zupa("Pomidorowa", 10.00));
            dania.Add(new DanieGlowne("Gołąbki", 20.00));
            dania.Add(new Zupa("Rosół", 5.00));
            dania.Add(new DanieGlowne("Mielone", 15.00));

            foreach (var e in dania)
            {
                e.Info();
            }

            Console.ReadLine();

            dania.Sort();

            foreach (var e in dania)
            {
                e.Info();
            }

            Console.ReadLine();
        }
    }
}

