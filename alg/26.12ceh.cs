using System;
using System.Collections.Generic;
using System.Linq;
class Produkt
{
    public string Name { get; set; }
    public int Year { get; set; }
    public int Obiem { get; set; }
}
class program
{
    static void Main()
    {
        List<Produkt> produkts = new List<Produkt>
        {
            new Produkt { Name = "Цех1", Year = 2005, Obiem = 200 },
            new Produkt { Name = "Цех2", Year = 2006, Obiem = 237 },
            new Produkt { Name = "Цех3", Year = 2001, Obiem = 333 },
            new Produkt { Name = "Цех1", Year = 2003, Obiem = 208 },
            new Produkt { Name = "Цех1", Year = 2000, Obiem = 209 },
            new Produkt { Name = "Цех1", Year = 2009, Obiem = 203 }
        };
        var vesobiem = produkts
            .GroupBy(p => p.Name)
            .Select(g => new { Ceh = g.Key, Vesobiem1 = g.Sum(p => p.Obiem) });
        foreach (var item in vesobiem)
        {
            Console.WriteLine($"Цех: {item.Ceh}, общий объем: {item.Vesobiem1}");
            var intensivnost = produkts
                .Where(p => p.Name == item.Ceh)
                .GroupBy(p => p.Year)
                .Select(g => new { Year = g.Key, Intensivnost1 = g.Sum(p => p.Obiem) / 365.0 });
            foreach (var intensivnost1 in intensivnost)
            {
                Console.WriteLine($"Год: {intensivnost1.Year}, интенсивность производства: {intensivnost1.Intensivnost1}");
            }
        }
    }
}