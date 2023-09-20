using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> gcNumbers = new List<int> ();
        bool gcFinish = false;
        int gcSum = 0 ;
        int gcBig = 0;
        int gcSmall = 999;
        float gcAverage = 0;

        
        while (!gcFinish)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string gcIn = Console.ReadLine();
            int gcInput = int.Parse(gcIn);
            

            if (gcInput == 0){
                gcFinish = true;
            }else{
                gcNumbers.Add(gcInput);

            }
        }
        foreach (int gcNumber in gcNumbers){
                gcSum += gcNumber ;
                if (gcNumber > gcBig){
                    gcBig = gcNumber ;
                }else if (gcSmall >gcNumber && gcNumber > 0 ){
                    gcSmall=gcNumber;
                }
            }
        int gcCount = gcNumbers.Count ;
        gcAverage = (float)gcSum/gcCount;

        Console.WriteLine($"The sum is {gcSum}");
        Console.WriteLine($"The average is {gcAverage}");
        Console.WriteLine($"The lagest number is {gcBig}");
        Console.WriteLine($"The smallest positive number is: {gcSmall}");
        Console.WriteLine($"The sorted list is: ");
        gcNumbers.Sort();
        foreach (int gcN in gcNumbers){
            
            Console.WriteLine($"{gcN}");
        }
        

    }
}