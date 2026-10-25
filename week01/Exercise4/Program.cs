using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int enteredNumber;
        int sum = 0;
        int largest;
        int SmallestPositiveNumber;
        int smallestPositiveNumber = -1;
        int x = 1;
        List<int>enteredNumbers = new List <int>();
        do
        {
        Console.Write("Enter number: ");
        string EnteredNumber = Console.ReadLine();
        enteredNumber = int.Parse(EnteredNumber);

        if (enteredNumber != 0)
            {
                enteredNumbers.Add(enteredNumber);
            }

        }while(enteredNumber != 0);
        largest = enteredNumbers[0];
        for(int i = 0; i < enteredNumbers.Count; i++)
        {
            sum += enteredNumbers[i];
            
            if (largest < enteredNumbers[i])
            {
                largest = enteredNumbers[i];
            }
            if (enteredNumbers[i] > 0)
            {
                SmallestPositiveNumber = enteredNumbers[i];
                if (x == 1)
                {
                    x++;
                    smallestPositiveNumber = SmallestPositiveNumber;
                }

                
                if (SmallestPositiveNumber < smallestPositiveNumber)
                {
                    smallestPositiveNumber = SmallestPositiveNumber;
                }
            }
            
        }
        enteredNumbers.Sort();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float)sum/enteredNumbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
        Console.WriteLine("The sorted list is: ");
        for (int i = 0; i < enteredNumbers.Count; i++)
        {
            Console.WriteLine(enteredNumbers[i]);
        }

    }
}