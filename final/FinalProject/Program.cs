using System.ComponentModel;

class Program
{
    static void Main (string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Display saving");
            Console.WriteLine("2. Display expense");
            Console.WriteLine("3. Adding expense");
            Console.WriteLine("4. Enter saving");
            Console.WriteLine("5. Goal");
            Console.WriteLine("6. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                Console.WriteLine("number 1 ");
                break;
                case 2:
                Console.WriteLine("number 2 ");
                break;
                case 3:
                Console.WriteLine("number 3");
                break;
                case 4: 
                Console.WriteLine("number 4");
                break;
                case 5:
                Console.WriteLine("number 5");
                break;
                case 6:
                return;


            }
        }
    }
}