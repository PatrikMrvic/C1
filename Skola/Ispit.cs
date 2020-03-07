using System;

namespace Skola
{
    internal class Ispit
    {
        private Nastavnik n;
        private Predmet p;
        private Ucenik u;
        private DateTime today;
        private int ocjena;

        public int Ocjena { get => ocjena; set => ocjena = value; }

        public Ispit(Nastavnik n, Predmet p, Ucenik u, DateTime today, int ocjena)
        {
            this.n = n;
            this.p = p;
            this.u = u;
            this.today = today;
            this.Ocjena = ocjena;
            u.polazeIspit(this);
        }

        public override string ToString()
        {
            return $"Ispit iz {p} je polagao ucenik {u} kod nastavnika {n} datuma {today}";

        }
        public string IspisIspitaZaUcenika()
        {
            return $"{p} je polozena kod nastavnika {n} datuma {today} ocjena je {Ocjena}";
        }
    }
}