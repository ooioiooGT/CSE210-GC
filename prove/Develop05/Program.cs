using System;

class Program
{
    static void Main(string[] args)
    {
        string userinput = "";
        while (userinput != "6")
        {
            Console.WriteLine($"Points: ");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goals");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a number from the menu:");

            userinput = Console.ReadLine();

            if (userinput == "1")
            {
                Console.WriteLine("Menu");
            }
            else if (userinput == "2")
            {
                Console.WriteLine("list Goal");
            }
            else if (userinput == "3")
            {
                Console.WriteLine("save");
            }
            else if (userinput =="4")
            {
                Console.WriteLine("load");
            }
            else if ( userinput == "5")
            {
                Console.WriteLine("record");
            }
        }
        
    }
}