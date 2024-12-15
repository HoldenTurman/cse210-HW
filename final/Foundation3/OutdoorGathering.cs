// Derived class for Outdoor Gatherings
class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return base.GetStandardDetails() + "\nEvent Type: Outdoor Gathering\nWeather Forecast: " + weatherForecast;
    }

    public override string GetShortDescription()
    {
        return "Event Type: Outdoor Gathering\nTitle: " + base.GetShortDescription();
    }
}
