using System;

namespace _1_osnovne_operacije
{
    class Program
    {


        static void Main(string[] args)
        {
            int broj1, broj2;
            Console.WriteLine("Unesi 2 broja!");
            broj1 = int.Parse(Console.ReadLine());

            broj2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"zbroj: {broj1}+{broj2} jednako je {zbroj(broj1, broj2)}");
            Console.WriteLine($"razlika: {broj1}-{broj2} jednako je {razlika(broj1, broj2)}");
            Console.WriteLine($"umn: {broj1}*{broj2} jednako je {umn(broj1, broj2)}");
            Console.WriteLine($"kolicnik: {broj1}*{broj2} jednako je {kolicnik(broj1, broj2)}");
        }

        private static double kolicnik(int broj1, int broj2)
        {
            return (double)broj1 / broj2;
        }

        private static int umn(int broj1, int broj2)
        {
            return broj1 * broj2;
        }

        private static object zbroj(int b1,int b2)
        {
            return b1 + b2;


        }
        static int razlika(int b1,int br2)
        {
            return b1 - br2;

        }
        
    }
}
