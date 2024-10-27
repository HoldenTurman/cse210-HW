public class Scripture
{
    public Reference reference;
    public List<WordInScripture> words;

    // Constructor
    public Scripture(Reference refScripture, string scriptureText)
    {
        reference = refScripture;
        words = new List<WordInScripture>();

        // Split the scripture text into individual words
        string[] splitWords = scriptureText.Split(' ');
        foreach (string word in splitWords)
        {
            words.Add(new WordInScripture(word));
        }
    }

    // Method to hide a random word
    public void HideRandomWord()
    {
        Random rand = new Random();
        int index = rand.Next(words.Count);
        words[index].Hide();
    }

    // Method to display the scripture with hidden words
    public void Display()
    {
        Console.Clear();  // Clear the console

        Console.WriteLine(reference.GetReferenceText() + ":");

        foreach (WordInScripture word in words)
        {
            Console.Write(word.GetWordDisplay() + " ");
        }

        Console.WriteLine();
    }
}
