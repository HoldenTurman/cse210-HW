using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);

        int input = -1;


        while(input != magicNumber)
        {
            Console.Write("What is your guess? ");
            input = int.Parse(Console.ReadLine());

            if(magicNumber > input)
            {
                Console.WriteLine("Higher");
            }
            else if(magicNumber < input)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}

