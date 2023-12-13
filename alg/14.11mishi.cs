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
            int n_ser = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите кол-во белых мышей");
            int n_bel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Через сколько съедается мышь");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите сколько должно остаться серых");
            int o_ser = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите сколько должно остаться белых");
            int o_bel = Convert.ToInt32(Console.ReadLine());
            int m_s = n_ser - o_ser;
            int[] mish = new int[n_ser + n_bel];
            for (int i = 0; i < n_ser + n_bel- (o_bel + o_ser); i++)
            {
                while (!((sum == k) && (mish[p] != -1)))
                {
                    if (mish[p] != -1) sum += 1;
                    if ((sum != k) || (mish[p] == -1)) p = (p + 1) % (n_b + n_s);
                }
                mish[p] = -1; sum =0;
            }
            
                Console.WriteLine();
            for (int i = 0; i < n_ser + n_bel; i++)
            {

                if ((n_ser < o_ser) || (n_bel < o_bel))
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
                    if (o_ser != 0)
                    {
                        o_ser += -1;
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
