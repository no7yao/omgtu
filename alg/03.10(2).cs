using System;
class HelloWorld {
  static void Main() {
    int n, c, cnt1;
    cnt1 = 0;
    n = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<n; i++)
    {
    int a = Convert.ToInt32(Console.ReadLine());
    c = a;
    while (c>0){
        if (c%10 == 7) 
        {
            cnt1++;
            break;
        }
    
        c /=10;
    }
    }
    Console.WriteLine(cnt1);
  }
}
