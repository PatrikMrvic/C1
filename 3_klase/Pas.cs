using System;

namespace _3_klase
{
    internal class Pas:Zivotinja 
    {
        public Pas()
        {
            
        }
        public void Sreca()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Masem repom");
        }

        public override string ToString()
        {
            if (sretan)

            {
                return "Ja sam pas i ja sam sretan";
            }
            else
            {
                return "Ja sam pas i ja nisam sretan";
            }
            
        }

        internal void Vidi(Macka m1)
        {
            sretan = true;
        }
    }
}