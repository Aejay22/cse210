using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favourite number: ");
            string Number = Console.ReadLine();
            return int.Parse(Number);
        }

        static int SquareNumber(int number)
        {
            return number * number;
        }

        
        static void DisplayMessage()
        {
            Console.WriteLine($"{PromptUserName()}, the square of your number is {SquareNumber(PromptUserNumber())}");
        }

        
        DisplayMessage();
    }
}