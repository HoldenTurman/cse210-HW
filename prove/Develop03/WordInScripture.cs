
using System.Dynamic;

public class WordInScripture
{
    // Field for the word text and whether it's hidden

    // Constructor to initialize the word text
    public string _text;
    public bool _isHidden;

    public WordInScripture(string wordText)
    {
        _text = wordText;
        _isHidden = false;
    }
    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }
    // Method to return the display form of the word
    public string GetWordDisplay()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 0df8a2f3a9e5c9c8df62b8a0e0b7ba808e34e89a
