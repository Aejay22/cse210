using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<string>menu = ["Start breathing activity", "Start reflecting activity", "Start Listing activity", "Quit"];
        
        string choice = "0";
        while(choice != "4")
        {
            if(choice =="1"||choice=="2"||choice=="3"||choice=="4"){Console.Clear();}
            Console.WriteLine("Menu Options:");
                foreach(string m in menu)
            {
                Console.WriteLine($"\t{menu.IndexOf(m) + 1}: {m}");
            }
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            Console.Clear();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if(choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if(choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if(choice == "4")
            {
                Console.WriteLine("Thank you for participating in this program");
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }
        }
    }
}