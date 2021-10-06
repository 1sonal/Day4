using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //reverse of character array
            char[] chr = { 'a', 'b', 'c', 'd', 'e' };
            int i;
            Console.WriteLine("reverse of character array is");
            for (i = 4; i >= 0; i--)
            {
                Console.Write(chr[i] + " ");
            }
        }
    }
}
