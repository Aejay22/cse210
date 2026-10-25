using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Do you want to play a game (yes/no)? ");
        string answer = Console.ReadLine();


        while (answer.ToLower() == "yes"){
            Console.Write("What is your magic number? ");
            string MagicNumber = Console.ReadLine();

            Console.Write("What is your guess? ");
            string MagicNumberGuess = Console.ReadLine();
            
            int guessCount = 1;
            

            while (int.Parse(MagicNumberGuess) != int.Parse(MagicNumber))
            {
                if (int.Parse(MagicNumberGuess) > int.Parse(MagicNumber))
                {
                    Console.WriteLine("Lower");
                }
                else if (int.Parse(MagicNumberGuess) < int.Parse(MagicNumber))
                {
                    Console.WriteLine("Higher");    
                }
                Console.Write("What is your guess? ");
                MagicNumberGuess = Console.ReadLine();
                guessCount++;
            }
            Console.WriteLine("You guessed it");
            Console.WriteLine($"It took you {guessCount} guess.");
            guessCount = 0;
            Console.Write("Do you want to continue playing (yes/no)? ");
            answer = Console.ReadLine();
            

        }


        


    }
}