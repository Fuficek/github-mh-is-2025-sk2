string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("******** Seřazení dvou čísel ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Hrabal *****************");
    Console.WriteLine("************** 04.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup prvního čísla s validací
    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu A znovu: ");
    }

    // Vstup druhého čísla s validací
    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu B znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine($"A = {a}");
    Console.WriteLine($"B = {b}");
    Console.WriteLine("================================================");

    // Uložení původních hodnot pro zobrazení
    int originalA = a;
    int originalB = b;

    // Seřazení pomocí prohození
    bool wasSwapped = false;
    if (a > b)
    {
        int temp = a;
        a = b;
        b = temp;
        wasSwapped = true;
    }

    Console.WriteLine();
    Console.WriteLine("===== Výsledek seřazení =====");

    if (wasSwapped)
    {
        Console.WriteLine("Došlo k prohození hodnot!");
        Console.WriteLine($"Původní pořadí: {originalA}, {originalB}");
        Console.WriteLine($"Seřazené pořadí: {a}, {b}");
    }
    else
    {
        Console.WriteLine("Hodnoty již byly seřazeny správně.");
        Console.WriteLine($"Seřazené pořadí: {a}, {b}");
    }

    Console.WriteLine();
    Console.WriteLine($"Menší číslo: {a}");
    Console.WriteLine($"Větší číslo: {b}");
    Console.WriteLine($"Rozdíl: {b - a}");

    // Speciální případ - rovnost
    if (a == b)
    {
        Console.WriteLine();
        Console.WriteLine("Poznámka: Obě čísla jsou stejná!");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
