using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //call for SayHi method
            SayHi();

            //another method
            AddNumbers();

            //freeze the console
            Console.ReadLine();

            //Get Max method
            Console.WriteLine(GetMax(2, 3));
            Console.ReadLine();

        }
        //creating a method named SayHi and calling it in the main method
        static void SayHi()
        {
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
        }
        //creating second method named AddNumbers which is an int method not void and calling it in the main method
        static void AddNumbers()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the sum of the numbers entered is " + (num1 + num2));
        }
        static int GetMax(int num1, int num2)
        {
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("The maximum number between number1 and number2 is: ");
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}
