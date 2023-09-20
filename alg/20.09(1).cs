using System;

class class1
{
    static void Main()
    {
        int amount, numb, prv_number, diff, switch1 = 1;
        amount = Convert.ToInt32(Console.ReadLine());
        prv_number = Convert.ToInt32(Console.ReadLine());
        numb = Convert.ToInt32(Console.ReadLine());
        diff = prv_number - numb;
        if (diff > 0)
        {
            for (int i = 0; i < amount - 2; i++)
            {
                prv_number = numb;
                numb = Convert.ToInt32(Console.ReadLine());
                if ((prv_number - numb) != diff)
                {
                    switch1 = 0;
                }
            }
        }
        else
        {
            switch1 = 0;
        }
        if (switch1 == 1)
        {
            Console.WriteLine("Последовательность является равномено убывающей");
        }
        else
        {
            Console.WriteLine("Последовательность не является равномено убывающей");
        }
    }
}


