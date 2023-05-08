using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThirdClass abc;
            ABCClass abc2;
            InnerClass inn;

            Console.WriteLine("Hello World!");
        }

        private class InnerClass
        {
        }
    }

    internal class ABCClass
    {
    }
}