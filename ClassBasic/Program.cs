using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        private class Math
        {
            /* static public int Abs(int a)
            {
                return 0;
            }
            */
        }

        static void Main(string[] args)
        {
            /* ThirdClass abc;
            ABCClass abc2;
            InnerClass inn;

            Console.WriteLine("Hello World!");

            Math math = new Math();
            // Console.WriteLine(Math.Abs(-10));
        }

        private class InnerClass
        {
        }
    }

    internal class ABCClass
    {
    } */

            Product product = new Product();

            // 자바 스타일
            Product product1 = new Product();
            product1.name = "감자";
            product1.price = 2000;

            // C# 스타일
            Product product2 = new Product() { name = "고구마", price = 2100 };
            Product product3 = new Product() { name = "옥수수" };
            Product product4 = new Product() { price = 999999 };
            Product product5 = new Product() { price = 7777, name = "비트" };

            // 클래스 변수 출력
            Console.WriteLine(Product.origin);
            Console.WriteLine(product1.name + " / " + product1.price);
            Console.WriteLine(product1);

            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "곽경희", grade = 3 });
            list.Add(new Student() { name = "권하은", grade = 2 });
            list.Add(new Student() { name = "김선혜", grade = 1 });
        }
    }
}