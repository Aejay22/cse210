using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
public class BreathingActivity : Activity
{
    
    private bool breathIn;
    public BreathingActivity():base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing";   
    }
    public void ifBreathIn()
    {
        if (breathIn)
        {
            Console.Write("Breathe in...");
            breathIn = false;
        }
        else
        {
            Console.Write("Now Breathe out...");
            breathIn= true;
        }
    }
    public void Run()
    {
        DisplayStartingMessage();
        int time = 5;
        int ensure = 0;
        breathIn=true;
        while (_duration > 0)
        {
            
            if (ensure == 0)
            {
                if(_duration == 8 || _duration <= 5)
                {
                    time = _duration/2;
                }
                ensure = 1;

            }
            else
            {
                ensure = 0;
            }
            
            ifBreathIn();
            ShowCountDown(time);
            Console.Write("\n\n");

            _duration -= time;
        }
        DisplayEndingMessage();

    }
}