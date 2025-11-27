string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Generator čísel ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("***************** Matěj Hrabal *************");
    Console.WriteLine("**************** 20.11.2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup počtu generovaných čísel s validací
    Console.Write("Zadejte počet generovaných čísel: ");
    int pocet;
    while (!int.TryParse(Console.ReadLine(), out pocet) || pocet < 1)
    {
        Console.Write("Nezadali jste platné přirozené číslo (> 0). Zadejte znovu: ");
    }

    // Vstup dolní meze s validací
    Console.Write("Zadejte dolní mez (minimum): ");
    int dolniMez;
    while (!int.TryParse(Console.ReadLine(), out dolniMez))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }

    // Vstup horní meze s validací
    Console.Write("Zadejte horní mez (maximum): ");
    int horniMez;
    while (!int.TryParse(Console.ReadLine(), out horniMez) || horniMez < dolniMez)
    {
        Console.Write("Nezadali jste platné číslo (musí být >= dolní mez). Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Generuji {pocet} náhodných čísel v rozmezí [{dolniMez}, {horniMez}]:");
    Console.WriteLine();

    // Vytvoření generátoru náhodných čísel
    Random random = new Random();

    // Pole pro ukládání vygenerovaných čísel
    int[] cisla = new int[pocet];

    // Počítadla pro různé kategorie
    int pocetKladnych = 0;
    int pocetZapornych = 0;
    int pocetNul = 0;
    int pocetSudych = 0;
    int pocetLichych = 0;

    // Generování a analýza čísel
    for (int i = 0; i < pocet; i++)
    {
        cisla[i] = random.Next(dolniMez, horniMez + 1);
        Console.Write($"{cisla[i]}; ");

        // Analýza kladných, záporných a nul
        if (cisla[i] > 0)
            pocetKladnych++;
        else if (cisla[i] < 0)
            pocetZapornych++;
        else
            pocetNul++;

        // Analýza sudých a lichých
        if (cisla[i] % 2 == 0)
            pocetSudych++;
        else
            pocetLichych++;
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("===== Statistika vygenerovaných čísel =====");
    Console.WriteLine($"Kladná čísla: {pocetKladnych}");
    Console.WriteLine($"Záporná čísla: {pocetZapornych}");
    Console.WriteLine($"Nuly: {pocetNul}");
    Console.WriteLine($"Sudá čísla: {pocetSudych}");
    Console.WriteLine($"Lichá čísla: {pocetLichych}");
    Console.WriteLine($"Celkem čísel: {pocet}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
