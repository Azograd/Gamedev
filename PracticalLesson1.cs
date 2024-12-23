using System;

class Program
{
    static void Main()
    {
        int wordCount = 10;
        int wordLength = 6;
        string result = "";
        Random random = new Random();
        for (int i = 0; i < wordCount; i++)
        {
            string word = GenerateRandomWord(random, wordLength);
            result += word + " ";
        }
        result = result.Trim();
        Console.WriteLine("Сгенерированная строка:");
        Console.WriteLine(result);
        string[] words = result.Split(' ');
        if (words.Length > 1)
        {
            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;
        }
        string swappedResult = string.Join(" ", words);
        Console.WriteLine("Строка после замены:");
        Console.WriteLine(swappedResult);
    }

    static string GenerateRandomWord(Random random, int length)
    {
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        char[] word = new char[length];
        for (int j = 0; j < length; j++)
        {
            word[j] = chars[random.Next(chars.Length)];
        }
        return new string(word);
    }
}
