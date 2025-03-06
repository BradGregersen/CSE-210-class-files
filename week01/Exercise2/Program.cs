using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage did you get? ");
        if (int.TryParse(Console.ReadLine(), out int percent))
        {
            string letterGrade = "";

            if (percent >= 90) letterGrade = "A";
            else if (percent >= 80) letterGrade = "B";
            else if (percent >= 70) letterGrade = "C";
            else if (percent >= 60) letterGrade = "D";
            else letterGrade = "F";

            Console.WriteLine($"Your grade is {letterGrade}");

            if (percent >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Keep trying, you never lose unless you give up!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}