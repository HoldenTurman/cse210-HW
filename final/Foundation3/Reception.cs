// Derived class for Receptions
class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + "\nEvent Type: Reception\nRSVP Email: " + rsvpEmail;
    }

    public override string GetShortDescription()
    {
        return "Event Type: Reception\nTitle: " + base.GetShortDescription();
    }
}
