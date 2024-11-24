namespace Sandbox2;

class Program
{
    static void Main(string[] args)
    {
        Vehicle myCar = new Car();
        Vehicle myMotorcycle = new Motorcycle();

        myCar.StartEngine();
        myMotorcycle.StartEngine();
    }
}
