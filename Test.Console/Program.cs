// See https://aka.ms/new-console-template for more information

using System.Numerics;

namespace Test.Console
{
    using System;

    class Program
    {
        
        static void Main(string[] args)
        {
            Fibonacci( 1000, 1020);

            void Fibonacci(BigInteger x, BigInteger y)
            {
                BigInteger c = 0;
                BigInteger b = 1;
                BigInteger a = 0;
                for (BigInteger i = 0; i <= y; i++)
                {
                    c= a + b;
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