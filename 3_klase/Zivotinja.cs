using System;
using System.Collections.Generic;
using System.Text;

namespace _3_klase
{
    class Zivotinja
    {
        public bool sretan=false;
        private string zvuk="grlglgrgrgl";

        public string Zvuk { get => zvuk; set => zvuk = value; }

        public void GlasajSe() {
            Console.WriteLine($"Ja kazem {Zvuk}");

        
        
        }
    }
}
