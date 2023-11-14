using System;
class www
{
    static void Main()
    {
        Console.WriteLine("введите строку");
        string input = Console.ReadLine().Replace(" ", "").ToLower();
        int nech = 0;
        for (int i = 0; i < input.Length; i++) {
            if (char.IsDigit(input[i]) && Convert.ToInt32(input[i].ToString()) % 2 != 0) {
                nech++;
            }
        }
        Console.WriteLine("кол-во нечетных цифр в строке:" + nech);
        bool pal = true;
        for (int i = 0; i < input.Length / 2; i++) {
            if (input[i] != input[input.Length - 1 - i]) {
                pal = false;
                break;
            }
        }
        Console.WriteLine($"строка {(pal ? "является" : "не является")} палиндромом.");
    }
}
