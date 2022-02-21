using System;
using Geometrus.Lazutkin;

namespace AppC
{
    class Program
    {
        static void Fuc(string a)
        {                  
                switch (a)
                {
                    case "q":
                        Console.WriteLine("Сообщение!");
                        break;

                    case "e":
                        break;

                    default:
                        Console.WriteLine("Неверное значение!");
                        break;
                }
        }

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
                /*
                            Console.WriteLine("Введите 'q' для вывода сообщения\nВведите 'е' для выхода из приложения");
                            Console.WriteLine("Выход!");
                            Console.ReadKey();
                            */

                /* В метод запихнул case
                 while (true)
                {
                    Console.Write("Введите значение:"); string r = Console.ReadLine();
                    Program.Fuc(r); // Вот метод
                    if (r == "e") break;
                }                */

                /* Через IF и бесконечный while
                Console.Write("Введите значение:"); string r = Console.ReadLine();
                if (r == "q")
                {
                Console.WriteLine("Сообщение!");
                }
                if (r == "e")
                { break; }
                if(r!="q" && r!="e")
                { Console.WriteLine("Неверная команда!\nВведите 'q' для вывода сообщения\nВведите 'е' для выхода из приложения"); }
                */

                /* Более опрятный через IF и for
                for (string r=""; r!="e"; )
                {
                   Console.Write("Введите значение:"); r = Console.ReadLine();

                   if (r=="q")
                       Console.WriteLine("Сообщение!");
                   else
                      if(r != "e") Console.WriteLine("Неверное значение!");
                }*/

                /* Через case и while
                Console.Write("Введите значение:"); string r = Console.ReadLine();
                switch (r)
                {
                    case "q":
                        Console.WriteLine("Сообщение!");
                            break;

                    case "e":
                        break;

                    default:
                        Console.WriteLine("Неверное значение!");
                            break;
                }
                if (r == "e") break;*/