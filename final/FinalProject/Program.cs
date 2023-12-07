using System.ComponentModel;
using System.Xml.Serialization;

class Program
{
    static void Main (string[] args)
    {
       List<Transcation> transcations = new List<Transcation>();
        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Display Data");
            Console.WriteLine("2. Adding Transaction");
            Console.WriteLine("3. Deleting Transaction");
            Console.WriteLine("4. Goal");
            Console.WriteLine("5. Save file");
            Console.WriteLine("6. Load file");
            Console.WriteLine("7. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                DisplayTransa(transcations);
                break;
                case 2:
                CreateTransac(transcations);
                break;
                case 3:
                Console.WriteLine("number 3");
                break;
                case 4: 
                Console.WriteLine("number 4");
                break;
                case 5: 
                string filename = "transactions";
                FileControl.SaveFile(filename, transcations);
                Console.WriteLine("You are successfully save! ");
                break;
                case 6: 
                transcations = FileControl.LoadFile("transactions");
                Console.WriteLine("number 4");
                break;
                case 7:
                Console.WriteLine("number 5");
                return;
                default:
                Console.WriteLine("invaild choice");
                break;


            }
        }
    }
    static void DisplayTransa(List<Transcation> transcations)
    {
        Console.WriteLine("Chose category:");
        Console.WriteLine("1. Income Transactions");
        Console.WriteLine("2. Expense Transactions");
        Console.WriteLine("3. Both Transactions");
        Console.WriteLine("Wnter you choice:");
        int choice = int.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1:
            Income.DisplayIncome(transcations);
            break;
            case 2:
            Expense.DisplayExpense(transcations);
            break;
            case 3: 
            Transcation.DisplayTransaction(transcations);
            break;
        }
    }
    static void CreateTransac(List<Transcation> transcations)
    {
        Console.WriteLine("Chose one:");
        Console.WriteLine("1. Income");
        Console.WriteLine("2. Expense");
        Console.WriteLine("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
            transcations.Add(Income.CreateIncome());
            break;
            case 2: 
            transcations.Add(Expense.CreateExpense());
            
            break;
            default:
            Console.WriteLine("Invaild choice");
            break;
        }
    }
}