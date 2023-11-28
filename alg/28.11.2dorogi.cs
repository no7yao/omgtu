using System;
class wwww
{
    static void Main()
    {
        Console.WriteLine("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int minrast = 0;
        int sum = 0;
        for(int i = 1; i <= a; i++)
        {
            Console.WriteLine("c, d: ");
            int c = int.Parse(Console.ReadLine());
            sum += c;
            int d = int.Parse(Console.ReadLine());
            minrast = Math.Min(sum + b, minrast + d);
        }
        Console.WriteLine(minrast);
    }
}