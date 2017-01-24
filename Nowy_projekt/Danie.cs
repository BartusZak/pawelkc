using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nowy_projekt
{
    //1.
    abstract class Danie : IComparable<Danie>
    {
        protected string nazwa;
        protected double cena;

        public Danie (string Nazwa,double Cena)
        {
            this.nazwa = Nazwa;
            this.cena = Cena;
        }

        virtual public void Info()
        {
            Console.WriteLine ("Danie, nazwa: " + this.nazwa + " ,cena: " + this.cena);          
        }

        public int CompareTo(Danie other)
        {
            return other.cena.CompareTo(this.cena);
        }
    }
}
