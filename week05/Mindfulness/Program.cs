using System;

/*
Creativity:
Added a spinner animation and countdown timer.
*/

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("\nSelect a choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity =
                    new BreathingActivity();

                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity =
                    new ReflectionActivity();

                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity =
                    new ListingActivity();

                activity.Run();
            }
        }
    }
}