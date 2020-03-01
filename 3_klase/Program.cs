using System;

namespace _3_klase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ovo su psi i macke!");
            Macka m1 = new Macka();
            
            m1.Zvuk = "Mjauuuuu";
            m1.GlasajSe();

            Pas p1 = new Pas();
            p1.GlasajSe();
            p1.Zvuk = "Vau vau";
            p1.GlasajSe();

            Macka[] Katzen= new Macka[5];//0-4
            for (int i = 0; i < Katzen.Length ; i++)
            {

                Katzen[i] = m1;
            }
            foreach (var item in Katzen)
            {
                item.GlasajSe();
            }
            m1.Sreca();
            p1.Sreca();

            p1.Vidi(m1);
            Console.WriteLine(p1);
            Pas p2 = new Pas();
            Console.WriteLine(p2);
            m1.Vidi(p1);
            Console.WriteLine(m1);
            Mis misko = new Mis();
            misko.Vidi(m1);
            Console.WriteLine(misko);
            m1.Vidi(misko);
            Console.WriteLine(m1);



        }
    }
}
