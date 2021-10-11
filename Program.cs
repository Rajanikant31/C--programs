using System;

namespace _4_oct_21
{
    class Program
    {
        void addition(int a, int b)
        {
            int total;
            total = a + b;
            Console.WriteLine("Sum= " + total);
        }
        void addition(int a, int b, int c)
        {
            int total2;
            total2 = a + b + c;
            Console.WriteLine("Sum = " + total2);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.addition(2, 3);
            p.addition(2, 5, 3);
        }
    }
}
