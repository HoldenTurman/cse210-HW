class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    // Constructor to populate the prompts list once
    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GeneratePrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string selectPrompt = _prompts[index];
        return selectPrompt;
    }
}




