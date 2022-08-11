using System;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 3
            Console.Write("pls enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("pls enter b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("pls enter c: ");
            int c = int.Parse(Console.ReadLine());  
            if (a>b&&b>c)
            {
                Console.WriteLine("the first number is the greatest number among three");
            }
            if (b>c&&b>a)
            {
                Console.WriteLine("the second number is the greatest number among three");
            }
            else
              {
                Console.WriteLine("the third number is the greatest number among three");

            }
            //task 4

            // we should get number from user 
            Console.Write("pls enter number from 1 to 7: ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }

        }
    }
}
