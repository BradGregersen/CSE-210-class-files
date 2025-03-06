using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        while (true)
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower.");
            }
        }
    }
}