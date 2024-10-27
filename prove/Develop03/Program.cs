using System;
/*
This is were we will call/ display everything using Conditionals.
*/
class Program
{
    static void Main(string[] args)
    {
        // Create a reference and scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only begotten Son");

        while (true)
        {
            scripture.Display();

            // Prompt the user
            Console.WriteLine("Press Enter to hide a word, or type 'quit' to end:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;  // End the program
            }

            scripture.HideRandomWord();
        }
    }
}
