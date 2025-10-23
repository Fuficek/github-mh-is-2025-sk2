string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********* Vykreslení obdélníku/čtverce ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("***************** Matěj Hrabal *************");
    Console.WriteLine("**************** 23.10.2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup první strany (šířka) s validací
    Console.Write("Zadejte délku strany a (šířka): ");
    int stranaA;
    while (!int.TryParse(Console.ReadLine(), out stranaA) || stranaA < 1)
    {
        Console.Write("Nezadali jste platné přirozené číslo (> 0). Zadejte znovu: ");
    }

    // Vstup druhé strany (výška) s validací
    Console.Write("Zadejte délku strany b (výška): ");
    int stranaB;
    while (!int.TryParse(Console.ReadLine(), out stranaB) || stranaB < 1)
    {
        Console.Write("Nezadali jste platné přirozené číslo (> 0). Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji obdélník o rozměrech {stranaA} × {stranaB}:");
    Console.WriteLine();

    // Vykreslení obdélníku
    for (int i = 0; i < stranaB; i++) // Cyklus pro řádky (výška)
    {
        for (int j = 0; j < stranaA; j++) // Cyklus pro sloupce (šířka)
        {
            Console.Write("* "); // Výpis hvězdičky a mezery
        }
        Console.WriteLine(); // Přesun na nový řádek
    }

    Console.WriteLine();

    // Informace o typu obdélníku
    if (stranaA == stranaB)
    {
        Console.WriteLine("Jedná se o čtverec.");
    }
    else
    {
        Console.WriteLine($"Jedná se o obdélník.");
    }

    // Výpočet obvodu a obsahu
    int obvod = 2 * (stranaA + stranaB);
    int obsah = stranaA * stranaB;
    Console.WriteLine($"Obvod: {obvod} jednotek");
    Console.WriteLine($"Obsah: {obsah} čtvercových jednotek");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}