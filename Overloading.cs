using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs
{
    class Overloading
    {
        int area(int side)
        {
            return side * side;

        }
        double area(double length,double breadth)
        {
            return length * breadth;
        }
        public static void Main(String[] args)
        {
            Overloading obj = new Overloading();
            Console.WriteLine("Area of square is:" + obj.area(2));
            Console.WriteLine("Area of rectangle is:" + obj.area(2,3.0));
            Console.ReadLine();
            
        }
    }
}
