using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program

    {
        static void Main(string[] args)
        {
            // arithmetics operations
            int a = 10;
            int b = 20;

            //basic_2cs obj = new basic_2cs();
            //obj.some_defination();

            Console.WriteLine(a + b);


            Console.WriteLine("Enter your age");

            //string username = Console.ReadLine();
            //Console.WriteLine("Hello " + username); 

            int age = 0;
            try
            {
               age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You are " + age + " years old");
            }
            catch
            {
                Console.WriteLine("Please enter a valid number!");
            }


            string fname = "Tejas";
            string lname = "Kini";

            Console.WriteLine("Your name is " + fname + " " + lname);
            Console.WriteLine("name with concat " + string.Concat(fname, " ", lname));

            // iterpolation
            Console.WriteLine($"Your name is {fname} and {lname} he aahe.");

            // accesing characters in string
            Console.WriteLine("First character in fname is " + fname[0]);

            // find index of character
            Console.WriteLine("Index of 'j' in fname is " + fname.IndexOf('j'));

            //substring  location
            int lastname = lname.IndexOf('K');
            string get_lname = lname.Substring(lastname);

            //get lastname using substring
            Console.WriteLine("Last name using substring is " + get_lname);

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }

            // switch statement

            string day = "Monday";
            switch (day)
            {
                case "Monday":
                    Console.WriteLine("Today is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;
                default:
                    Console.WriteLine("Some other day");
                    break;
            }

            // while loop
            int count = 0;
            while (count < 5)
            {
                count++;
                Console.WriteLine("Count is " + count);
            }

            // do while loop
            do
            {
                Console.WriteLine("Count in do while is " + count);
                count--;
            }while(count > 0);

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("For loop i is " + i);
            }

            // foreach loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine("Car name is " + car);
            }

            // sort array in C#
            Array.Sort(cars);
            foreach (string car in cars)
            {
                Console.WriteLine("Sorted car name is " + car);

            }

            // multidimensional array
            int[,] mutliArr = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Element at (0,0) is " + mutliArr[0,0]);
            Console.ReadLine();

        }
    }
}
