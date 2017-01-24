using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowy_projekt
{
    //2.
    class Zupa : Danie
    {
        public Zupa (string Nazwa, double Cena) : base (Nazwa,Cena)
        {            
        }

        public override void Info()
        {
            Console.WriteLine("Zupa: nazwa: " + this.nazwa + " ,cena: " + this.cena);
        }
    }
}
