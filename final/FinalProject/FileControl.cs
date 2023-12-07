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
    public List<Transcation> LoadFile(string filename)
    {
        List<Transcation> transactions = new List<Transcation>();
        using(StreamReader GCreader = new StreamReader(filename))
        {
            string line ;
            line = GCreader.ReadLine();
            string [] parts = line.Split(" ");
            string description = parts[2];
            decimal amount = decimal.Parse(parts[3]);
            DateTime date = DateTime.Parse(parts[4]);
            Transcation transaction = new Transcation (date, description, amount);
            transactions.Add(transaction);

        }
        return transactions;
    }
    
}