using System;
using System.Linq;
class wwww
{
    static void Main()
    {
        Console.WriteLine("Введите количество городов: ");
        int n = int.Parse(Console.ReadLine());
        int aa = 10;
        Console.WriteLine("Введите расстояние между городами через пробел: ");
        string[] c = Console.ReadLine().Split();
        int[] gorod = new int[c.Length];
        for (int i = 0; i < c.Length; i++) { gorod[i] = int.Parse(c[i]); }
        Console.WriteLine("Введите ограничение (k): ");
        int k = int.Parse(Console.ReadLine());
        if (gorod.Max() < k) { Console.WriteLine("нельзя разместить"); }
        int[] bools = new int[gorod.Sum() + 1];
        bools[0] = 1;
        for (int i = 1, y = 0, u = gorod[0]; i < gorod.Sum() - 1; i++)
        {
            if (i == u) { bools[i] = 1; u += gorod[++y]; } else { bools[i] = 0; }
        }
        bools[bools.Length - 1] = 1;
        int ir = 0; int prav_gorod = gorod[0];
        for (int i = 1, lev_gorod = 0; i < bools.Length; i++)
        {
            if ((bools[i] == 0) && (i - lev_gorod >= k) && (prav_gorod - i >= k))
            {
                int a = i;
                lev_gorod = prav_gorod;
                prav_gorod += gorod[ir + 1 == gorod.Length ? 0 : ++ir];
                int rast = 0;
                for (int j = 0; j < gorod.Length; j++)
                {
                    rast += gorod[j];
                    a += Math.Abs(rast - i);
                }
                aa = Math.Min(aa, a);
            }
        }
        Console.WriteLine(aa);
    }
}
