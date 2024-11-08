namespace Sandbox2;

class Program
{
    static void Main(string[] args)
    {
        // Computer throws 3 dice.
        Random randomGenerator = new();
        int d1 = randomGenerator.Next(1,7);
        int d2 = randomGenerator.Next(1,7);
        int d3 = randomGenerator.Next(1,7);
        Console.WriteLine();
    }
}
