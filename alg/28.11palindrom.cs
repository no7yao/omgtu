using System;
class baridnikta
{
    static void Main()
    {
        Console.Write("введите строку: ");
        string inputString = Console.ReadLine().ToLower();
        int pal = 0;
        for (int n = 0; n < inputString.Length; n++)
        {
            for (int b = n + 1; b <= inputString.Length; b++)
            {
                string substring = inputString.Substring(n, b - n);
                if (pal1(substring) && substring.Length > pal)
                {
                    pal = substring.Length;
                }
            }
        }
        Console.WriteLine(pal);
    }
    static bool pal1(string str)
    {
        for (int n = 0; n < str.Length / 2; n++)
        {
            if (str[n] != str[str.Length - n - 1])
            {
                return false;
            }
        }
        return true;
    }
}