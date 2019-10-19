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
                Thread.Sleep(90);
            }
            for (int b = 3; b >= 1; b--)
            {
                String dot = new String('.', b);
                Console.WriteLine(dot);
                Thread.Sleep(90);
            }
        }

        static void Main()
        {
            double a = 0; double b = 0; double c = 0;
            bool loop = true;

            Dots();
            Console.Clear();
            Console.WriteLine("W E L C O M E!");
            Console.WriteLine("==============\n");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1) Addition\n2) Subtraction\n3) Multiplication\n4) Division\n5) Find Square Root\n6) Exit\n");
            Console.Write("Select a number: ");
            String choice = Console.ReadLine();

            Console.Clear();
            if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                while (loop == true)
                {
                    try
                    {
                        Console.Write("First number: ");
                        a = Double.Parse(Console.ReadLine());
                        Console.Write("Second number: ");
                        b = Double.Parse(Console.ReadLine());
                        Console.Clear();
                        loop = false;
                    }
                    catch (Exception)
                    {
                        Retry();
                    }
                }
            }
            else if (choice == "5")
            {
                while (loop == true)
                {
                    try
                    {
                        Console.Write("Number: ");
                        c = Double.Parse(Console.ReadLine());
                        Console.Clear();
                        loop = false;
                    }
                    catch (Exception)
                    {
                        Retry();
                    }
                }
            }
            else if (choice == "6") { System.Environment.Exit(1); }
            else
            {
                Console.WriteLine("Choose a valid option! (1-6)\n");
                Main();
            }

            // Retry number(s) request on exception
            static void Retry()
            {
                Console.Clear();
                Console.Write("Please try again..");
                Thread.Sleep(600);
                Console.Clear();
            }

            // Operations
            if (choice == "1") /* (+) */ { Console.WriteLine("The answer for " + a + " + " + b + " is: " + (a + b) + "\n"); }
            else if (choice == "2") /* (-) */ { Console.WriteLine("The answer for " + a + " - " + b + " is: " + (a - b) + "\n"); }
            else if (choice == "3") /* (*) */ { Console.WriteLine("The answer for " + a + " * " + b + " is: " + (a * b) + "\n"); }
            else if (choice == "4") /* (/) */ { Console.WriteLine("The answer for " + a + " / " + b + " is: " + (a / b) + "\n"); }
            else if (choice == "5") /* (Square Root) */ { Console.WriteLine("The square root of " + c + " is: " + Math.Sqrt(c) + "\n"); }

            Console.Write("Press any key to go back to the main menu..");
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
