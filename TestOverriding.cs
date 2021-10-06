using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs.Inheritance
{
    class TestOverriding
    {
        static void Main(String[] args)
        {
            Subclass obj2 = new Subclass();
            obj2.show();

            Base obj1 = new Subclass();
            obj1.show();

            Console.ReadLine();
        }
    }
}
