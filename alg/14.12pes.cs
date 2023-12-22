using System;
using System.Collections.Generic;
class dog
{
    private int year;
    private string poroda;
    private string color;
    private string pol;
    private string name;
    public int Year { get => year; set => year = value; }
    public string Poroda { get => poroda; set => poroda = value; }
    public string Color { get => color; set => color = value; }
    public string Pol { get => pol; set => pol = value; }
    public string Name { get => name; set => name = value; }
}
class program
{
    static void Main()
    {
        List<dog> dogs = vvod();
        smenacolor(dogs);
        vivod(dogs);
    }
    public static List<dog> vvod()
    {
        List<dog> dogs = new List<dog>();
        Console.Write("Введите количество собак: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            dog dog = new dog();
            Console.Write("Год рождения собаки: ");
            dog.Year = int.Parse(Console.ReadLine());
            Console.Write("Порода собаки: ");
            dog.Poroda = Console.ReadLine();
            Console.Write("Окраска собаки: ");
            dog.Color = Console.ReadLine();
            Console.Write("Пол собаки: ");
            dog.Pol = Console.ReadLine();
            Console.Write("Имя собаки: ");
            dog.Name = Console.ReadLine();
            dogs.Add(dog);
        }
        return dogs;
    }
    public static void smenacolor(List<dog> dogs)
    {
        Console.Write("Введите породу для выборки: ");
        string poroda1 = Console.ReadLine();
        Console.Write("Введите год рождения для выборки: ");
        int year1 = int.Parse(Console.ReadLine());
        Console.Write("Введите новый окрас собак: ");
        string newcolor = Console.ReadLine();
        foreach (var dog in dogs)
        {
            if (dog.Poroda == poroda1 && dog.Year == year1)
            {
                dog.Color = newcolor;
            }
        }
    }
    public static void vivod(List<dog> dogs)
    {
        foreach (var dog in dogs)
        {
            Console.WriteLine($"{dog.Name} породы {dog.Poroda} {dog.Year} года рождения сменил цвет на {dog.Color}");
        }
    }
}
