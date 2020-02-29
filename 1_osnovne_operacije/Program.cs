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
            Console.WriteLine($"zbroj: {broj1}+{broj2}jednako je {zbroj(broj1, broj2)}");

        }

        private static object zbroj(int b1,int b2)
        {
            return b1 + b2;
        }
    }
}
