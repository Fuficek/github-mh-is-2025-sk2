/* Hlavní program - začátek */

string again = "a";
while (again == "a")
{
    Console.Clear();

    // Metoda pro razítko - hlavičku
    Razitko();

    // Načítání hodnot
    ulong a = NactiCislo("Zadejte číslo a: ");
    ulong b = NactiCislo("Zadejte číslo b: ");

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Zadaná čísla: a = {a}, b = {b}");
    Console.WriteLine("================================================");

    // Výpočet NSD (Euklidův algoritmus)
    ulong nsd = VypocetNSD(a, b);

    // Výpočet NSN pomocí vzorce: NSN = (a * b) / NSD
    ulong nsn = (a * b) / nsd;

    Console.WriteLine();
    Console.WriteLine("===== Výsledky =====");
    Console.WriteLine($"Největší společný dělitel (NSD): {nsd}");
    Console.WriteLine($"Nejmenší společný násobek (NSN): {nsn}");

    // Dodatečné informace
    Console.WriteLine();
    Console.WriteLine("===== Ověření =====");
    Console.WriteLine($"Ověření NSD: {a} = {nsd} × {a / nsd}, {b} = {nsd} × {b / nsd}");
    Console.WriteLine($"Ověření NSN: {nsn} / {a} = {nsn / a}, {nsn} / {b} = {nsn / b}");

    Console.WriteLine();
    Console.WriteLine("===== Další informace =====");
    if (nsd == 1)
    {
        Console.WriteLine("Čísla jsou nesoudělná (relativně prvočíselná).");
    }
    else
    {
        Console.WriteLine($"Čísla mají společného dělitele: {nsd}");
    }

    Console.WriteLine($"Poměr čísel: {a / nsd} : {b / nsd}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

/* Hlavní program - konec */

/* Metoda která nic nevrací - nevrací hodnotu */
static void Razitko()
{
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpočet NSD a NSN **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Hrabal *****************");
    Console.WriteLine("************** 04.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.WriteLine("NSD = Největší společný dělitel");
    Console.WriteLine("NSN = Nejmenší společný násobek");
    Console.WriteLine();
}

/* Metoda pro načtení čísel */
static ulong NactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

    // Metoda, která vrací nějaký konkrétní datový typ, musí obsahovat následující řádek
    return cislo;
}

/* Metoda pro výpočet NSD (Euklidův algoritmus) */
static ulong VypocetNSD(ulong a, ulong b)
{
    Console.WriteLine();
    Console.WriteLine("===== Výpočet NSD (Euklidův algoritmus) =====");
    int krok = 1;

    ulong originalA = a;
    ulong originalB = b;

    while (b != 0)
    {
        ulong zbytek = a % b;
        Console.WriteLine($"Krok {krok}: {a} = {b} × {a / b} + {zbytek}");

        a = b;
        b = zbytek;
        krok++;
    }

    Console.WriteLine($"NSD({originalA}, {originalB}) = {a}");

    return a;
}
