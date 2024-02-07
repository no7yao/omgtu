using System;
class Program
{
    static void Main()
    {
        Menu menu = new Menu();
        menu.DispMenu();
    }
}
class Menu
{
  public void DispMenu()
  {
    bool exit  = false;
    AudDatabase database = new AudDatabase();
    while (!exit)
    {
        Console.WriteLine("Меню:");
        Console.WriteLine("1. Создание базы данных");
        Console.WriteLine("2. Добавление в базу");
        Console.WriteLine("3. Изменение данных аудитории по номеру");
        Console.WriteLine("4. Выборка аудитории с кол-вом посадочных мест >= заданному");
        Console.WriteLine("5. Выборка аудиторий с проектором");
        Console.WriteLine("6. Выборка аудиторий с компьютерами");
        Console.WriteLine("7. Выборка аудиторий по номеру этажа");
        Console.WriteLine("8. Вывод всех данных по аудиториям");
        Console.WriteLine("9. Выход");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                database.CreateDatabase();
                break;
            case "2":
                database.AddDatabase();
                break;
            case "3":
                database.UpdAudData();
                break;
            case "4":
                database.FilterMesto();
                break;
            case "5":
                database.FilterProektor();
                break;
            case "6":
                database.FilterComp();
                break;
            case "7":
                database.FilterEtazh();
                break;
            case "8":
                database.AllData();
                break;
            case "9":
                exit = true;
                break;
            default:
                Console.WriteLine("Некорректный ввод данных");
                break;
        }
    }
  }
}
class AudDatabase
{
    public List<Aud> auditoriums = new List<Aud>();
    public void CreateDatabase()
    {
        Console.WriteLine("Введите количество аудиторий: ");
        int n = Convert.ToInt32(Console.ReadLine())
        for (int i=0; i<n; i++)
        {
            Console.WriteLine($"Введите информацию об аудитории {i+1}:");
            Console.WriteLine("Номер аудитории: ");
            string nom  = Console.ReadLine();
            Console.WriteLine("Номер этажа: ");
            int etzh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество мест: ");
            mest = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Наличие компьютеров (t/f): ");
            bool cmp = bool.Parse(Console.ReadLine());
            Console.WriteLine("Наличие проектора (t/f): ");
            bool prj = bool.Parse(Console.ReadLine());
            Aud newAud = new Aud
            {
                Nom = nom,
                Etzh = etzh,
                Mest = mest,
                Cmp = cmp,
                Prj = Prj
            };
            auditoriums.Add(newAud);
            Console.WriteLine("Аудитория добавлена")
        }
    }
    public void AddDatabase()
    {
        Console.WriteLine($"Введите информацию об аудитории:");
        Console.WriteLine("Номер аудитории: ");
        string nom  = Console.ReadLine();
        Console.WriteLine("Номер этажа: ");
        int etzh = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Количество мест: ");
        mest = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Наличие компьютеров (t/f): ");
        bool cmp = bool.Parse(Console.ReadLine());
        Console.WriteLine("Наличие проектора (t/f): ");
        bool prj = bool.Parse(Console.ReadLine());
        Aud newAud = new Aud
        {
            Nom = nom,
            Etzh = etzh,
            Mest = mest,
            Cmp = cmp,
            Prj = Prj
        };
            auditoriums.Add(newAud);
            Console.WriteLine("Аудитория добавлена")
    }
    public void UpdAudData(string auditoriumNumber)
    {
        Aud auditoriumupd = auditoriums.Find(a => a.Nom == auditoriumNom);
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

            auditoriumupd.Nom = newnom;
            auditoriumupd.Etzh = newetzh;
            auditoriumupd.Mest = newmest;
            auditoriumupd.Comp = newcomp;
            auditoriumupd.Prj = newprj;

            Console.WriteLine("Информация об аудитории успешно обновлена.");
        }
        else
        {
            Console.WriteLine("Аудитория с указанным номером не найдена.");
        }
    }
    public void FilterMesto(int nuzhmest)
    {
        List<Aud> filterAud = auditoriums.FindAll(a=> a.Mest >= nuzhmest);
        if (filterAud.Count > 0)
        {
            Console.WriteLine("Список найденых аудиторий: ")
            foreach (var aud in filterAud)
            {
                Console.WriteLine($"Номер: {aud.Nom}, количество мест: {aud.Mest}");
            }
        }
        else
        {
            Console.WriteLine("Аудитории с ноужным количеством мест не найдены")
        }
    }
    public void FilterProektor()
    {
        List<Aud> auditoriumsPrj = auditoriums.FindAll(a => a.Prj);
        if (auditoriumsPrj.Count > 0)
        {
            Console.WriteLine("Аудитории с проектором:");
            foreach (var aud in auditoriumsPrj)
            {
                Console.WriteLine($"Номер: {aud.Nom}");
            }
        }
        else
        {
            Console.WriteLine("Аудитории с проектором не найдены.");
        }
    }
    public void FilterComp()
    {
        List<Aud> auditoriumsComp = auditoriums.FindAll(a => a.Cmp);
        if (auditoriumsComp.Count > 0)
        {
            Console.WriteLine("Аудитории с компьютерами:");
            foreach (var aud in auditoriumsComp)
            {
                Console.WriteLine($"Номер: {aud.Nom}");
            }
        }
        else
        {
            Console.WriteLine("Аудитории с компьютерами не найдены.");
        }
    }
    public void FilterEtazh(int etazh)
    {
        List<Auditorium> auditoriumsOnFloor = auditoriums.FindAll(a => a.Floor == floorNumber);
        if (auditoriumsOnFloor.Count > 0)
        {
            Console.WriteLine($"Аудитории на этаже {floorNumber}:");
            foreach (var auditorium in auditoriumsOnFloor)
            {
                Console.WriteLine($"Номер: {auditorium.Number}");
            }
        }
        else
        {
            Console.WriteLine($"Аудитории на этаже {floorNumber} не найдены.");
        }
    }
}

}

}

}

}