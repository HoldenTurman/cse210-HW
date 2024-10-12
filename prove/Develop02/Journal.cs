using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>(); // Field for storing entries

    public void AddEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        /*Create an Entry
          Fill in entry variables*/

          string date = DateTime.Now.ToString();
          string userPrompt = promptGenerator.GeneratePrompt();
          Console.WriteLine($"{userPrompt}");

          string userEntry = Console.ReadLine();

          Entry entry = new Entry(date, userEntry, userPrompt);

          entries.Add(entry);
    }



    public void DisplayEntries()
    {
        // Create a conditional that checks if there are any entries.
        // Create a For loop to go through and print each entry.

        if(entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
        }

        for (int i = 0; i < entries.Count; i++)
        {
            Console.WriteLine(entries[i].DisplayEntry());
        }
    }


    public void SaveEntries(string fileName)
    {
        //Writing Text files in developer assignment
        //Write all entries to the file
        //Loop through list at top
        //Seperate lines by (,)

        fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._userPrompt},{entry._userEntry}");
            }
        }

        Console.WriteLine($"Entries have been saved to {fileName}.");
    }

    public void LoadEntries(string fileName)
    {
        //Reading Text files in developer assignment
        //Re-add all entries back into entries list
        //loop through list using forEach

        if (File.Exists(fileName))
        {
            using (StreamReader inputFile = new StreamReader(fileName))
            {
                string line;

                // Loop through each line in the file
                while ((line = inputFile.ReadLine()) != null)
                {
                    // Split the line by commas, as it is written in the SaveEntries method
                    string[] entryData = line.Split(',');

                    // Ensure that the line contains the expected number of components
                    if (entryData.Length == 3)
                    {
                        string date = entryData[0];
                        string userPrompt = entryData[1];
                        string userEntry = entryData[2];

                        // Recreate the Entry object
                        Entry entry = new Entry(date, userEntry, userPrompt);

                        // Add the newly created entry to the entries list
                        entries.Add(entry);
                    }
                }
            }

            Console.WriteLine($"Entries have been successfully loaded from {fileName}.");
        }
        else
        {
            Console.WriteLine($"Error: The file {fileName} does not exist.");
        }

    }


    
}




