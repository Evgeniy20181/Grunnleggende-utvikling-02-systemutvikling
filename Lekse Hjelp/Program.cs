using System;
using System.Collections.Generic;

class Lekse
{
    public string Navn { get; set; }
    public string Frist { get; set; }
    public string Fag { get; set; }
    public bool Fullført { get; set; } = false;

    public Lekse(string navn, string frist, string fag)
    {
        Navn = navn;
        Frist = frist;
        Fag = fag;
    }

    public void MarkérSomFullført()
    {
        Fullført = true;
    }

    public override string ToString()
    {
        return $"{Navn} | Frist: {Frist} | Fag: {Fag} | Status: {(Fullført ? "Fullført" : "Ikke fullført")}";
    }
}

class Program
{
    static List<Lekse> lekseListe = new List<Lekse>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1. Legg til lekse");
            Console.WriteLine("2. Vis lekser");
            Console.WriteLine("3. Markér lekse som fullført");
            Console.WriteLine("4. Avslutt");
            Console.Write("Velg et alternativ: ");
            int valg = int.Parse(Console.ReadLine());

            switch (valg)
            {
                case 1:
                    LeggTilLekse();
                    break;
                case 2:
                    VisLekser();
                    break;
                case 3:
                    MarkerSomFullført();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Ugyldig valg, prøv igjen.");
                    break;
            }
        }
    }

    static void LeggTilLekse()
    {
        Console.Write("Navn på lekse: ");
        string navn = Console.ReadLine();
        Console.Write("Frist: ");
        string frist = Console.ReadLine();
        Console.Write("Fag: ");
        string fag = Console.ReadLine();

        lekseListe.Add(new Lekse(navn, frist, fag));
        Console.WriteLine("Lekse lagt til!");
    }

    static void VisLekser()
    {
        Console.WriteLine("\nLekser:");
        for (int i = 0; i < lekseListe.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {lekseListe[i]}");
        }
    }

    static void MarkerSomFullført()
    {
        VisLekser();
        Console.Write("Velg lekse å markere som fullført (tast nummer): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < lekseListe.Count)
        {
            lekseListe[index].MarkérSomFullført();
            Console.WriteLine("Lekse markert som fullført!");
        }
        else
        {
            Console.WriteLine("Ugyldig valg.");
        }
    }
}
