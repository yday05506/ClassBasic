using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        private class Math { 
            public int Abs(int a)
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            ThirdClass abc;
            ABCClass abc2;
            InnerClass inn;

            Console.WriteLine("Hello World!");

            Math math = new Math();
            Console.WriteLine(Math.Abs(-10));
        }

        private class InnerClass
        {
        }
    }

    internal class ABCClass
    {
    }
}