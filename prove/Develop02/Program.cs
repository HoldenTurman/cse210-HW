
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        bool isRunning = true;

        string fileName = "myFile.txt";

        while(isRunning)
        {


            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            Console.WriteLine("What would you like to do? ");
            string userInput = Console.ReadLine();

            // The conditionals to go through the menu options.
            switch (userInput)
            {
            case "1":
                journal.AddEntry();
                break;
            case "2":
                journal.DisplayEntries();
                break;
            case "3":
                journal.LoadEntries(fileName);
                break;
            case "4":
                journal.SaveEntries(fileName);
                break;
            case "5":
                isRunning = false;
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
            }

        }
    }
}



