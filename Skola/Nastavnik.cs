using System;

namespace Skola
{
    internal class Nastavnik:Osoba
    {


        public Nastavnik(string Ime, string Prezime):base(Ime,Prezime)
        {
            //base(Ime, Prezime);
            //ime = Ime;
            //prezime = Prezime;
        }

        public override string ToString()
        {
            return base.ToString(); 
        }

        internal void predajePredmet(Predmet v)
        {
           // throw new NotImplementedException();
        }
    }
}
