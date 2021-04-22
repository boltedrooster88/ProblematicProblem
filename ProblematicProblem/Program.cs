using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    public class Program
    {
        public static Random rng;
        public static readonly bool cont = true;
        public static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            bool cont;

            if (Console.ReadLine().ToLower() == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
                Console.WriteLine("Goodbye!");
            }


            Console.WriteLine();

            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            bool seeList;

            if (Console.ReadLine().ToLower() == "sure")
            {
                seeList = true;
            }
            else
            {
                seeList = false;
                Console.WriteLine("Goodbye!");
            }
            if (seeList)
            {
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                bool addToList;

                if (Console.ReadLine().ToLower() == "yes")
                {
                    addToList = true;

                    Console.WriteLine();

                    while (addToList)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();

                        activities.Add(userAddition);

                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: ");
                bool addToList1;
                if (Console.ReadLine().ToLower() == "yes")
                {
                    addToList1 = true;

                    Console.WriteLine();

                    while (addToList1)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();

                        activities.Add(userAddition);

                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        break;
                    }
                }

            }

            while (cont)
            {
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();
                var rng = new Random();

                int randomNumber = rng.Next(activities.Count);

                string randomActivity = activities[rng.Next(activities.Count)];

                if (userAge < 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine(value: $"Oh no! Looks like you are too young to do {randomActivity}");

                    Console.WriteLine("Pick something else!");

                    activities.Remove(randomActivity);

                    randomNumber = rng.Next(activities.Count);

                    randomActivity = activities[randomNumber];
                }



                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? yes/no: ");
                Console.WriteLine();

                if (Console.ReadLine().ToLower() == "yes")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }
    }
}

   
