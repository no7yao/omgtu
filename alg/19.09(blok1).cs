using System;

class Class1
{
    static void Main()
    {
        int a, b, c = 0, d = 0, e = 0;
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) e = a;
        if ((a > 0) && (a % 3 == 0)) d = d + a;
        if (a < 0) c = c + 1;
        for (int i = 1; i < 10; i++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            if ((b > 0) && (e < 0)) e = b;
            if (a < b) a = b;
            if (b < 0) c = c + 1;
            if ((b > 0) && (b % 3 == 0)) d = d + b;
            if ((b < e) && (b > 0)) e = b;
        }
        Console.WriteLine(a);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);

    }

}
