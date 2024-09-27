using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        
        // Please note we could use a do-while loop here instead
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        // Part 2: Finding the average of numbers

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        // Part 3: Finding the Max number given
        int max = numbers[0];

        foreach(int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}