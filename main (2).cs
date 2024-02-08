using System;
using System.Collections.Generic;
public class Auditorium
{
    public int Floor { get; set; }
    public int Number { get; set; }
    public int Seats { get; set; }
    public bool HasProjector { get; set; }
    public bool HasComputers { get; set; }
}
public class Program
{
    private List<Auditorium> auditoriums = new List<Auditorium>();
    public void CreateDatabase()
    {
        Console.WriteLine("Введите количество аудиторий:");
        int count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите данные для аудитории {i + 1}:");
            Console.WriteLine("Номер этажа:");
            int floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Номер аудитории:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество мест:");
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
            HasProjector = hasProjector,
            HasComputers = hasComputers
            });
        }
        Console.WriteLine("База данных аудиторий создана.");
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
            HasProjector = hasProjector,
            HasComputers = hasComputers
        });
        Console.WriteLine("Новая аудитория добавлена.");
    }
    public void UpdAudData(string auditoriumNumber)
    {
    Auditorium auditoriumupd = menu.auditoriums.Find(a => a.Number == auditoriumNumber);
        if (auditoriumupd != null)
        {
            Console.WriteLine("Введите новую информацию об аудитории:");
            Console.Write("Новый номер аудитории: ");
            string newNumber = Console.ReadLine();
            Console.Write("Новый этаж: ");
            int newFloor = int.Parse(Console.ReadLine());
            Console.Write("Новое количество мест: ");
            int newSeatsCount = int.Parse(Console.ReadLine());
            Console.Write("Наличие компьютеров (true/false): ");
            bool newHasComputers = bool.Parse(Console.ReadLine());
            Console.Write("Наличие проектора (true/false): ");
            bool newHasProjector = bool.Parse(Console.ReadLine());

            auditoriumupd.Number = newNumber;
            auditoriumupd.floor = newFloor;
            auditoriumupd.Seats = newSeats;
            auditoriumupd.Comp = newHasComputers;
            auditoriumupd.Prj = newHasProjector;

            Console.WriteLine("Информация об аудитории успешно обновлена.");
        }
        else
        {
            Console.WriteLine("Аудитория с указанным номером не найдена.");
        }
    public List<Auditorium> GetAuditoriumsBySeats(int minSeats)
    {
        List<Auditorium> result = new List<Auditorium>();
        foreach (var auditorium in auditoriums)
        {
            if (auditorium.Seats >= minSeats)
            {
                result.Add(auditorium);
            }
        }
        return result;
    }
    public List<Auditorium> GetAuditoriumsByFloor(int floor)
    {
        List<Auditorium> result = new List<Auditorium>();
        foreach (var auditorium in auditoriums)
        {
            if (auditorium.Floor == floor)
            {
                result.Add(auditorium);
            }
        }
        return result;
    }
    public void PrintAllAuditoriums()
    {
        foreach (var auditorium in auditoriums)
        {
            Console.WriteLine($"Этаж: {auditorium.Floor}, Номер: {auditorium.Number}, Мест: {auditorium.Seats}, Проектор: {auditorium.HasProjector}, Компьютеры: {auditorium.HasComputers}");
        }
    }
}
class Menu
{
    static void Main(string[] args)
    {
        Program program = new Program();
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
                    program.CreateDatabase();
                    break;
                case 2:
                    program.AddToDatabase();
                    break;
                case 3:
                    Console.WriteLine("Введите номер аудитории для изменения данных:");
                    int auditoriumNumber = int.Parse(Console.ReadLine());
                    Auditorium auditoriumToUpdate = menu.auditoriums.Find(a => a.Number == auditoriumNumber);
                    if (auditoriumToUpdate != null)
                    {
                        program.UpdateAuditorium(auditoriumToUpdate, 100, true, false);
                    }
                    else
                    {
                        Console.WriteLine("Аудитория с указанным номером не найдена.");
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите минимальное количество мест:");
                    int minSeats = int.Parse(Console.ReadLine());
                    var auditoriumsBySeats = program.GetAuditoriumsBySeats(minSeats);
                    Console.WriteLine("Аудитории с количеством посадочных мест >= " + minSeats + ":");
                    foreach (var auditorium in auditoriumsBySeats)
                    {
                        Console.WriteLine($"Этаж: {auditorium.Floor}, Номер: {auditorium.Number}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите номер этажа:");
                    int floorNumber = int.Parse(Console.ReadLine());
                    var auditoriumsByFloor = program.GetAuditoriumsByFloor(floorNumber);
                    Console.WriteLine($"Аудитории на этаже {floorNumber}:");
                    foreach (var auditorium in auditoriumsByFloor)
                    {
                        Console.WriteLine($"Номер: {auditorium.Number}, Количество мест: {auditorium.Seats}, Проектор: {auditorium.HasProjector}, Компьютеры: {auditorium.HasComputers}");
                    }
                    break;
                case 6:
                    program.PrintAllAuditoriums();
                    break;
                case 7:
                    Console.WriteLine("Выход из программы.");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }
        } while (choice != 7);
    }
}
