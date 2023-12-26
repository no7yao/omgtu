using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите количество собак: ");
        int n = int.Parse(Console.ReadLine());
        Dog[] dogs = new Dog[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите информацию о собаке {i + 1}:");
            Console.Write("Год рождения: ");
            int Year = int.Parse(Console.ReadLine());
            Console.Write("Порода: ");
            string breed = Console.ReadLine();
            Console.Write("Окрас: ");
            string color = Console.ReadLine();
            Console.Write("Пол: ");
            string gender = Console.ReadLine();
            Console.Write("Кличка: ");
            string name = Console.ReadLine();
            dogs[i] = new Dog(Year, breed, color, gender, name);
        }
        Console.WriteLine("Введите породу для выборки: ");
        string viborbreed = Console.ReadLine();
        Console.WriteLine("Введите год рождения для выборки: ");
        int viborYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите новый окрас: ");
        string newcolor = Console.ReadLine();
        Updatecolor(dogs, viborbreed, viborYear, newcolor);
        Console.WriteLine("Обновленные данные:");
        foreach (Dog dog in dogs)
        {
            Console.WriteLine(dog);
        }
    }
    private static void Updatecolor(Dog[] dogs, string breed, int year, string newcolor)
    {
        foreach (Dog dog in dogs)
        {
            if (dog.vibor(breed, year))
            {
                dog.SetColor(newcolor);
            }
        }
    }
}
class Dog
{
    private int Year;
    private string breed;
    private string color;
    private string gender;
    private string name;
    public Dog(int Year, string breed, string color, string gender, string name)
    {
        this.Year = Year;
        this.breed = breed;
        this.color = color;
        this.gender = gender;
        this.name = name;
    }
    public bool vibor(string breed1, int year1)
    {
        return breed == breed1 && Year == year1;
    }
    public void SetColor(string newcolor)
    {
        color = newcolor;
    }
    public override string ToString()
    {
        return $"{name} породы {breed} {Year} года рождения сменил окрас на {color}";
    }
}
