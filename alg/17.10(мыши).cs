using System;
class hello
{
    static void Main()
    {
        int sum = 0, h = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        int bel = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int[] mice = new int[n];
        for (int i = 0; i < n; i++) mice[i] = i;
        for (int i = 0; i < -1 + n; i++)
        {
            while (!((sum == k) && (mice[h] != -1)))
            {
                if (mice[h] != -1)
                    sum = sum + 1;
                h = (h + 1) % n;
            }
            mice[h] = -1; sum = -1;
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
            if (mice[i] != -1)
            {
                h = mice[i]; break;
            }
        if (bel - h < 0)
            Console.WriteLine(n + (bel - h));
        else
            Console.WriteLine(bel - h);
    }
}
