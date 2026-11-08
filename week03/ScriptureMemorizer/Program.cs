using System;
/* 
Memmory verse in this program are in a file and are retrieved to be used when called upon
This program will not hide a word that is already hidden
*/
class Program
{
    static void Main(string[] args)
    {
        string response = "";
        MemoryVerse memoryVerse = new MemoryVerse();
        memoryVerse.LoadFromFile();
        memoryVerse.GetMemoryVerse();
        
        Console.Write("Please select the scripture you want to memorize ");
        
        string response1 = Console.ReadLine();
        memoryVerse.Answer(int.Parse(response1));
        Scripture scripture1 = memoryVerse.ReturnScripture();


        Console.WriteLine(scripture1.GetDisplayText());
        Console.Write("Press enter to continue or type 'quit' to finish");
        response = Console.ReadLine();        
        while(response.ToLower() != "quit" && !scripture1.IsCompletelyHidden())
        {
            Random random = new Random();
            int number = random.Next(1,4);
            scripture1.HideRandomWords(number);
            Console.WriteLine(scripture1.GetDisplayText());
            Console.Write("Press enter to continue or type 'quit' to finish");
            response = Console.ReadLine();

        }
    }
}