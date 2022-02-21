using System;
using Geometrus.Lazutkin;

namespace AppC
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Square square = new Square();
            square.setSide(3.0);
            Console.WriteLine(square.toString());
            Console.WriteLine(square.Area());
            Console.WriteLine(square.Size());
            Class1 s = new Class1();
            Console.WriteLine(s.arop(3));

            
        }
    }
}
