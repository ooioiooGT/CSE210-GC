using System.Security.Cryptography;

public class Expense : Transcation
{
    public string Category {get; set;}
    public Expense ( string description, decimal amount,DateTime date) 
        : base( description, amount,date)
    {
        Category = Category;
    }
    public static Expense CreateExpense()
    {
        Console.WriteLine("Adding Expense transction");
        DateTime date = DateTime.Now;
        Console.WriteLine("Enter Description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter Amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        
        return new Expense(description,amount,date);
            
    }
    public override void RecordTransaction()
    {
        Console.WriteLine($"Expense recorded: {Description} {Amount} {Date}");
    }
     public static void DisplayExpense(List<Transcation> transcations)
    {
        Console.WriteLine("Expense Transaction:");
        foreach (Transcation transcation in transcations)
        {
            if(transcation is Expense)
            {
                transcation.RecordTransaction();
            }
        }
    }
    public override string GCToString()
    {
        return $"Expense: {Description} {Amount} {Date}";
    }
}