using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество вершин: ");
        int V = int.Parse(Console.ReadLine());
        Console.Write("Введите количество рёбер: ");
        int E = int.Parse(Console.ReadLine());
        List<Rebra> rebr = new List<Rebra>();
        Console.WriteLine("Введите вес рёбер в формате: вершина1 вершина2 вес");
        for (int i = 0; i < E; i++)
        {
            string[] input = Console.ReadLine().Split();
            int u = int.Parse(input[0]);
            int v = int.Parse(input[1]);
            int ves = int.Parse(input[2]);
            rebr.Add(new Rebra(u, v, ves));
        }
        Kruskal kruskal = new Kruskal(V, rebr);
        List<Rebra> minput = kruskal.Execute();
        Console.WriteLine("Минимальное остовное дерево:");
        foreach (var rebra in minput)
        {
            Console.WriteLine($"{rebra.Ishod} - {rebra.Konechn} : {rebra.Ves}");
        }
    }
}
class Rebra
{
    public int Ishod { get; }
    public int Konechn { get; }
    public int Ves { get; }
    public Rebra(int ishod, int konechn, int ves)
    {
        Ishod = Ishod;
        Konechn = konechn;
        Ves = ves;
    }
}
class Kruskal
{
    private int V;
    private List<Rebra> rebr;

    public Kruskal(int v, List<Rebra> rebr)
    {
        V = v;
        this.rebr = rebr;
    }
    public List<Rebra> Execute()
    { 
        rebr.Sort((a, b) => a.Ves.CompareTo(b.Ves));
        int[] osn = new int[V + 1];
        for (int i = 1; i <= V; i++)
        {
            osn[i] = i;
        }
        List<Rebra> minput = new List<Rebra>();
        foreach (Rebra rebra in rebr)
        {
            int root1 = Find(osn, rebra.Ishod);
            int root2 = Find(osn, rebra.Konechn);
            if (root1 != root2)
            {
                minput.Add(rebra);
                Union(osn, root1, root2);
            }
        }
        return minput;
    }
    private int Find(int[] osn, int versh)
    {
        if (osn[versh] != versh)
        {
            osn[versh] = Find(osn, osn[versh]);
        }
        return osn[versh];
    }
    private void Union(int[] osn, int x, int y)
    {
        int rootx = Find(osn, x);
        int rooty = Find(osn, y);
        osn[rootx] = rooty;
    }
}