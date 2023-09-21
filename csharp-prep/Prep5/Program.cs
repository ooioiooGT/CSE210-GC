using System;

class Program
{
    static void Main(string[] args)
    {
        gcDisplayWelcome();
        string gcNa = gcPromptUserName();
        int gcN = gcPromptUserNumber();
        int gcNu = gcSquareNumber(gcN);
        gcDisplayResult(gcNa, gcNu);
    }
    static void gcDisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static string gcPromptUserName(){
        Console.WriteLine("Please enter your name:");
        string gcName = Console.ReadLine();
        // Console.WriteLine($"{gcName}");
        return gcName;
    }
    static int gcPromptUserNumber(){
        Console.WriteLine("Please enter your favorite number:");
        string gcIn = Console.ReadLine();
        int gcNumber = int.Parse(gcIn);
        return gcNumber;
    }
    static int gcSquareNumber(int gcNumber){
        int gcSquare = gcNumber * gcNumber ;
        return gcSquare;
    }
    static void gcDisplayResult(string gcName ,int gcSquare){
        Console.WriteLine($"{gcName}, the square of your number is {gcSquare}");
    }
}