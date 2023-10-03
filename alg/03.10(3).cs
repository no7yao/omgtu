using System;
class HelloWorld {
  static void Main() {
    int n;
    bool kratno = true;
    n = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<n; i++)
    {
    int a = Convert.ToInt32(Console.ReadLine());
    var sum = 0;
        while(a > 0)
        {
            sum += a % 10;
            a /= 10;
        
        }
        if (sum%7 != 0)
        {
            kratno = false;
        }
    }
    Console.WriteLine(kratno);
  }
}