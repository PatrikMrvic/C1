using System;

namespace C1tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Rectangle r2 = new Rectangle(2, 5);
            r2.Display();


        }
    }
}
