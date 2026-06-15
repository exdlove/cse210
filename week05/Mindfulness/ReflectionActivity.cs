using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself?",
        "How can you remember this experience?"
    };

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity helps you reflect on strengths and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine(
            $"\n{_prompts[random.Next(_prompts.Count)]}");

        Console.WriteLine(
            "\nReflect on the following questions:");

        DateTime endTime =
            DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(
                $"\n> {_questions[random.Next(_questions.Count)]}");

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}