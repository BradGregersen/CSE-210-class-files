using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberInput = -1;
        List<int> numbers = new List<int>();

        while (numberInput != 0)
        {
            Console.Write("Input a number. ");
            numberInput = int.Parse(Console.ReadLine());
            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }
        }

        if (numbers.Count > 0)
        {
            int totalSum = 0;
            foreach (int num in numbers)
            {
                totalSum += num;
            }

            double average = totalSum / (double)numbers.Count;
            int maxNumber = numbers.Max();

            Console.WriteLine("The sum of all entered numbers is " + totalSum);
            Console.WriteLine("The average of all entered numbers is " + average);
            Console.WriteLine("The largest number entered is " + maxNumber);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
