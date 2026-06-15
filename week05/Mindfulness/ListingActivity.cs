using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base(
            "Listing",
            "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine(
            $"\n{_prompts[random.Next(_prompts.Count)]}");

        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);

        int count = 0;

        DateTime endTime =
            DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine(
            $"\nYou listed {count} items.");

        DisplayEndingMessage();
    }
}