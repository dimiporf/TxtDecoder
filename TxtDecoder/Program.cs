using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    // Function to decode the message from the file
    static string Decode(string messageFile)
    {
        // Dictionary to store the mapping of numbers to words
        Dictionary<int, string> pyramid = new Dictionary<int, string>();

        // Read each line from the file
        foreach (var line in File.ReadLines(messageFile))
        {
            // Split the line into parts
            var parts = line.Split(' ');

            // Extract the number and the word
            int number = int.Parse(parts[0]);
            string word = string.Join(' ', parts.Skip(1));

            // Add the mapping to the dictionary
            pyramid[number] = word;
        }

        // List to store the decoded words
        List<string> decodedWords = new List<string>();
        int count = 1;

        // Construct the list of decoded words based on the pyramid pattern
        while (pyramid.ContainsKey(count))
        {
            decodedWords.Add(pyramid[count]);
            count = count + decodedWords.Count + 1;
        }

        // Join the decoded words into a string
        string decodedMessage = string.Join(' ', decodedWords);
        return decodedMessage;
    }

    // Main method
    static void Main()
    {
        // Replace with the actual file path
        string messageFile = "C:\\Users\\dimip\\Downloads\\coding_qual_input.txt";

        // Call the Decode function and print the result
        string decodedMessage = Decode(messageFile);
        Console.WriteLine(decodedMessage);
    }
}
