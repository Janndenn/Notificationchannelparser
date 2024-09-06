using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the notification title:");
        string input = Console.ReadLine();

        string[] validChannels = { "BE", "FE", "QA", "Urgent" };  
        List<string> foundChannels = new List<string>(); 

    
        string[] parts = input.Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

 
        foreach (string part in parts)
        {
            if (validChannels.Contains(part))
            {
                foundChannels.Add(part);
            }
        }

        if (foundChannels.Any())
        {
            Console.WriteLine("Receive channels: " + string.Join(", ", foundChannels));
        }
        else
        {
            Console.WriteLine("No valid channels found.");
        }
    }
}
