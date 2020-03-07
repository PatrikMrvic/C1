using System;
using System.Collections.Generic;

namespace Skola
{
    /**
    *Klasa skola kreira nove ucenike i nove nastavnike
    *Ucenici imaju ime, prezime i...
    *Nastavnici imaju ime prezime znaci isto sto i ucenici osim sto imaju ispit
    *Program treba raditi ispite*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Nastavnik n1=new Nastavnik(Ime:"Filip", Prezime:"Fizic");
            Nastavnik n2=new Nastavnik(Ime:"Matko", Prezime:"Matkic");

           
            Predmet p1=new Predmet("Fizika");
            Predmet p2=new Predmet("Matematika");
            Predmet p3 = new Predmet("Kemija");
            Predmet p4 = new Predmet("Hrvatski");



            n1.predajePredmet(p1);


            Ucenik u1 = new Ucenik(Ime: "Đuro", Prezime: "Đurić");


            u1.upisujePredmet(p1);
            u1.upisujePredmet(p2);


             List<Ispit> ispiti = new List<Ispit>();
        

            ispiti.Add(new Ispit(n1,p1,u1, DateTime.Today, 3));
            ispiti.Add(new Ispit(n1, p2, u1, DateTime.Today, 2));
            ispiti.Add(new Ispit(n1, p3, u1, DateTime.Today, 5));
            ispiti.Add(new Ispit(n1, p4, u1, DateTime.Today, 5));



            //Ispisujemo svaki clan liste ispiti kao item
            foreach (var item in ispiti)
            {
                Console.WriteLine(item);
            }

            //Ovdje ispisi ucenika i njegove predmete i ispite
            // Pero Peric
            // predmeti:
            //   (1) Matem
            //   (2) Fiz...
            // Ispiti:
            //  - Matematika (2)
            //  - Fizika (3)
            Console.WriteLine(u1.Detalji());
// ovdje ispisi nastavnika i njegove predmete
        }
        
    }
}
