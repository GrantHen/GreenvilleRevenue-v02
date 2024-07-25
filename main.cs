using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine();
            DisplayMenu();
        }

        static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("Please Enter the following number below from                                      the following menu:");
                Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-                                        Year");
                Console.WriteLine("2. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CalculateRevenue();
                        break;
                    case "2":
                        Console.WriteLine("Thank you for using the Greenville                                                 Revenue App, good-bye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void CalculateRevenue()
        {
            Console.WriteLine("Enter the number of contestants from the previous                                 year:");
            int lastYearContestants = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of contestants for the current                                    year:");
            int currentYearContestants = int.Parse(Console.ReadLine());
            int revenue = currentYearContestants * 25;
            if (currentYearContestants > lastYearContestants * 2)
            {
                Console.WriteLine("The competition is more than twice as big this                                     year!");
            }
            else if (currentYearContestants > lastYearContestants)
            {
                Console.WriteLine("The competition is bigger than ever!");
            }
            else
            {
                Console.WriteLine("A tighter race this year! Come out and cast                                        your vote!");
            }

            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************");
            Console.WriteLine();
        }
    }