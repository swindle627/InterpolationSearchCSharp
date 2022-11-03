using System;

namespace Interpolation_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int[] values = new int[1024];
            int tableSize = 0;
            TestIS testIS = new TestIS();

            while (option != 4)
            { 
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Create and display array values[]");
                Console.WriteLine("2. Read output table size");
                Console.WriteLine("3. Run algorithm and display outputs");
                Console.WriteLine("4. Exit program");
                Console.WriteLine("\nEnter option number:");

                option = Convert.ToInt32(Console.ReadLine());

                if(option == 1)
                {
                    Console.Clear();
                    values = testIS.RandomDistinct();
                }
                else if(option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter table size: ");
                    tableSize = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Table size set to " + tableSize);
                }
                else if(option == 3)
                {
                    Console.Clear();
                    testIS.RunIS(values, tableSize);
                }

                if(option != 4)
                {
                    Console.WriteLine("\nPress enter to contiune...");
                    ConsoleKeyInfo c;
                    do
                    {
                        c = Console.ReadKey();
                    }
                    while (c.Key != ConsoleKey.Enter);
                }
                
                Console.Clear();
            }

            Environment.Exit(0);
        }
    }
}
