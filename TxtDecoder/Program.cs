using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static string Decode(string messageFile)
    {
        Dictionary<int, string> pyramid = new Dictionary<int, string>();

        foreach (var line in File.ReadLines(messageFile))
        {
            var parts = line.Split(' ');
            int number = int.Parse(parts[0]);
            string word = string.Join(' ', parts.Skip(1));
            pyramid[number] = word;
        }

        List<string> decodedWords = new List<string>();
        int count = 1;

        while (pyramid.ContainsKey(count))
        {
            decodedWords.Add(pyramid[count]);
            count = count + decodedWords.Count + 1;
        }

        string decodedMessage = string.Join(' ', decodedWords);
        return decodedMessage;
    }

    static void Main()
    {
        string messageFile = "C:\\Users\\dimip\\Downloads\\coding_qual_input.txt"; // Replace with the actual file path
        string decodedMessage = Decode(messageFile);
        Console.WriteLine(decodedMessage);
    }
}
