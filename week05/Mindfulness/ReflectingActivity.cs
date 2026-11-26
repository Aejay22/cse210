using System;
using System.Diagnostics;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
    private List<string> _questions = [
                                        "Why was this experience meaningful to you?", 
                                        "Have you ever done anything like this before?", 
                                        "How did you get started?", 
                                        "How did you feel when it was complete?", 
                                        "What made this time different than other times when you were not as successful?", 
                                        "What is your favorite thing about this experience?", 
                                        "What could you learn from this experience that applies to other situations?", 
                                        "What did you learn about yourself through this experience?", 
                                        "How can you keep this experience in mind in the future?"
                                        ];
    private List<int> _used = new List<int>();
    private List<int> _usedQuestion = new List<int>(); 
    public ReflectingActivity():base()
    {
        _name = "Reflecting Activity";
        _description ="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine("");
        DisplayPrompt();
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press any key to continue.");
        string enteredKey = Console.ReadLine();
        string key = enteredKey;
        if(key == enteredKey)
        {
            Console.WriteLine("");
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();
            int time = 5;
            while(_duration > 0)
            {
                DisplayQuestions();
                if(_duration < 7)
                {
                    time = _duration;
                }
                ShowSpinner(time);
                Console.Write("\n");
                _duration -= time;
            }
            Console.WriteLine();
            DisplayEndingMessage();
        }


    }
    public string GetRandomPrompt()
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
        return _prompts[index];
    }
    public string GetRandomQuestions()
    {
        if(_usedQuestion.Count == _questions.Count)
        {
            _usedQuestion = [];
        }
        Random random = new Random();
        int index = random.Next(_questions.Count);
        while (_usedQuestion.Contains(index))
        {
            index = random.Next(_questions.Count);
        }
        _usedQuestion.Add(index);
        
        return _questions[index];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestions()
    {
        Console.Write("> ");
        Console.Write(GetRandomQuestions());
    }

}