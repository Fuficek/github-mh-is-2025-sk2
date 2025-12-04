using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**** Bubble Sort a vykreslení obrazce *****");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Hrabal *****************");
    Console.WriteLine("************** 04.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup počtu čísel s validací
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
    {
        Console.Write("Nezadali jste platné přirozené číslo (> 0). Zadejte znovu: ");
    }

    // Vstup dolní meze s validací
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Vstup horní meze s validací
    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    // Kontrola, zda je horní mez větší než dolní
    while (upperBound < lowerBound)
    {
        Console.WriteLine("Horní mez musí být větší nebo rovna dolní mezi!");
        Console.Write("Zadejte horní mez znovu: ");
        while (!int.TryParse(Console.ReadLine(), out upperBound))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
        }
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("================================================");

    // Deklarace pole a generování náhodných čísel
    int[] myRandNumbs = new int[n];
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    Console.Write("[");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write(myRandNumbs[i]);
        if (i < n - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");

    // Měření času řazení
    Stopwatch myStopwatch = new Stopwatch();
    int compare = 0;
    int change = 0;

    // Bubble Sort - řazení od největšího po nejmenší (sestupně)
    myStopwatch.Start();
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            compare++;
            if (myRandNumbs[j] < myRandNumbs[j + 1])
            {
                int tmp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = tmp;
                change++;
            }
        }
    }
    myStopwatch.Stop();

    // Výpis seřazených čísel
    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine("Seřazená čísla (sestupně):");
    Console.Write("[");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i]);
        if (i < n - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");

    Console.WriteLine();
    Console.WriteLine("===== Statistika řazení =====");
    Console.WriteLine($"Počet porovnání: {compare}");
    Console.WriteLine($"Počet výměn: {change}");
    Console.WriteLine($"Čas potřebný na seřazení: {myStopwatch.Elapsed}");
    Console.WriteLine($"Algoritmus: Bubble Sort (sestupně)");

    // Nalezení i-tého největšího čísla
    Console.WriteLine();
    Console.Write("Zadejte pořadí hledaného čísla (např. 2 pro druhé největší): ");
    int iValue;
    while (!int.TryParse(Console.ReadLine(), out iValue) || iValue < 1 || iValue > n)
    {
        Console.Write($"Zadejte platné číslo mezi 1 a {n}: ");
    }

    int actualRank = 1;
    int currentValue = myRandNumbs[0];
    int ithLargest = myRandNumbs[0];
    bool found = false;

    // Procházíme čísla od druhého prvku
    for (int j = 1; j < n; j++)
    {
        if (myRandNumbs[j] < currentValue)
        {
            currentValue = myRandNumbs[j];
            actualRank++;
        }

        if (actualRank == iValue && !found)
        {
            ithLargest = currentValue;
            found = true;
        }
    }

    Console.WriteLine();
    Console.WriteLine("================================");
    Console.WriteLine($"{iValue}. největší číslo: {ithLargest}");

    // Vykreslení obrazce podle i-tého největšího čísla
    Console.WriteLine();
    Console.WriteLine("===== Vykreslení obrazce =====");
    Console.WriteLine($"Rozměry: výška = {ithLargest}, šířka = {ithLargest * 2}");
    Console.WriteLine();

    int height = ithLargest;
    int width = ithLargest * 2;

    // Kontrola rozumných rozměrů
    if (height >= 4 && width >= 8)
    {
        // 2× horní plný řádek
        for (int r = 0; r < 2; r++)
        {
            for (int i = 0; i < width; i++)
                Console.Write("*");
            Console.WriteLine();
        }

        // Vnitřní řádky (výška – 4, protože 2 plné řádky nahoře + 2 dole)
        for (int i = 0; i < height - 4; i++)
        {
            Console.Write("*");
            for (int j = 0; j < width - 2; j++)
                Console.Write(" ");
            Console.Write("*");
            Console.WriteLine();
        }

        // 2× dolní plný řádek
        for (int r = 0; r < 2; r++)
        {
            for (int i = 0; i < width; i++)
                Console.Write("*");
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine($"Obrazec je příliš malý pro vykreslení (min. výška 4, šířka 8).");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
