string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Obrácení pole *****************");
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
    Console.WriteLine("Pseudonáhodná čísla (původní pole):");
    Console.Write("[");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write(myRandNumbs[i]);
        if (i < n - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");

    // Zobrazení procesu obrácení
    Console.WriteLine();
    Console.WriteLine("===== Proces obrácení pole =====");
    Console.WriteLine($"Počet výměn: {n / 2}");
    Console.WriteLine();

    // Obrácení pole s výpisem každé výměny
    int swapCount = 0;
    for (int i = 0; i < n / 2; i++)
    {
        swapCount++;
        int leftIndex = i;
        int rightIndex = n - 1 - i;

        Console.WriteLine($"Výměna {swapCount}: pozice {leftIndex} ({myRandNumbs[leftIndex]}) ↔ pozice {rightIndex} ({myRandNumbs[rightIndex]})");

        int tmp = myRandNumbs[i];
        myRandNumbs[i] = myRandNumbs[n - 1 - i];
        myRandNumbs[n - 1 - i] = tmp;
    }

    // Výpis obráceného pole
    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pole po obrácení:");
    Console.Write("[");
    for (int i = 0; i < n; i++)
    {
        Console.Write(myRandNumbs[i]);
        if (i < n - 1)
            Console.Write(", ");
    }
    Console.WriteLine("]");

    // Statistiky
    Console.WriteLine();
    Console.WriteLine("===== Statistika =====");
    Console.WriteLine($"Délka pole: {n}");
    Console.WriteLine($"Počet provedených výměn: {swapCount}");
    Console.WriteLine($"Algoritmus: In-place array reversal");
    Console.WriteLine($"Časová složitost: O(n/2) ≈ O(n)");
    Console.WriteLine($"Prostorová složitost: O(1)");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
