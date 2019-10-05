using System;
using System.Threading;

namespace CS_Calc
{
    class Program
    {

        // Dots
        static void Dots()
        {
            for (int a = 1; a <= 4; a++)
            {
                String dot = new String('.', a);
                Console.WriteLine(dot);
                Thread.Sleep(120);
            }
            for (int b = 3; b >= 1; b--)
            {
                String dot = new String('.', b);
                Console.WriteLine(dot);
                Thread.Sleep(120);
            }
        }

        static void Main()
        {
            Dots();
            Console.Clear();
            Console.WriteLine("W E L C O M E!");
            Console.WriteLine("==============\n");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1) Addition\n2) Subtraction\n3) Multiplication\n4) Division\n5) Find Square Root\n");
            Console.Write("Select a number: ");
            String choice = Console.ReadLine();
            //TO FIX --- Find a new way to query the items, without calling the methods themselves. This breaks the program.
            //var a = OpCommon().Item1;
            //var b = OpCommon().Item2;
            //var c = OpSqrt().Item1;
            
            if (choice == "1") /* (+) */
            {
                Console.Clear();
                //Console.WriteLine("The answer for " + a + " + " + b + " is: " + (a + b));
            }
            else if (choice == "2") /* (-) */
            {
                Console.Clear();
                //Console.WriteLine("The answer for " + a + " - " + b + " is: " + (a - b));
            }
            else if (choice == "3") /* (*) */
            {
                Console.Clear();
                //Console.WriteLine("The answer for " + a + " * " + b + " is: " + (a * b));
            }
            else if (choice == "4") /* (/) */
            {
                Console.Clear();
                //Console.WriteLine("The answer for " + a + " / " + b + " is: " + (a / b));
            }
            else if (choice == "5") /* (Square Root) */
            {
                Console.Clear();
                //Console.WriteLine("The square root of " + c + " is: " + Math.Sqrt(c));
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Choose a valid number! (1-5)\n");
                Main();
            }
        }

        // For 1-4
        static Tuple<int, int> OpCommon()
        {
            Console.Clear();
            Console.Write("First number: ");
            String x = Console.ReadLine();
            Console.Write("Second number: ");
            String y = Console.ReadLine();
            Int32.TryParse(x, out int a);
            Int32.TryParse(y, out int b);
            return new Tuple<int, int>(a, b);
        }

        // For 5
        static Tuple<double> OpSqrt()
        {
            Console.Clear();
            Console.Write("Number: ");
            String x = Console.ReadLine();
            double.TryParse(x, out double c);
            return new Tuple<double>(c);
        }

    }
}
