using System;

namespace Mondaystask
{
    class Program
    {
        static void Main(string[] args)
        {


/*
            char letter;
            letter = 'a';
            Console.WriteLine("Hello World!");
            double length, height;
            Console.WriteLine("Enter the length of the triangle in m");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of the triangle in m");
            height = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * length * height;
            Console.WriteLine(area);


            Console.WriteLine("enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("number1 is greator than number2");
            }
            else if (number2 > number1)
            {
                Console.WriteLine("number2 is greator than number1");
            }

            else
            {
                Console.WriteLine("number2 is equal to number1");
            }*/

            string name = "charity";
            string password = "charity1234";
            Console.WriteLine("enter your name");
            string name1 = Console.ReadLine();
            Console.WriteLine("enter your password");
            string password1 = Console.ReadLine();
            if( (name1==name)&&(password1==password))
            {
                Console.WriteLine("welcome");
            }
            else
            {
                Console.WriteLine("log in unsuccessful,you have 2 attempts");
                Console.WriteLine("enter your name");
                string name2 = Console.ReadLine();
                Console.WriteLine("enter your password");
                string password2 = Console.ReadLine();
                if ((name2 == name) && (password2 == password))
                {
                    Console.WriteLine("welcome");
                }
                else
                {
                    Console.WriteLine("log in unsuccessful,you have 1 attempt");
                    Console.WriteLine("enter your name");
                    string name3 = Console.ReadLine();
                    Console.WriteLine("enter your password");
                    string password3 = Console.ReadLine();
                    if ((name3 == name) && (password3 == password))
                    {
                        Console.WriteLine("welcome");
                    }
                    else
                    {
                        Console.WriteLine("You have exhausted,Blocked");

                    }

                }
            }

        }
    }
}
