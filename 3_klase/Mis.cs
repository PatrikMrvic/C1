using System;

namespace _3_klase
{
    internal class Mis:Zivotinja 
    {
        public Mis()
        {
            
        }
        public void Sreca()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Skacem");
        }

        public override string ToString()
        {
            if (sretan)

            {
                return "Ja sam mis i ja sam sretan";
            }
            else
            {
                return "Ja sam mis i ja sam uplasen";
            }
            
        }

        internal void Vidi(Macka m1)
        {
            sretan = false;
        }
    }
}