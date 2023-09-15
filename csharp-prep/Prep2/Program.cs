using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grad persentage? ");
        string gcInput = Console.ReadLine();
        int gcGrad = int.Parse(gcInput);

        string gcLetter = "";
        
        if (gcGrad >= 90)
        {
            gcLetter = "A";
        }else if (gcGrad >= 80)
        {
            gcLetter = "B";
        }else if (gcGrad >= 70)
        {
            gcLetter = "C";
        }else if (gcGrad >= 60)
        {
            gcLetter = "D";
        }else 
        {
            gcLetter = "F";
        }
        Console.WriteLine($"Your grad is {gcLetter}");

        if (gcGrad >= 70)
        {
            Console.WriteLine("You pass!");
        }else
        {
            Console.WriteLine("I believed you will do better next time");
        }

    }
}