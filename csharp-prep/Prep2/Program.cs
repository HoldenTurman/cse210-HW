using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letterGrade;

        if(gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if(gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if(gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if(gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

    }
}