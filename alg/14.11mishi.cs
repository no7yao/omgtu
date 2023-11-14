using System;
class wwww
{
    static void Main()
    {
        while (true)
        {
            int sum = -1, p = 0;
            bool flag = false;
            Console.WriteLine("Укажите кол-во серых мышей");
            int n_s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во белых мышей");
            int n_b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Через сколько съедается мышь");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите сколько должно остаться серых");
            int o_s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите сколько должно остаться белых");
            int o_b = Convert.ToInt32(Console.ReadLine());
            int m_s = n_s - o_s;
            int[] mish = new int[n_s + n_b];
            for (int i = 0; i < n_s + n_b; i++) mish[i] = i;
            for (int i = 0; i < (n_s + n_b) - (o_b + o_s); i++)
            {
                while (!((sum == k) && (mish[p] != -1)))
                {
                    if (mish[p] != -1) sum += 1;
                    if ((sum != k) || (mish[p] == -1)) p = (p + 1) % (n_b + n_s);
                }
                mish[p] = -1; sum =0;
            }
            
                Console.WriteLine();
            for (int i = 0; i < n_s + n_b; i++)
            {

                if ((n_s < o_s) || (n_b < o_b))
                {
                    flag = true; break;
                }

                if (mish[i] == -1)
                {
                    if (m_s != 0)
                    {
                        m_s += -1;
                        Console.WriteLine($"Расположим серую(м) мышь на {i + 1} месте");

                    }
                    else
                    {
                        if (i == 0)
                        {
                            flag = true;
                            break;
                        }
                        Console.WriteLine($"Расположим белую(м) мышь на {i + 1} месте");
                    }

                }
                else
                {
                    if (o_s != 0)
                    {
                        o_s += -1;
                        Console.WriteLine($"Расположим серую(ж) мышь на {i + 1} месте");

                    }
                    else
                    {
                        if (i == 0)
                        {
                            flag = true;
                            break;
                        }
                        Console.WriteLine($"Расположим белую(ж) мышь на {i + 1} месте");
                    }
                }
            }
            if (flag) Console.WriteLine("Расположить не возможно");
            Console.WriteLine();
        }
    }   
}
