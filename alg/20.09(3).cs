using System;

class class1

{
      static void Main()
    {
        int n, max_sub, cur_sub = 1, number, prv_number;
        n = Convert.ToInt32(Console.ReadLine());
        max_sub = 1;
        prv_number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            number = Convert.ToInt32(Console.ReadLine());
            if (number != prv_number)
            {
                cur_sub++;

            }
            else
            {
                if ((max_sub < cur_sub) & (cur_sub > 1))
                {
                    max_sub = cur_sub;

                }
                cur_sub = 1;
            }
            prv_number = number;
        }
        Console.WriteLine(max_sub);
    }
}

