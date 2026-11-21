using System;
using System.Linq;
/* 
This program contains multiple verse
the program has a menu where the user can choose from one memory verse to memorise
This program will not hide a word that is already hidden
*/
class Program
{
    static void Main(string[] args)
    {

        string[] verse1 = { "Psalm","121:1-4","I will lift up mine eyes unto the hills, from whence cometh my help. My help cometh from the LORD, which made heaven and earth. Behold, he that keepeth Israel shall neither slumber nor sleep."};
        string[] verse2 = {"Joshua","1:8-9","This book of the law shall not depart out of thy mouth; but thou shalt meditate therein day and night, that thou mayest observe to do according to all that is written therein: for then thou shalt make thy way prosperous, and then thou shalt have good success. Have not I commanded thee? Be strong and of a good courage; be not afraid, neither be thou dismayed: for the LORD thy God is with thee whithersoever thou goest."};
        string[] verse3 = {"Psalm","23:1","The LORD is my shepherd; I shall not want."};
        string[] verse4 = {"Isaiah","41:10","Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."};
        string[] verse5 = {"Psalm","121:1-3","I will lift up mine eyes unto the hills, from whence cometh my help. My help cometh from the LORD, which made heaven and earth. He will not suffer thy foot to be moved: he that keepeth thee will not slumber."};
        string response = "";
        MemoryVerse memoryVerse = new MemoryVerse();
        memoryVerse.LoadFromFile(verse1);
        memoryVerse.LoadFromFile(verse2);
        memoryVerse.LoadFromFile(verse3);
        memoryVerse.LoadFromFile(verse4);
        memoryVerse.LoadFromFile(verse5);

        memoryVerse.GetMemoryVerse();
        
        Console.Write("Please select the scripture you want to memorize: ");
        
        string response1 = Console.ReadLine();
        memoryVerse.Answer(int.Parse(response1));
        Scripture scripture1 = memoryVerse.ReturnScripture();


        Console.WriteLine(scripture1.GetDisplayText());
        Console.Write("Press enter to continue or type 'quit' to finish");
        
        
        response = Console.ReadLine(); 
        Console.Clear();       
        while(response.ToLower() != "quit" && !scripture1.IsCompletelyHidden())
        {
            Random random = new Random();
            int number = random.Next(1,4);
            scripture1.HideRandomWords(number);
            Console.WriteLine(scripture1.GetDisplayText());
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();
            if (response.ToLower() != "quit" && !scripture1.IsCompletelyHidden())
            {
                Console.Clear(); 
            }
            else
            {
                break;      
            }
            

        }
    }
}