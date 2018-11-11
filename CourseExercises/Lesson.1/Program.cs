using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson._1 {
    class Program {
        static void Main(string[] args) {
            printMainMenu();
        }

        static public void printMainMenu() {
            Console.Clear();

            Console.WriteLine("Choose your oprion and press [Enter]:");
            Console.WriteLine("1. Exersise #1");
            Console.WriteLine("2. Exersise #2");
            Console.WriteLine("3. Exersise #3");
            Console.WriteLine("4. Exersise #4");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter number: ");
            string s = Console.ReadLine();

            int option = -1;

            try {
                option = Convert.ToInt32(s);
            } catch (FormatException fe) {
                Console.WriteLine("\nPlease enter digits only");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                printMainMenu();
            }   

            switch (option) {
                case 1:
                    exerciseOne();
                    break;
                case 2:
                    exerciseTwo();
                    break;
                case 3:
                    exerciseThree();
                    break;
                case 4:
                    exerciseFour();
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose appropriate number");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    printMainMenu();
                    break;
            }
        }

        public static void exerciseOne() {
            Console.Clear();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter some number: ");
            string number = Console.ReadLine();

            Console.WriteLine("\nHello, " + name + " " + surname + ". You have entered number " + number + ".");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            printMainMenu();
        }

        public static void exerciseTwo() {
            Console.Clear();

            Console.Write("Enter first variable: ");
            string var1 = Console.ReadLine();
            Console.WriteLine("Variable1 = " + var1);
            Console.WriteLine();

            Console.Write("Enter second variable: ");
            string var2 = Console.ReadLine();
            Console.WriteLine("Variable2 = " + var2);
            Console.WriteLine();

            string var3 = var1;
            var1 = var2;
            var2 = var3;

            Console.WriteLine("After mutual exchange");
            Console.WriteLine("Variable1 = " + var1);
            Console.WriteLine("Variable2 = " + var2);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            printMainMenu();
        }

        public static void exerciseThree() {
            Console.Clear();

            Console.Write("Enter number to multiply: ");
            string num = Console.ReadLine();

            int factor = 0;
            try {
                factor = Convert.ToInt32(num);
            } catch (FormatException fe) {
                Console.WriteLine("\nPlease enter digits only");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                exerciseThree();
            }

            Console.WriteLine();
            for (int i=1; i<=10; i++) {
                Console.WriteLine(factor + "*" + i + "=" + (factor * i));
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            printMainMenu();
        }

        public static void exerciseFour() {
            Console.Clear();

            Console.Write("Enter four digits (comma separated): ");
            string line = Console.ReadLine();

            string[] lineItems = line.Split(',');
            int[] intItems = Array.ConvertAll(lineItems, s => int.Parse(s));
            int sum = Sum(intItems);

            Console.WriteLine("\nAverage = " + ((decimal)sum / intItems.Length));

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            printMainMenu();
        }

        public static int Sum(params int[] items) {
            int result = 0;

            for (int i = 0; i < items.Length; i++) {
                result += items[i];
            }

            return result;
        }

    }
}
