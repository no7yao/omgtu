using System;
using System.Collections.Generic;
public class Auditorium
{
    public int Floor { get; set; }
    public int Number { get; set; }
    public int Seats { get; set; }
    public bool Projector { get; set; }
    public bool Computers { get; set; }
}
public class Menu
{
    private List<Auditorium> auditoriums = new List<Auditorium>();
    public void CreateDatabase()
    {
        Console.WriteLine("Создание базы данных.");
        Console.WriteLine("Введите количество аудиторий для добавления:");
        int numAuditoriums = int.Parse(Console.ReadLine());

        for (int i = 0; i < numAuditoriums; i++)
        {
            Console.WriteLine($"\nВведите информацию об аудитории {i + 1}:");
            Console.WriteLine("Введите номер этажа:");
            int floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер аудитории:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество мест:");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Наличие проектора (true/false):");
            bool hasProjector = bool.Parse(Console.ReadLine());
            Console.WriteLine("Наличие компьютеров (true/false):");
            bool hasComputers = bool.Parse(Console.ReadLine());

            auditoriums.Add(new Auditorium
            {
                Floor = floor,
                Number = number,
                Seats = seats,
                Projector = hasProjector,
                Computers = hasComputers
            });

            Console.WriteLine("Аудитория добавлена в базу данных.");
        }
        Console.WriteLine("База данных создана.");
    }
    public void AddToDatabase()
    {
        Console.WriteLine("Введите номер этажа:");
        int floor = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите номер аудитории:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество мест:");
        int seats = int.Parse(Console.ReadLine());
        Console.WriteLine("Наличие проектора (true/false):");
        bool hasProjector = bool.Parse(Console.ReadLine());
        Console.WriteLine("Наличие компьютеров (true/false):");
        bool hasComputers = bool.Parse(Console.ReadLine());

        auditoriums.Add(new Auditorium
        {
            Floor = floor,
            Number = number,
            Seats = seats,
            Projector = hasProjector,
            Computers = hasComputers
        });
        Console.WriteLine("Новая аудитория добавлена в базу данных.");
    }
    public void UpdateAuditorium()
    {
        Console.WriteLine("Введите номер аудитории для изменения данных:");
        int auditoriumNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите новый номер этажа:");
        int newFloor = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите новое количество мест:");
        int newSeats = int.Parse(Console.ReadLine());
        Console.WriteLine("Наличие нового проектора (true/false):");
        bool newProjector = bool.Parse(Console.ReadLine());
        Console.WriteLine("Наличие новых компьютеров (true/false):");
        bool newComputers = bool.Parse(Console.ReadLine());

        Auditorium auditoriumToUpdate = auditoriums.Find(a => a.Number == auditoriumNumber);
        if (auditoriumToUpdate != null)
        {
            auditoriumToUpdate.Floor = newFloor;
            auditoriumToUpdate.Seats = newSeats;
            auditoriumToUpdate.Projector = newProjector;
            auditoriumToUpdate.Computers = newComputers;
            Console.WriteLine("Данные аудитории успешно изменены.");
        }
        else
        {
            Console.WriteLine("Аудитория с указанным номером не найдена.");
        }
    }
    public void FilterSeats(int minSeats)
    {
        List<Auditorium> filteredAuditoriums = auditoriums.FindAll(a => a.Seats >= minSeats);
        Console.WriteLine($"Аудитории с количеством посадочных мест >= {minSeats}:");
        foreach (var auditorium in filteredAuditoriums)
        {
            Console.WriteLine($"Этаж: {auditorium.Floor}, Номер: {auditorium.Number}, Мест: {auditorium.Seats}, Проектор: {auditorium.Projector}, Компьютеры: {auditorium.Computers}");
        }
    }
    public void FilterFloor(int floor)
    {
        List<Auditorium> filteredAuditoriums = auditoriums.FindAll(a => a.Floor == floor);
        Console.WriteLine($"Аудитории на {floor} этаже:");
        foreach (var auditorium in filteredAuditoriums)
        {
            Console.WriteLine($"Этаж: {auditorium.Floor}, Номер: {auditorium.Number}, Мест: {auditorium.Seats}, Проектор: {auditorium.Projector}, Компьютеры: {auditorium.Computers}");
        }
    }
    public void AllAuditoriums()
    {
        Console.WriteLine("Все аудитории в базе данных:");
        foreach (var auditorium in auditoriums)
        {
            Console.WriteLine($"Этаж: {auditorium.Floor}, Номер: {auditorium.Number}, Мест: {auditorium.Seats}, Проектор: {auditorium.Projector}, Компьютеры: {auditorium.Computers}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int choice;
        do
        {
            Console.WriteLine("1. Создание базы данных");
            Console.WriteLine("2. Добавление в базу");
            Console.WriteLine("3. Изменение данных аудитории по заданному номеру");
            Console.WriteLine("4. Выборка аудиторий с количеством посадочных мест >= заданному");
            Console.WriteLine("5. Выборка аудиторий по номеру этажа");
            Console.WriteLine("6. Вывод всех данных по аудиториям");
            Console.WriteLine("7. Выход");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    menu.CreateDatabase();
                    break;
                case 2:
                    menu.AddToDatabase();
                    break;
                case 3:
                    menu.UpdateAuditorium();
                    break;
                case 4:
                    Console.WriteLine("Введите минимальное количество мест:");
                    int minSeats = int.Parse(Console.ReadLine());
                    menu.FilterSeats(minSeats);
                    break;
                case 5:
                    Console.WriteLine("Введите номер этажа для фильтрации:");
                    int floor = int.Parse(Console.ReadLine());
                    menu.FilterFloor(floor);
                    break;
                case 6:
                    menu.AllAuditoriums();
                    break;
                case 7:
                    Console.WriteLine("Выход из программы.");
                    break;
                default:
                    Console.WriteLine("Некорректный выбор.");
                    break;
            }
        } while (choice != 7);
    }
}