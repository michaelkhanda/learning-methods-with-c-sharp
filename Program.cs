using System;

namespace Methods
{
    class Program
    {
        static int Sum(int a, int b)
        {
            int Sum = a + b;
            return Sum;
        }
        static int Difference(int a, int b)
        {
            int Difference = a - b;
            return Difference;
        }
        static int Product(int a, int b)
        {
            int Product = a * b;
            return Product;
        }
        static int Quotient(int a, int b)
        {
            int Quotient = a / b;
            return Quotient;
        }


        static void Main(string[] args)
        {
            int a, b;
            string answer = "N";
            do
            {
                Console.WriteLine("Enter a number: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number: ");
                b = int.Parse(Console.ReadLine());

                int S = Sum(a, b);
                Console.WriteLine("The sum of the two numbers is: " + S);
                int D = Difference(a, b);
                Console.WriteLine("The difference between the two numbers is: " + D);
                int P = Product(a, b);
                Console.WriteLine("The product of the two numbers is: " + P);
                int Q = Quotient(a, b);
                Console.WriteLine("The quotient between the two numbers is: " + Q);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("DO YOU WANT TO PERFORM ANOTHER CALCULATION?(Y/N)");
                Console.ResetColor();
                answer = Console.ReadLine();
                //Console.ResetColor();

            } while (answer == "Y");






        }

    }
}
