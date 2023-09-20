using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine ("What is your magic number?");
        // string gcInput = Console.ReadLine();
        // int gcMagicNumber = int.Parse(gcInput);
        Random gcRandom = new Random();
        
        int gcGus = 0 ;
        int gcCount = 0;
        bool gcAgain = true;

        while (gcAgain)
        {
            int gcRNumber = gcRandom.Next(1,101);
            gcGus = 0;
            gcCount = 0;
            while( gcRNumber != gcGus)
            {
                Console.WriteLine("What do you guess?");
                string gcIn = Console.ReadLine();
                gcGus = int.Parse(gcIn);
                gcCount ++ ;
                if (gcGus > gcRNumber){
                    Console.WriteLine("please guess again, lower!");
                }else if (gcGus < gcRNumber){
                    Console.WriteLine("Please guess again, higher!");
                }else{
                    Console.WriteLine("You got it");
                }
            }
            Console.WriteLine($"you guess {gcCount} times");

            Console.WriteLine("Do you want to play again? (yes/no)");
            string gcAgainInput = Console.ReadLine().ToLower();
            if (gcAgainInput != "yes"){
                gcAgain = false;
            }
        }

    }
}