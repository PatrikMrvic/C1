using System;
using System.Collections.Generic;
using System.Text;

namespace Skola
{
    class Osoba
    {
       
      
            private string ime;
            private string prezime;

            public Osoba(string Ime, string Prezime)
            {
                ime = Ime;
                prezime = Prezime;
            }
       
        public string PunoIme()
        {
            return
                ime + " "+prezime;
                }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return ime +" "+prezime;
        }
    }
}
