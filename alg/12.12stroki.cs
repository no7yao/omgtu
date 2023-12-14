using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("строки через пробел:");
        string input = Console.ReadLine();
        string[] inputStrings = input.Split(' ');
        Console.WriteLine("строка-образец:");
        string pattern = Console.ReadLine();
        int count = 0;
        foreach (string str in inputStrings)
        {
            count += (str.Length - str.Replace(pattern, "").Length) / pattern.Length;
        }

        Console.WriteLine(count);
    }
}