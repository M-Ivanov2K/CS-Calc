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

            Dots();
            Console.Clear();
            Console.WriteLine("W E L C O M E!");
            Console.WriteLine("==============\n");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1) Addition\n2) Subtraction\n3) Multiplication\n4) Division\n5) Find Square Root\n6) Exit\n");
            Console.Write("Select a number: ");
            String choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                Console.Clear();
                Console.Write("First number: ");
                try { a = Convert.ToDouble(Console.ReadLine()); }
                catch { a = 0; }
                Console.Write("Second number: ");
                try { b = Convert.ToDouble(Console.ReadLine()); }
                catch { b = 0; }
                Console.Clear();
            }
            else if (choice == "5")
            {
                Console.Clear();
                Console.Write("Number: ");
                try { c = Convert.ToDouble(Console.ReadLine()); }
                catch { c = 0; }
                Console.Clear();
            }
            else if (choice == "6") { Console.Clear(); System.Environment.Exit(1); }
            else
            {
                Console.Clear();
                Console.WriteLine("Choose a valid option! (1-6)\n");
                Main();
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
