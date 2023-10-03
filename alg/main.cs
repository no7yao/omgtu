/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int n, tri, pat, sem, cnt;
    cnt = 0;
    n = Convert.ToInt32(Console.ReadLine());
    for (int i=0; i<n; i++)
    {
    int a = Convert.ToInt32(Console.ReadLine());
    tri = a%3;
    pat = a%5;
    sem = a%7;
    if (tri == pat & pat == sem & tri == sem) 
    {
        cnt++;
    }
    }
    Console.WriteLine(cnt);
  }
}