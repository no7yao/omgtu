using System;
using System.Collections.Generic;
class Dog
{
    public int year { get; set; }
    public string poroda { get; set; }
    public string color { get; set; }
    public string pol { get; set; }
    public string name { get; set; }
}
class Program
{
    static void Main()
    {
        List<Dog> dogs = new List<Dog>();

        Console.Write("Введите количество собак: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Dog dog = new Dog();
            Console.Write("Год рождения: ");
            dog.year = int.Parse(Console.ReadLine());
            Console.Write("Порода: ");
            dog.poroda = Console.ReadLine();
            Console.Write("Окрас: ");
            dog.color = Console.ReadLine();
            Console.Write("Пол: ");
            dog.pol = Console.ReadLine();
            Console.Write("Кличка: ");
            dog.name = Console.ReadLine();
            dogs.Add(dog);
        }
        Console.Write("Введите породу для выборки: ");
        string vibrporoda = Console.ReadLine();
        Console.Write("Введите год рождения для выборки: ");
        int vibryear = int.Parse(Console.ReadLine());
        Console.Write("Введите новый окрас: ");
        string newcolor = Console.ReadLine();
        foreach (var dog in dogs)
        {
            if (dog.poroda == vibrporoda && dog.year == vibryear)
            {
                dog.color = newcolor;
            }
        }
        foreach (var dog in dogs)
        {
            if (dog.poroda == vibrporoda && dog.year == vibryear) Console.WriteLine($"{dog.name} сменил окрас на {dog.color}");
        }
    }
}