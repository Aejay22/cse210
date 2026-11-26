using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int i = 5;
        while(i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
}
    }
