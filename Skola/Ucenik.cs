using System;
using System.Collections.Generic;

namespace Skola
{
    internal class Ucenik:Osoba
    {
        private List<Predmet> UpisaniPredmeti = new List<Predmet>();
        private List<Ispit> MojiIspiti = new List<Ispit>();

        public double Prosjek {
            get
            {
                double broj=0;
                foreach (var item in MojiIspiti)
                {
                    broj += item.Ocjena;
                }
                broj = broj / MojiIspiti.Count;
                return broj;
            }  
        }

        public string ProsjekRijecima {
            get
            {
                string text = "nema ocjena";
                if (Prosjek<2)
                {
                    text = "nedovoljan";

                }
                else if(Prosjek<2.5)
                {
                    text = "dovoljan";
                }
                else if (Prosjek < 3.5)
                {
                    text = "dobar";
                }
                else if (Prosjek < 4.5)
                {
                    text = "vrlo dobar";
                }
                else 
                {
                    text = "odlican";
                }
                return text;
            }
                }

        public Ucenik(string Ime, string Prezime) : base(Ime, Prezime)
        {
            


        }

        internal void upisujePredmet(Predmet p1)
        {
            UpisaniPredmeti.Add(p1);
        }
        internal void polazeIspit(Ispit I1)
        {
            MojiIspiti.Add(I1);
        }

        //Ovdje ispisi ucenika i njegove predmete i ispite
        // Pero Peric
        // predmeti:
        //   (1) Matem
        //   (2) Fiz...
        // Ispiti:
        //  - Matematika (2)
        //  - Fizika (3)
        // Ukupan prosjek: (4.5)
        internal string Detalji()
        {
            string text = "";
            text += this.PunoIme()+" \n";
            text += "Predmeti:\n";
            for (int i = 0; i < UpisaniPredmeti.Count; i++)
            {
                text += $"  ({i}) {UpisaniPredmeti[i]}   \n";
            }
            text += "Ispiti:\n";
            foreach (var item in MojiIspiti)
            {
                text += $"  - {item.IspisIspitaZaUcenika()}   \n";
            }
            text += $"Ukupan prosjek je {this.Prosjek} ({this.ProsjekRijecima})";



            return text;
            
        }
    }
}