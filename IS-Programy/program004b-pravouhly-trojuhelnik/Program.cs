string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("****** Vykreslení pravoúhlého trojúhelníku ******");
    Console.WriteLine("********************************************");
    Console.WriteLine("***************** Matěj Hrabal *************");
    Console.WriteLine("**************** 23.10.2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup výšky trojúhelníku s validací
    Console.Write("Zadejte výšku pravoúhlého trojúhelníku (počet řádků): ");
    int vyska;
    while (!int.TryParse(Console.ReadLine(), out vyska) || vyska < 1)
    {
        Console.Write("Nezadali jste platné přirozené číslo (> 0). Zadejte znovu: ");
    }

    // Výběr typu vykreslení
    Console.WriteLine();
    Console.WriteLine("Vyberte typ vykreslení:");
    Console.WriteLine("1 - Levý pravoúhlý trojúhelník (rovnoběžník s pravou stranou)");
    Console.WriteLine("2 - Pravý pravoúhlý trojúhelník (rovnoběžník s levou stranou)");
    Console.WriteLine("3 - Středový pravoúhlý trojúhelník (rovnoběžník uprostřed)");

    Console.Write("Vaše volba (1-3): ");
    int volba;
    while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 3)
    {
        Console.Write("Neplatná volba. Zadejte číslo 1-3: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji pravoúhlý trojúhelník s výškou {vyska}:");
    Console.WriteLine();

    switch (volba)
    {
        case 1: // Levý pravoúhlý trojúhelník
            for (int i = 1; i <= vyska; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            break;

        case 2: // Pravý pravoúhlý trojúhelník
            for (int i = 1; i <= vyska; i++)
            {
                // Mezery před hvězdičkami
                for (int j = 1; j <= vyska - i; j++)
                {
                    Console.Write("  ");
                }
                // Hvězdičky
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            break;

        case 3: // Středový pravoúhlý trojúhelník
            for (int i = 1; i <= vyska; i++)
            {
                // Mezery před hvězdičkami pro centrování
                for (int j = 1; j <= vyska - i; j++)
                {
                    Console.Write(" ");
                }
                // Hvězdičky
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            break;
    }

    Console.WriteLine();

    // Výpočet počtu hvězdiček
    int pocetHvezdicek;
    switch (volba)
    {
        case 1:
        case 2:
            pocetHvezdicek = vyska * (vyska + 1) / 2;
            break;
        case 3:
            pocetHvezdicek = vyska * vyska;
            break;
        default:
            pocetHvezdicek = 0;
            break;
    }

    string typTrojuhelniku = volba switch
    {
        1 => "levý pravoúhlý",
        2 => "pravý pravoúhlý",
        3 => "středový pravoúhlý",
        _ => "neznámý"
    };

    Console.WriteLine($"Typ: {typTrojuhelniku} trojúhelník");
    Console.WriteLine($"Výška: {vyska} řádků");
    Console.WriteLine($"Celkový počet hvězdiček: {pocetHvezdicek}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}