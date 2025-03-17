using System;

public class Program
{
    public static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Console.WriteLine("Fraction 1: " + fraction1.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine("Fraction 2: " + fraction2.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine("Fraction 3: " + fraction3.GetFractionString());
        Console.WriteLine("Decimal Value: " + fraction3.GetDecimalValue());

        fraction3.SetTop(7);
        fraction3.SetBottom(8);
        Console.WriteLine("Updated Fraction 3: " + fraction3.GetFractionString());
        Console.WriteLine("Updated Decimal Value: " + fraction3.GetDecimalValue());
    }
}
