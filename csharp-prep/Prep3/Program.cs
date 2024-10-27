using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // This sets a variable to pick a random number from 1, 101 and put it in a new list

       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);

        int input = -1;

        // This while loop keeps running until user guesses random number correctly
        while(input != magicNumber)
        {
            Console.Write("What is your guess? ");
            input = int.Parse(Console.ReadLine());

            // conditionals that compares users guess to random number.
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

