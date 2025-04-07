using System.Runtime.CompilerServices;

namespace Topic_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Which part would you like to view?:");
                Console.WriteLine();
                Console.WriteLine("1 - Part 1: Lists of Integers");
                Console.WriteLine("2 - Part 2: Lists of Strings");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                    Integers();

                else if (choice == "2")
                    Strings();

                else if (choice == "q");

                else
                {
                    Console.WriteLine("Invalid choice, please hit ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }

        static void Integers()
        {
            Random generator = new Random();
            List<int> numbers = new List<int>();

            for (int i = 0; i < 15; i++)
            {
                numbers.Add(generator.Next(10,21));
            }

            string choice = "";

            while (choice != "m")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(string.Join(", ", numbers));
                Console.WriteLine();
                Console.WriteLine("Which part would you like to view?:");
                Console.WriteLine();
                Console.WriteLine($"Current List:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort the List");
                Console.WriteLine("2 - New List");
                Console.WriteLine("3 - Remove Number");
                Console.WriteLine("4 - Add Number");
                Console.WriteLine("5 - Number Frequency (Specific)");

               Console.WriteLine();

                Console.WriteLine("6 - Largest Value");
                Console.WriteLine("7 - Smallest Value");
                Console.WriteLine("8 - Total & Average");
                Console.WriteLine("9 - Number Frequency (Most common)");
                Console.WriteLine("10 - Number Frequency & Most Frequent (All)");

                Console.WriteLine();

                Console.WriteLine("M = Back to main menu (QUIT)");

                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1"||choice == "sort"||choice == "sort list"||choice == "sort the list")
                {

                }

                else if (choice == "2"||choice == "new"||choice == "new list")
                {

                }

                else if (choice == "3"||choice == "remove"||choice == "remove number")
                {

                }

                else if (choice == "4")
                {

                }

                else if (choice == "5")
                {

                }
                //
                else if (choice == "6")
                {

                }

                else if (choice == "7")
                {

                }

                else if (choice == "8")
                {

                }

                else if (choice == "9")
                {

                }

                else if (choice == "10")
                {

                }
                //
                else if (choice == "m") ;

                else
                {
                    Console.WriteLine("Invalid choice, please hit ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }

        static void Strings()
        {
            List<string> vegetables = new List<string>() {"carrot","celery","beet","radish","cabbage"};
        }

    }
}
