string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**** Převod z desítkové do binární *********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Hrabal *****************");
    Console.WriteLine("************** 04.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty s validací
    Console.Write("Zadejte přirozené číslo (desítkové): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

    // Záloha původního čísla
    uint backupNumber10 = number10;

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Zadané číslo (desítkově): {backupNumber10}");
    Console.WriteLine("================================================");

    // Speciální případ pro nulu
    if (number10 == 0)
    {
        Console.WriteLine();
        Console.WriteLine("===== Výsledek převodu =====");
        Console.WriteLine("Binární reprezentace: 0");
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();
        continue;
    }

    // Pole pro uložení binárních cifer (32 bitů je maximální délka pro uint)
    uint[] myArray = new uint[32];
    uint zbytek;
    uint i;

    Console.WriteLine();
    Console.WriteLine("===== Proces převodu (dělení 2) =====");
    Console.WriteLine();

    // Převod pomocí dělení dvěma
    for (i = 0; number10 > 0; i++)
    {
        zbytek = number10 % 2;
        number10 = (number10 - zbytek) / 2;
        myArray[i] = zbytek;

        Console.WriteLine($"Krok {i + 1}: {number10 + number10 + zbytek} ÷ 2 = {number10}, zbytek: {zbytek}");
    }

    // Výpis binární reprezentace
    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("===== Výsledek převodu =====");
    Console.Write($"Binární reprezentace ({backupNumber10}₁₀): ");

    for (uint j = i; j > 0; j--)
    {
        Console.Write(myArray[j - 1]);
    }
    Console.Write("₂");
    Console.WriteLine();

    // Dodatečné informace
    Console.WriteLine();
    Console.WriteLine("===== Dodatečné informace =====");
    Console.WriteLine($"Desítková hodnota: {backupNumber10}");

    Console.Write("Binární hodnota: ");
    for (uint j = i; j > 0; j--)
    {
        Console.Write(myArray[j - 1]);
    }
    Console.WriteLine();

    Console.WriteLine($"Počet bitů: {i}");

    // Výpis po čtveřicích pro lepší čitelnost (nibbles)
    Console.Write("Binární (po 4 bitech): ");
    for (uint j = i; j > 0; j--)
    {
        Console.Write(myArray[j - 1]);
        if ((i - j) % 4 == 3 && j > 1)
            Console.Write(" ");
    }
    Console.WriteLine();

    // Ověření pomocí vestavěné funkce
    string builtInBinary = Convert.ToString(backupNumber10, 2);
    Console.WriteLine($"Ověření (vestavěná funkce): {builtInBinary}");

    Console.WriteLine();
    Console.WriteLine("Poznámka: Číslo se převádí opakovaným dělením 2,");
    Console.WriteLine("zbytky se zapisují zprava doleva.");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
