using System;
using System.Collections.Generic;
using System.Text;

namespace C1tutorial
{
    class Rectangle
    {// member variables
        double length;
        double width;
        

        public Rectangle(int v1, int v2)
        {
            this.length = v1;
            this.width = v2;
        }

        public Rectangle()
        {
        }

        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
            Console.WriteLine("Pravokutnik {0} {1} ima površinu u {2} ", length, width, length * width);
            Console.WriteLine("Pravokutnik {0} {1} ima opseg u {2} ", length, width, (length + width)*2);

        }
    }
    
}
