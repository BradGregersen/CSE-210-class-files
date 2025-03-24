using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(new Reference("3 Nephi" ,10,14,15),"And now, whoso readeth, let him understand he that hath the scriptures, let him search them, and see and behold if all these deaths and destructions by fire, and by smoke, and by tempests, and by whirlwinds, and by the opening of the earth to receive them, and all these things are not unto the fulfilling of the prophecies of many of the holy prophets.; Behold, I say unto you, Yea, many have testified of these things at the coming of Christ, and were slain because they testified of these things.");
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nEnter will hide words and typing quit will exit");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(1);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture);
                break;
            }
        }







    }
}