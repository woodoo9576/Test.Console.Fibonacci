// See https://aka.ms/new-console-template for more information

using System.Numerics;

namespace Test.Console
{
    using System;

    class Program
    {
        public class Rectangle
        {
            public Rectangle(int height, int width) => (Height, Width) = (height, width);

            public int Width { get; }
            public int Height { get;}

            public int Area => Width * Height;
            public void DisplayArea()=> Console.WriteLine($"Area: {Area}");
        }
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Başlangıç Sayısını Giriniz: ");
            int? a = int?.Parse(Console.ReadLine());
            Console.WriteLine("Bitiş Sayısını Giriniz: ");
            int? b = int?.Parse(Console.ReadLine()!);
            
            Fibonacci(a ?? 10, b ?? 20);
            */
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.DisplayArea();
            void Fibonacci(BigInteger x, BigInteger y)
            {
                BigInteger c = 0;
                BigInteger b = 1;
                BigInteger a = 0;
                for (BigInteger i = 0; i <= y; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    if (i >= x && i < y)
                    {
                        Console.WriteLine($"i: {i}, f:{c}");
                    }
                }
            }
        }
    }
}