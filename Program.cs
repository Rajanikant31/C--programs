using System;

namespace _4_oct_21_q4
{
    class Rectangle
    {
        double _length;
        double _breadth;
        public Rectangle()
        {
            _length = 13.43;
            _breadth = 4.54;

        }
        public Rectangle(double len, double bre)
        {
            _length = len;
            _breadth = bre;
        }
        public double Area()
        {
            return _length * _breadth;
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine("Area of rectangle=" + r.Area());
            Rectangle r2 = new Rectangle(2.3, 3.6);
            Console.WriteLine("Area of rectangle = "+r2.Area());
        }
    }
}
//this is constructor program example