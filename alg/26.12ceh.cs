using System;
using System.Linq;
class Ceh
{
    public string Name { get; set; }
    public int Year { get; set; }
    public int Obiem { get; set; }
}

class Ceh1
{
    private Ceh[] cehs;
    private int cehcnt;

    public Ceh1(int count)
    {
        cehs = new Ceh[count];
        cehcnt = 0;
    }

    public void AddCeh(string name, int year, int obiem)
    {
        cehs[cehcnt] = new Ceh { Name = name, Year = year, Obiem = obiem };
        cehcnt++;
    }

    public void vesobiem()
    {
        var vesobiem1 = cehs
            .GroupBy(w => w.Name)
            .Select(g => new
            {
                Ceh = g.Key,
                vesobiem11 = g.Sum(w => w.Obiem)
            });

        foreach (var item in vesobiem1)
        {
            Console.WriteLine($"Цех: {item.Ceh}, общий объем: {item.vesobiem11}");
        }
    }

    public void Intensity()
    {
        var intensity11 = cehs
            .GroupBy(w => w.Year)
            .Select(g => new
            {
                Year = g.Key,
                Intensity1 = g.Sum(w => w.Obiem) / 365.0
            });

        foreach (var item in intensity11)
        {
            Console.WriteLine($"Год: {item.Year}, интенсивность: {item.Intensity1}");
        }
    }
}

class Program
{
    static void Main()
    {
        Ceh1 stats = new Ceh1(3);
        stats.AddCeh("Цех1", 2000, 32);
        stats.AddCeh("Цех2", 2000, 31);
        stats.AddCeh("Цех1", 2001, 33);

        stats.vesobiem();
        stats.Intensity();
    }
}
