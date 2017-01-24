using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowy_projekt
{ 
    //3.
    class DanieGlowne : Danie
    {
        public DanieGlowne(string Nazwa, double Cena) : base (Nazwa,Cena)
        {
        }

        public override void Info()
        {           
            Console.WriteLine("Danie Główne: nazwa: " + this.nazwa + " ,cena: " + this.cena);
        }

    }
}
