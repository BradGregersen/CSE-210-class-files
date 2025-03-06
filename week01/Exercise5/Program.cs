using System;

class Program
{
        static String name = "";
        static int favoriteNumber = 0;
        static int square = 0;
    static void Main(string[] args)

    {
        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
        SquareNumber();
        DisplayResult();
    }
        static void DisplayWelcome()
        {
        Console.WriteLine("Welcome to the program. ");
        }
//  Displays the message, "Welcome to the Program!"
        static void PromptUserName()
        {
        Console.Write("Please enter your name: ");
        name=Console.ReadLine();
        }
        static void PromptUserNumber()
        {
        Console.Write("Please enter your favorite number? ");
        favoriteNumber =  int.Parse(Console.ReadLine());
        }
// Asks for and returns the user's favorite number (as an integer)
        static void SquareNumber()
        {
            square = favoriteNumber * favoriteNumber;
        }
// Accepts an integer as a parameter and returns that number squared (as an integer)
        static void DisplayResult()
        {
        Console.WriteLine($"{name}, the square of your number is {square}");
        }
}
// Accepts the user's name and the squared number and displays them.

