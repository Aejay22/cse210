using System;
using System.Collections.Generic;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {
        
    } 
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in secondes, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(10);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("Get ready...");
        ShowSpinner(10);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
    }
    public void ShowSpinner(int seconds)
    {
        List<string>spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        int i = 0;
        while(currentTime < futureTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i == spinner.Count)
            {
                i=0;
            }
            currentTime = DateTime.Now;
        }
    }
    public void ShowCountDown(int seconds)
    {
        while(seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }
}