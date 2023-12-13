using System;
class HelloWorld {
  static void Main() {
    int N = int.Parse(Console.ReadLine());
    int ans = 1000;
        string[] c = Console.ReadLine().Split();
        int[] gorod = new int[c.Length];
        for (int i = 0; i < c.Length; i++) { gorod[i] = int.Parse(c[i]); }
        int k = int.Parse(Console.ReadLine());
        if (gorod.Max() < k) { Console.WriteLine("no way"); }
        int[] bools = new int[gorod.Sum() + 1];
        bools[0] = 1;
        for (int i = 1, y = 0, u = gorod[0]; i < gorod.Sum() - 1; i++)
        {
            if (i == u) { bools[i] = 1; u += gorod[++y]; } else { bools[i] = 0; }
        } 
        bools[bools.Length - 1] = 1;
        int ir = 0; int right_gorod = city[0];
        for (int i = 1, left_gorod = 0; i < bools.Length; i++)
            {
            if ((bools[i] == 0) && (i - left_gorod >= k) && (right_gorod - i >= k))
                {
                int a = i;
                left_gorod = right_gorod;
                right_gorod += gorod[ir + 1 == gorod.Length ? 0 : ++ir];
                int rast = 0;
                for (int j = 0; j < gorod.Length; j++)
                    {
                    rast += gorod[j];
                    a += Math.Abs(rast - i); 
                    }
                    ans = Math.Min(ans, a);
                }
            }
            Console.WriteLine(ans);