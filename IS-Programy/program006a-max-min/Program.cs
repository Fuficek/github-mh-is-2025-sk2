string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Maximum a Minimum *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("***************** Matěj Hrabal *************");
    Console.WriteLine("**************** 20.11.2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup počtu čísel s validací
    Console.Write("Zadejte počet čísel: ");
    int pocet;
    while (!int.TryParse(Console.ReadLine(), out pocet) || pocet < 1)
    {
        Console.Write("Nezadali jste platné přirozené číslo (> 0). Zadejte znovu: ");
    }

    Console.WriteLine();

    // Pole pro ukládání čísel
    int[] cisla = new int[pocet];

    // Vstup jednotlivých čísel
    for (int i = 0; i < pocet; i++)
    {
        Console.Write($"Zadejte {i + 1}. číslo: ");
        while (!int.TryParse(Console.ReadLine(), out cisla[i]))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
        }
    }

    Console.WriteLine();
    Console.WriteLine("Zadaná čísla:");
    Console.Write("[");
    for (int i = 0; i < pocet; i++)
    {
        Console.Write(cisla[i]);
        if (i < pocet - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");

    // Nalezení maxima a minima
    int maximum = cisla[0];
    int minimum = cisla[0];
    int indexMaxima = 0;
    int indexMinima = 0;

    for (int i = 1; i < pocet; i++)
    {
        if (cisla[i] > maximum)
        {
            maximum = cisla[i];
            indexMaxima = i;
        }
        if (cisla[i] < minimum)
        {
            minimum = cisla[i];
            indexMinima = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("===== Výsledky =====");
    Console.WriteLine($"Maximum: {maximum} (na pozici {indexMaxima + 1})");
    Console.WriteLine($"Minimum: {minimum} (na pozici {indexMinima + 1})");
    Console.WriteLine($"Rozdíl (max - min): {maximum - minimum}");

    // Výpočet průměru
    double prumer = 0;
    for (int i = 0; i < pocet; i++)
    {
        prumer += cisla[i];
    }
    prumer = prumer / pocet;
    Console.WriteLine($"Průměr: {prumer:F2}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
