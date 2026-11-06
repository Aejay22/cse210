using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

// This program can append to a file instead of ovewriting the data in that file.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");
        List<string>choices = new List<string>();
        choices.Add("Write");
        choices.Add("Display");
        choices.Add("Load");
        choices.Add("Save");
        choices.Add("Quit");


        
        PromptGenerator promptsGenerator = new PromptGenerator();
        promptsGenerator._prompts.Add("Who was the most interesting person I interacted with today?");
        promptsGenerator._prompts.Add("What was the best part of my day?");
        promptsGenerator._prompts.Add(" How did I see the hand of the Lord in my life today?");
        promptsGenerator._prompts.Add("What was the strongest emotion I felt today?");
        promptsGenerator._prompts.Add("If I had one thing I could do over today, what would it be?");
        promptsGenerator._prompts.Add("What is one thing I learned today?");
        promptsGenerator._prompts.Add("What is one goal I want to work on tomorrow?");
        promptsGenerator._prompts.Add("What challenge did I face today, and how did I handle it?");
        promptsGenerator._prompts.Add("Who did I help today, or who helped me?");
        promptsGenerator._prompts.Add("What am I grateful for today?");

        
        string answer = "";
        while(answer != "5"){
            Console.WriteLine("Please Select one of the following choices:");
            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i+1}. {choices[i]}");
            }
            Console.Write("What would you like to do? ");
            answer = Console.ReadLine();
        
            if (answer == "1")
            {
                Entry entry = new Entry();

                string today = DateTime.Now.ToString("dd-MM-yyyy");
                entry._date = today;
                entry._promptText = promptsGenerator.GetRandomPrompts();
                Console.Write($"{entry._promptText}\n> ");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);

            }
            else if (answer == "2")
            {
                journal.DisplayAll();
            }
            else if (answer == "3")
            {
                Console.Write("Please enter the file name? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                
            }
            else if (answer == "4")
            {
                Console.Write("Please enter the file name? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename); 
            }
            else if (answer == "5")
            {
                Console.WriteLine("Thank You for using this program");
                break;
            }
            else
            {
                Console.WriteLine("Please Enter A number from 1-5");
                
            }

        }


    }
}