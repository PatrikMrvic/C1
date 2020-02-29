using System;

namespace _2_nizovi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nizovi!");
            int[] cijelobrojni = new int[10];  //0-9
            cijelobrojni[0] = 5;
            cijelobrojni[7] = 9;
            Console.WriteLine($"ukupno brojeva {cijelobrojni.Length }");

            foreach (var br in cijelobrojni )

            {
                Console.WriteLine($"broj {br }");
            }

            int[] niz = new int[] { 1, 2, 4, 66, 78, 89, 45 };
            foreach (var item in niz)
            {
                Console.Write(" " + item*item);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
                cijelobrojni[i] = i;
            }
            Console.WriteLine();
            foreach (var br in cijelobrojni)

            {
                Console.WriteLine($"broj {br }");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i+=2)
            {
                Console.Write(cijelobrojni[i]+" ");
                
            }
            Console.WriteLine();
            for (int i = 9; i>0; i--)
            {
                Console.Write(cijelobrojni[i] + " ");

            }
            Console.WriteLine();
            for (int i = 9; i > 0; i-=2)
            {
                Console.Write(cijelobrojni[i] + " ");

            }
        }
    }
}
