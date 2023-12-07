public class FileControl
{
    public static void SaveFile(string filename, List<Transcation> transcations)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var transaction in transcations)
            {
                writer.WriteLine(transaction.GCToString());
            }
        }
    }
    public static List<Transcation> LoadFile(string filename)
    {
        List<Transcation> transactions = new List<Transcation>();
        using(StreamReader GCreader = new StreamReader(filename))
        {
            string line;
            while ((line = GCreader.ReadLine()) != null)
            {Console.WriteLine(line);
            string [] parts = line.Split(" ");
            if (parts[0] == "Income:"){
                string description = parts[1];
                decimal amount = decimal.Parse(parts[2]);
                DateTime date = DateTime.Parse(parts[3]);
                Transcation transcation = new Income(description,amount,date);
                transactions.Add(transcation);
            }else{
                string description = parts[1];
                decimal amount = decimal.Parse(parts[2]);
                DateTime date = DateTime.Parse(parts[3]);
                Transcation transcation = new Expense(description,amount,date);
                transactions.Add(transcation);
            }
            }
            // Console.WriteLine(line);
            // string [] parts = line.Split(" ");
            // Console.WriteLine(parts[2]);
            // string description = parts[2];
            // decimal amount = decimal.Parse(parts[3]);
            // DateTime date = DateTime.Parse(parts[4]);

            // Transcation transaction = new Transcation (date, description, amount);
            // transactions.Add(transaction);

        }
        return transactions;
    }
    
}