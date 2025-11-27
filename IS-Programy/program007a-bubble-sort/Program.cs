string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Bubble Sort ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("***************** Matěj Hrabal *************");
    Console.WriteLine("**************** 20.11.2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup počtu čísel s validací
    Console.Write("Zadejte počet čísel k seřazení: ");
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
    Console.WriteLine("Původní pole:");
    Console.Write("[");
    for (int i = 0; i < pocet; i++)
    {
        Console.Write(cisla[i]);
        if (i < pocet - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");

    // Bubble Sort - řazení od nejmenšího po největší
    int pocetProhozeni = 0;
    int pocetPorovnani = 0;

    for (int i = 0; i < pocet - 1; i++)
    {
        for (int j = 0; j < pocet - i - 1; j++)
        {
            pocetPorovnani++;
            if (cisla[j] > cisla[j + 1])
            {
                // Prohození prvků
                int temp = cisla[j];
                cisla[j] = cisla[j + 1];
                cisla[j + 1] = temp;
                pocetProhozeni++;
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine("Seřazené pole (vzestupně):");
    Console.Write("[");
    for (int i = 0; i < pocet; i++)
    {
        Console.Write(cisla[i]);
        if (i < pocet - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");

    Console.WriteLine();
    Console.WriteLine("===== Statistika řazení =====");
    Console.WriteLine($"Počet porovnání: {pocetPorovnani}");
    Console.WriteLine($"Počet prohození: {pocetProhozeni}");
    Console.WriteLine($"Algoritmus: Bubble Sort");
    Console.WriteLine($"Časová složitost: O(n²)");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
