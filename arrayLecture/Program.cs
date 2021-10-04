using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring and Instantiating Arrays
            string[] titles = new string[3];

            double[] prices;
            prices = new double[4];

            int population = 329000000;
            bool[] IsVaccinated = new bool[population];

            //giving arrays values
            double[] favNumbers = { 1, 5, 17, 19, 21, 25, 15};
            favNumbers[0] = 100;

            Console.WriteLine(favNumbers[0]);

            //looping through arrays
            //for loop
            string[] snacks = {
                "Doritos",
                "Baja Blast",
                "Chips and Salsa",
                "Jerky",
                "Sour Gummy Worms",
                "Vanilla Instant Pudding",
                "Funyuns",
                "Hot Cheet Puffs",
                "Chocolate Covered Honeybuns",
                "Hot Wings",
                "Met-rx Bar",
                "White Cheddar Hippeas",
                "Doritos",
                "Barbecue chips",
                "Starbucks Frappe"
            };

            for (int i = 0; i < snacks.Length; i++)
            {
                Console.WriteLine(snacks[i]);
            }

            //adding all numbers using for loop
            double total = 0;
            for (int i = 0; i < favNumbers.Length; i++)
            {
                total += favNumbers[i];
            }
            double average = total / favNumbers.Length;
            Console.WriteLine($"The average of your favorite numbers is {average}");

            //looping through arrays
            //foreach
            string[] names =
            {
                "Justin",
                "Aaron",
                "Brandon",
                "Chris",
                "Delmar",
                "Josh",
                "Kasean",
                "Logan",
                "Matt",
                "Radeen",
                "Raston",
                "Scott",
                "Yousif"
            };

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            double sum = 0;
            foreach(double num in favNumbers)
            {
                sum += num;
            }
            double avg = sum / favNumbers.Length;
            Console.WriteLine($"The average of your favorite numbers is {avg}");

            //referencing arrays
            int[] ages = { 21, 24, 36, 44, 56 };
            int[] agesReference = ages;
            agesReference[0] = 50;

            Console.WriteLine(ages[0]);
            Console.WriteLine(agesReference[0]);

            //copying arrays
            int[] agesCopy = new int[ages.Length];
            ages.CopyTo(agesCopy, 0);

            agesCopy[0] = 100;
            Console.WriteLine(ages[0]);
            Console.WriteLine(agesCopy[0]);

            //2d Arrays
            int[,] numbers = new int[3,2]; //[rows,columns]
            numbers[2, 1] = 1;

            //Jagged Arrays
            int[][] values = new int[3][];


            //-------------------------------------------------------------------------------------------------------------------------
            //Collections
            //Generics - these are the good modern ones

            //Non-generics - These are the old wrinkly ones
            //ArrayList
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(5);
            myArrayList.Add("Yash");
            foreach(var i in myArrayList) //not recommended to use 'var', use int 
            {
                Console.WriteLine(i);
            }

            //list
            List<int> myLeastFavNums = new List<int>();
            myLeastFavNums.Add(11);
            foreach(int i in myLeastFavNums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
