using System;
using System.Linq;

class www
{
    static void Main()
    {
        Console.Write("Введите кол-во множеств: ");
        int n = int.Parse(Console.ReadLine());
        int[][] nums = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элементы множества {i+1} через пробел: ");
            string[] s = Console.ReadLine().Split();
            int[] sn = s.Select(x => int.Parse(x)).ToArray();
            nums[i] = sn;
        }
        int[] peresech = new int[0];
        int[] obedin = new int[0];
        int[][] dopolnenie = new int[n * (n - 1) / 2][];
        int k = 0;
        foreach (int[] i in nums)
        { foreach (int j in i) { if (!obedin.Contains(j)) { Array.Resize(ref obedin, obedin.Length + 1); obedin[k++] = j; } } }

        foreach (int i in obedin) { Console.Write(i); }
        Console.WriteLine();

        int[] ints = new int[0];
        k = 0;
        foreach (int[] i in nums) { foreach (int j in i) { Array.Resize(ref ints, ints.Length + 1); ints[k++] = j; } }
        k = 0;
        foreach (int i in ints) { if ((ints.Count(x => x == i) == n) & (!peresech.Contains(i))) { Array.Resize(ref peresech, peresech.Length + 1); peresech[k++] = i; } }

        foreach (int i in peresech) { Console.Write(i); }
        Console.WriteLine();
        int dop = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int y = i + 1; y < nums.Length; y++)
            {
                int[] num = new int[0];

                int[] all = new int[nums[i].Length + nums[y].Length];
                k = 0;
                for (int j = 0; j < nums[i].Length; j++)
                {
                    all[k++] = nums[i][j];
                }
                for (int j = 0; j < nums[y].Length; j++)
                {
                    all[k++] = nums[y][j];
                }
                k = 0;
                foreach (int j in all) { if (all.Count(x => x == j) == 1) { Array.Resize(ref num, num.Length + 1); num[k++] = j; } }
                dopolnenie[dop++] = num;
            }
        }
        foreach (int[] i in dopolnenie)
        {
            foreach (int j in i)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
