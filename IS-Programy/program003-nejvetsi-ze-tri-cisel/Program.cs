string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********* Největší ze tří čísel ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("***************** Matěj Hrabal *************");
    Console.WriteLine("**************** 23.10.2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup prvního čísla s validací
    Console.Write("Zadejte celočíselnou hodnotu A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu A znovu: ");
    }

    // Vstup druhého čísla s validací
    Console.Write("Zadejte celočíselnou hodnotu B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu B znovu: ");
    }

    // Vstup třetího čísla s validací
    Console.Write("Zadejte celočíselnou hodnotu C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu C znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("===========================================================");
    Console.WriteLine("Zadaná čísla: A = " + a + ", B = " + b + ", C = " + c);
    Console.WriteLine();

    // Logika pro nalezení největšího čísla
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší číslo je A = {a}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší číslo je B = {b}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    Console.WriteLine("===========================================================");

    // Zobrazení dalších informací
    Console.WriteLine();
    Console.WriteLine("--- Další informace ---");

    // Seřazení čísel pro lepší přehlednost
    int[] cisla = { a, b, c };
    Array.Sort(cisla);
    Console.WriteLine($"Seřazeno vzestupně: {cisla[0]} ≤ {cisla[1]} ≤ {cisla[2]}");
    Console.WriteLine($"Průměr čísel: {(a + b + c) / 3.0:F2}");
    Console.WriteLine($"Součet čísel: {a + b + c}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}