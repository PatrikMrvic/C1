using System;
using System.Collections.Generic;
using System.Text;

namespace _3_klase
{
    class Macka : Zivotinja
    {
        public override string ToString()
        {
            if (sretan)

            {
                return "Ja sam macka i ja sam sretna";
            }
            else
            {
                return "Ja sam macka i ja nisam sretna";
            }
        }

        internal void Sreca()
        {
            Console.WriteLine($"Predem");

        }

        internal void Vidi(Pas p1)
        {
            sretan = false;

        }

        internal void Vidi(Mis misko)
        {
            sretan = true;
        }
    }
}
