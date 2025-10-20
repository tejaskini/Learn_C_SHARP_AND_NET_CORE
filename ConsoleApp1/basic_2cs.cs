using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class basic_2cs
    {
        public int some_defination(int a, int b)
        {
           
            //memrory address
            Console.WriteLine("This is a basic 2 C# class");
            return a + b;
        }

        // method overloading

        public float Calc(float a, float b)
        {
            return a + b;
        }
        public int Calc(int a, int b, int c)
        {
            return a + b + c;
        }


}
}
