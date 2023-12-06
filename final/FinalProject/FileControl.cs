public class FileControl
{
    public static void SaveFile(string fileName, List<Transcation> transcations)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var Transaction in transcations)
            {
                writer.WriteLine(transcations);
            }
        }
    }
}