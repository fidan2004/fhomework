using System;

namespace task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 5
            int num1;
            int num2;
            string operand;

            Console.Write("pls enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("pls enter num2: ");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.Write("pls enter operand");
            operand = Console.ReadLine();   
            switch (operand)
            {
                case "addition":
                    Console.WriteLine(num1 + num2);
                    break;
                case "subtraction":
                    Console.WriteLine(num1 - num2);
                    break;
                case "multiplication":
                    Console.WriteLine(num1 * num2);
                    break;
                case "division":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("exit");
                    break;
             }
            //task 6

            Console.Write("Enter a Number To Check Palindrome : ");
            int number = int.Parse(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {

                remineder = number % 10;
                sum = (sum * 10) + remineder;
                number = number / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
        }
     }
}
