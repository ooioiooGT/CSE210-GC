using System.Security.Cryptography;

public class Income : Transcation
{
    public string Category {get; set;}
    public Income (string description, decimal amount, DateTime date) 
        : base(  description, amount,date)
    {
        Category = Category;
    }
     public static Income CreateIncome()
    {
        Console.WriteLine("Adding Income transaction");
        DateTime date = DateTime.Now;
        Console.WriteLine("Enter Description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        return new Income (description, amount, date);
    }
    public override void RecordTransaction()
    {
        Console.WriteLine($"Income recorded: {Description} {Amount} {Date}");
    }
     public static void DisplayIncome(List<Transcation> transcations)
    {
        Console.WriteLine("Income Transcation:");
        foreach (Transcation transcation in transcations)
        {
            if(transcation is Income)
            {
                transcation.RecordTransaction();
            }
        }
    }
    public override string GCToString()
    {
        return $"Income: {Description} {Amount} {Date}";
    }
}