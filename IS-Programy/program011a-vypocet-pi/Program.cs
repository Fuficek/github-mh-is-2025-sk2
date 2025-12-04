string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Výpočet čísla π ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Hrabal *****************");
    Console.WriteLine("************** 04.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.WriteLine("Tento program vypočítá hodnotu čísla π pomocí Leibnizovy řady:");
    Console.WriteLine("π/4 = 1 - 1/3 + 1/5 - 1/7 + 1/9 - ...");
    Console.WriteLine();

    // Vstup přesnosti s validací
    Console.Write("Zadejte přesnost (čím menší číslo, tím přesnější výpočet, např. 0.00001): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost) || presnost <= 0)
    {
        Console.Write("Nezadali jste platné kladné reálné číslo. Zadejte přesnost znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Zadaná přesnost: {presnost}");
    Console.WriteLine("================================================");

    double i = 1;
    double znamenko = 1;
    double piCtvrt = 1;
    int iterace = 1;

    Console.WriteLine();
    Console.WriteLine("===== Průběh výpočtu =====");
    Console.WriteLine();

    // Zobrazení prvního kroku
    Console.WriteLine($"Iterace {iterace}: +1/{i} → π ≈ {4 * piCtvrt}");

    while ((1 / i) >= presnost)
    {
        i = i + 2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * (1 / i);
        iterace++;

        // Výpis každé iterace
        if (znamenko == 1)
        {
            Console.WriteLine($"Iterace {iterace}: +1/{i} → π ≈ {4 * piCtvrt}");
        }
        else
        {
            Console.WriteLine($"Iterace {iterace}: -1/{i} → π ≈ {4 * piCtvrt}");
        }
    }

    double vypocetPi = 4 * piCtvrt;

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("===== Výsledek výpočtu =====");
    Console.WriteLine($"Vypočtená hodnota π: {vypocetPi}");
    Console.WriteLine($"Skutečná hodnota π:  {Math.PI}");
    Console.WriteLine($"Rozdíl:              {Math.Abs(vypocetPi - Math.PI)}");
    Console.WriteLine($"Počet iterací:       {iterace}");
    Console.WriteLine($"Poslední člen řady:  1/{i}");
    Console.WriteLine("================================================");

    // Další informace
    Console.WriteLine();
    Console.WriteLine("===== Statistika =====");
    double chyba = Math.Abs(vypocetPi - Math.PI);
    double procentualniChyba = (chyba / Math.PI) * 100;

    Console.WriteLine($"Absolutní chyba:     {chyba:E4}");
    Console.WriteLine($"Procentuální chyba:  {procentualniChyba:F6}%");
    Console.WriteLine($"Přesnost na desetinná místa: {-Math.Log10(chyba):F1}");

    Console.WriteLine();
    Console.WriteLine("Poznámka: Leibnizova řada konverguje velmi pomalu.");
    Console.WriteLine("Pro přesnější výsledky je potřeba mnoho iterací.");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
