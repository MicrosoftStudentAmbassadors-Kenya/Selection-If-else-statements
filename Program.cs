using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondnumber = int.Parse(Console.ReadLine());
            if (firstnumber > secondnumber)
            {
                Console.WriteLine("First number is greater than second number");
            }
            else if (secondnumber > firstnumber)
            {
                Console.WriteLine("Second number is greater than first number");
            }
            else
            {
                Console.WriteLine("The two numbers are equal");
            }


            string password = "2288shiks";
            string name = "Humphry";
            Console.WriteLine("Enter name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password1 = Console.ReadLine();
            if ((name != name1) && (password != password1))
            {
                Console.WriteLine("Invalid name or password");
                Console.WriteLine("Try again");
            }
            else
            {
                Console.WriteLine("Welcome , enjoy your code");
            }

            Console.WriteLine("Enter any number");
          int number = int.Parse(Console.ReadLine());
          switch (number)
          {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine("The number is odd");
                    break;

                case 2:
                case 4:
                case 6:
                case 8:
                Console.WriteLine("The number is even");
                    break;
                default:
                    Console.WriteLine("The number you entered is out of bounds between 1 and 9");
                    break;
                    ;
            }
        }
      
    }
}
