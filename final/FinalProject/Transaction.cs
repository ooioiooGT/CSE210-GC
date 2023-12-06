using System.ComponentModel;
using System.Net.Http.Headers;
using System.Xml.Serialization;

public class Transcation 
{
    public decimal Amount {get; set;}
    public DateTime Date {get; set;}
    public string Description {get; set;}
    // public abstract string ToString();

    

    public Transcation(DateTime date, string description, decimal amount)
    {
        Date = date;
        Description = description;
        Amount = amount;

    }   
    public virtual void RecordTransaction()
    {
        Console.WriteLine($"Transaction recorded: {Description}");
    }
    public static void  DisplayTransaction(List<Transcation> transcations)
    {
        Console.WriteLine("Transcation:");
        foreach (Transcation transcation in transcations)
        {
            transcation.RecordTransaction();
        }
    }
}
   
    