using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string GradePercentage = Console.ReadLine();
        int gradePercentage = int.Parse(GradePercentage);
        string grade = "";
        string sign = "";

        
        if (gradePercentage >= 90)
        {
            grade = "A";  
        }
        else if (gradePercentage >= 80)
        {
            grade = "B";
        }
        else if (gradePercentage >= 70)
        {
            grade = "C";
  
        }
        else if (gradePercentage >= 60)
        {
            grade = "D";
        }
        else
        {
           grade = "F";
        }

        if (gradePercentage >= 60 || gradePercentage <= 93)
        {   if (gradePercentage % 10 >= 7)
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }

        if (sign != null){
            Console.WriteLine($"\nYour Grade is {grade}{sign}");
        }
        else
        {
            Console.WriteLine($"\nYour Grade is {grade}");
        
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
        


    }
}