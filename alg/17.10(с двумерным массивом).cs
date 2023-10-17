using System;
class vesna
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int[,] masif = new int[n, k];
        for (int i = 0; i < n; i++)
        {
            string[] e = Console.ReadLine().Split(' ');
            for (int j = 0; j < k; j++)
            {
                masif[i, j] = Convert.ToInt32(e[j]);
            }
        }
        int cnt1 = 0; // 1 пункт
        for (int i = 0; i < n; i++)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int j = 0; j < k; j++)
            {
                int e = masif[i, j];
                if (e < min)
                {
                    min = e;
                }
                if (e > max)
                {
                    max = e;
                }
            }
            if (min % 2 == 0 && max % 2 == 0)
            {
                cnt1++;
            }
        }
        Console.WriteLine(cnt1);
        
        for (int j = 0; j < k; j++) //2 пункт
        {
            bool polozhit = true;
            for (int i = 0; i < n; i++)
            {
                if (masif[i, j] <= 0)
                {
                    polozhit = false;
                    break;
                }
            }
            if (polozhit)
            {
                Console.Write(j + 1);
            }
        }
        
        int cntnol = 0; // 3 пункт
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < k; j++)
            {
                if (masif[i, j] == 0)
                {
                    cntnol++;
                }
            }
        }
        Console.WriteLine(cntnol);
        
        bool nolstrk = false; //4 пункт
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = 0; j < k; j++)
            {
                sum += masif[i, j];
            }
            if (sum == 0)
            {
                nolstrk = true;
                break;
            }
        }
        if (nolstrk == true)
        {
            Console.WriteLine("есть нулевая строка");
        }
        else
        {
            Console.WriteLine("нет нулевой строки");
        }

        int cnt2 = 0; //5 пункт
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                bool sovp = true;
                int[] stroka1 = new int[k];
                int[] stroka2 = new int[k];
                for (int l = 0; l < k; l++)
                {
                    stroka1[l] = masif[i, l];
                    stroka2[l] = masif[j, l];
                }
                Array.Sort(stroka1);
                Array.Sort(stroka2);
                for (int l = 0; l < k; l++)
                {
                    if (stroka1[l] != stroka2[l])
                    {
                        sovp = false;
                        break;
                    }
                }
                if (sovp)
                {
                    cnt2++;
                }
            }
        }
        Console.WriteLine(cnt2);
    }
}