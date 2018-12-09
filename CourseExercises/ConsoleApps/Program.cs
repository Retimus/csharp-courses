using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApps {
    class Program {
        static void Main(string[] args) {
            PrintMainMenu();
        }

        static public void PrintMainMenu() {
            Console.Clear();

            Console.WriteLine("Choose your oprion and press [Enter]:");
            Console.WriteLine("1. Exersise #1");
            Console.WriteLine("2. Exersise #2");
            Console.WriteLine("3. Exersise #3");
            Console.WriteLine("4. Exersise #4");
            Console.WriteLine("5. Exersise #5 (Conditional statements)");
            Console.WriteLine("6. Exersise #6 (Loops)");
            Console.WriteLine("7. Exersise #7 (Arrays)");
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
                PrintMainMenu();
            }   

            switch (option) {
                case 1:
                    ExerciseOne();
                    break;
                case 2:
                    ExerciseTwo();
                    break;
                case 3:
                    ExerciseThree();
                    break;
                case 4:
                    ExerciseFour();
                    break;
                case 5:
                    ExerciseFive();
                    break;
                case 6:
                    ExerciseSix();
                    break;
                case 7:
                    ExerciseSeven();
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose appropriate number");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    PrintMainMenu();
                    break;
            }
        }

        public static void ExerciseOne() {
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
            PrintMainMenu();
        }

        public static void ExerciseTwo() {
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
            PrintMainMenu();
        }

        public static void ExerciseThree() {
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
                ExerciseThree();
            }

            Console.WriteLine();
            for (int i=1; i<=10; i++) {
                Console.WriteLine(factor + "*" + i + "=" + (factor * i));
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            PrintMainMenu();
        }

        public static void ExerciseFour() {
            Console.Clear();

            Console.Write("Enter four digits (comma separated): ");
            string line = Console.ReadLine();

            string[] lineItems = line.Split(',');
            int[] intItems = Array.ConvertAll(lineItems, s => int.Parse(s));
            int sum = Sum(intItems);

            Console.WriteLine("\nAverage = " + ((decimal)sum / intItems.Length));

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            PrintMainMenu();
        }

        public static void ExerciseFive() {
            Console.Clear();

            Console.Write("Enter year value (in four digits format): ");
            string year = Console.ReadLine();

            int intYear = 0;
            try {
                intYear = Convert.ToInt32(year);
            } catch (FormatException fe) {
                Console.WriteLine("\nPlease enter digits only");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                ExerciseFive();
            }

            if (year.Length != 4) {
                Console.WriteLine("\nYou should enter 4 digits");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                ExerciseFive();
            }

            if (DateTime.IsLeapYear(intYear)) {
                Console.WriteLine("{0} is a leap year.", year);
            } else {
                Console.WriteLine("{0} is not a leap year.", year);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            PrintMainMenu();
        }

        public static void ExerciseSix() {
            Console.Clear();

            Console.Write("Enter any number: ");
            string number = Console.ReadLine();

            int intNumber = 0;
            try {
                intNumber = Convert.ToInt32(number);
            } catch (FormatException fe) {
                Console.WriteLine("\nPlease enter digits only");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                ExerciseSix();
            }

            string lineOfOnes = "1";
            long result = 0;
            for (int i = 0; i < intNumber; i++) {
                result += Convert.ToInt64(lineOfOnes);
                lineOfOnes += "1";
            }

            Console.WriteLine("\nSeries sum = " + result);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            PrintMainMenu();
        }

        public static void ExerciseSeven() {
            Console.Clear();

            Console.Write("Enter an array length: ");
            string length = Console.ReadLine();

            int intLength = 0;
            try {
                intLength = Convert.ToInt32(length);
            } catch (FormatException fe) {
                Console.WriteLine("\nPlease enter digits only");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                ExerciseSeven();
            }

            Console.Write("Enter an array elements (comma separated): ");
            string lineElements = Console.ReadLine();

            string[] lineItems = lineElements.Split(',');
            if (lineItems.Length != intLength) {
                Console.WriteLine("\nEntered elements doesn't fit entered array length");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                ExerciseSeven();
            }

            int[] intItems = new int[intLength];

            try {
                intItems = Array.ConvertAll(lineItems, s => int.Parse(s));
            } catch (FormatException fe) {
                Console.WriteLine("\nPlease enter digits only for array elements");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                ExerciseSeven();
            }

            Console.WriteLine();
            bool didSwap;
            do {
                didSwap = false;
                for (int i = 0; i < intItems.Length - 1; i++) {
                    if (intItems[i] > intItems[i + 1]) {
                        int temp = intItems[i + 1];
                        intItems[i + 1] = intItems[i];
                        intItems[i] = temp;
                        didSwap = true;
                    }
                }
            } while (didSwap);
            for (int i = 0; i != intItems.Length; i++) {
                Console.WriteLine(intItems[i]);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            PrintMainMenu();
        }

        private static int Sum(params int[] items) {
            int result = 0;

            for (int i = 0; i < items.Length; i++) {
                result += items[i];
            }

            return result;
        }

    }
}
