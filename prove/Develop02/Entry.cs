
public class Entry
{
    public string _date;  // Field for the date
    public string _userEntry;  // Field for the user's input

    public string _userPrompt; //User prompt

    // Constructor to initialize fields
    public Entry(string date, string userEntry, string userPrompt)
    {
        _date = date;
        _userEntry = userEntry;
        _userPrompt = userPrompt;
    }

    // Method to display the entry
    public string DisplayEntry()
    {
        return $"Date: {_date}\nPrompt: {_userPrompt}\nEntry: {_userEntry}\n";
    }
};
