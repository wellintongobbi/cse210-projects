using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing Activity",
        "Relax by breathing slowly. Focus on your breath.") { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);

            Console.Write("\nBreathe out... ");
            ShowCountdown(4);
        }

        DisplayEndingMessage();
    }
}