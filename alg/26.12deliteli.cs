using System;
class aaa
{
    static void Main()
    {
        for (double n = Math.Round(Math.Sqrt(106732567)); n <= Math.Ceiling(Math.Sqrt(152673836)); n++)
        {
            double maxdel = 0;
            int cnt = 0;
            for(int i = 2; i < n; i++)
            {
                if (Math.Pow(n, 2) % i == 0)
                {
                    maxdel = Math.Pow(n, 2) / i;
                    cnt++;
                }
                if (cnt > 1) continue;
            }
            if (cnt == 1)
            {
                Console.WriteLine($"Наибольший делитель числа {Math.Pow(n, 2)}: {maxdel}");
            }
        }
    }
}