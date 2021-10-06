using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs
{
    class Constructors
    {
        int id;
        String name;
        static String address;
        Constructors() { }//default constructor
        public Constructors(int id, string name) //parameterised constructor
        {
            this.id = id;
            this.name = name;
        }
        Constructors(Constructors obj2)   //copy constructor
        {
            id = obj2.id;
            name = obj2.name;
        }
        private Constructors(String address1)
        {
            address =address1;
        }

        static void Main(String[] args)
        {
            Constructors obj1 = new Constructors();
            Console.WriteLine("calling default constructor");
            Console.WriteLine("Name is " + obj1.name);
            Console.WriteLine("Id is " + obj1.id);

            Console.WriteLine("calling parameterised constructor");
            Constructors obj = new Constructors(45,"Helen");
            Console.WriteLine("Name is " + obj.name);
            Console.WriteLine("Id is " + obj.id);

            Console.WriteLine("calling copy constructor");
            Constructors obj3 = new Constructors(obj);
            Console.WriteLine("Name is " + obj3.name);
            Console.WriteLine("Id is " + obj3.id);

            Console.WriteLine("Static member called with static constructor");
            Console.WriteLine("Address is " + address);  //null-->calling static constructors

            Console.WriteLine("Static member called with private constructor");
            Constructors obj4 = new Constructors("Pune");
            Console.WriteLine("Address is " + address);

            Console.ReadLine();
        }

       
    }
}
