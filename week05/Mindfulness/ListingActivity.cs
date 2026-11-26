using System;
using System.Diagnostics;
using System.Reflection.Metadata;
public class ListingActivity: Activity
{
    private List <string> _user = new List<string>();
    private List<int> _used = new List<int>();
    private int _count;

    private List<string>_prompts = ["Who are people that you appreciate?", "Who are people that you have helped this week?", "What are personal strengths of yours?"," Who are some of your personal heroes?", "When have you felt the Holy Ghost this month?"];
    public ListingActivity():base()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on good things in your life by having you list as many thins as you can in a certain area";
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Write("\n");
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_duration);
        while(currentTime < futureTime)
        {
            Console.Write("> ");
            string user = Console.ReadLine();
            _user.Add(user);
            currentTime = DateTime.Now;
        }
        _count = GetListFromUser().Count;
        Console.WriteLine($"You have listed {_count} items!");
        DisplayEndingMessage();
        Console.Clear();
    }
    public void GetRandomPrompt()
    {
        if(_used.Count == _prompts.Count)
        {
            _used = [];
        }
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        while (_used.Contains(index))
        {
            index = random.Next(_prompts.Count);
        }
        _used.Add(index);
        Console.WriteLine(_prompts[index]);
    }
    public List<string> GetListFromUser()
    {
        return _user;
    }
}