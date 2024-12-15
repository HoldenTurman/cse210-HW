using System;

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Lecture instance
        Address lectureAddress = new Address("123 Main St", "Springfield", "IL", "62701");
        Lecture lecture = new Lecture("Tech Talk", "A talk on AI advancements", "01/20/2025", "10:00 AM", lectureAddress, "Dr. Smith", 50);

        Console.WriteLine("----- Lecture -----");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDescription());

        // Reception instance
        Address receptionAddress = new Address("456 Elm St", "Springfield", "IL", "62702");
        Reception reception = new Reception("Networking Night", "An evening to network with professionals", "01/22/2025", "6:00 PM", receptionAddress, "rsvp@company.com");

        Console.WriteLine("\n----- Reception -----");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDescription());

        // Outdoor Gathering instance
        Address outdoorAddress = new Address("789 Park Ave", "Springfield", "IL", "62703");
        OutdoorGathering outdoor = new OutdoorGathering("Community Picnic", "A fun day in the park", "01/25/2025", "12:00 PM", outdoorAddress, "Sunny");

        Console.WriteLine("\n----- Outdoor Gathering -----");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDescription());
    }
}
