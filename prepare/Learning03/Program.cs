using System;

class Program
{
    static void Main(string[] args)
    {
       Fraction f1 = new Fraction();
       Console.WriteLine(f1.GcGetFractionString());
       Console.WriteLine(f1.GcGetDecimalValue());

       Fraction f2 = new Fraction(5);
       Console.WriteLine(f2.GcGetFractionString());
       Console.WriteLine(f2.GcGetDecimalValue());

       Fraction f3 = new Fraction(3, 4);
       Console.WriteLine(f3.GcGetFractionString());
       Console.WriteLine(f3.GcGetDecimalValue());

       Fraction f4 = new Fraction(1,3);
       Console.WriteLine(f4.GcGetFractionString());
       Console.WriteLine(f4.GcGetDecimalValue());
       

    
        
    }
}