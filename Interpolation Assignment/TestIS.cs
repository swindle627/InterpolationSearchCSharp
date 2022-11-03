using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Interpolation_Assignment
{
    class TestIS
    {
        public int[] RandomDistinct()
        {
            int[] values = new int[1024]; // array will contain random distinct numbers between 1 and 9999
            Random rnd = new Random();

            // Generates random, distinct ints in the array
            for(int i = 0; i < values.Length; i++)
            {
                int val;
                do
                {
                    val = rnd.Next(1, 10000); // rnd.Next(inclusive, exclusive)
                }
                while (values.Contains(val));

                values[i] = val;
            }

            // Sorts the array from lowest to highest
            Array.Sort(values);

            int newLine = 0;

            // Displays the array of ints, 30 values per line
            foreach(int i in values)
            {
                Console.Write(i + "  ");
                newLine++;

                if(newLine == 30)
                {
                    Console.WriteLine();
                    newLine = 0;
                }
            }

            return values;
        }
        public void RunIS(int[] values, int tableSize)
        {
            float average = 0;
            float keyAmount = tableSize;

            // Creates table header
            Console.WriteLine("Key\tFound\tIndex\tDivisions");
            Console.WriteLine("-------------------------------------");

            // Generates random keys between 1-9999 to search for in the array
            // After the search is complete data is placed into the table
            // tableSize determines how many times this loop runs
            while(tableSize != 0)
            {
                Random rnd = new Random();
                int key = rnd.Next(1, 10000);
                InterpolationSearch search = new InterpolationSearch(values, key);
                Console.WriteLine(key + "\t" + search.found + "\t" + search.index + "\t" + search.divisions);
                average += search.divisions;
                tableSize--;
            }

            // Calculate divisions average
            average = MathF.Round(average / keyAmount, 3);

            // lg(lg 1024) - average
            float difference = 3.322f - average;

            Console.WriteLine("Divisions Average: " + average);
            Console.WriteLine("Difference: " + difference);
        }
    }
}
