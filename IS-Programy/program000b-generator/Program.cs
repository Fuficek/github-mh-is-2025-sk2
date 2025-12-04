string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
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

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    // Generátor náhodných čísel
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

    // Statistiky
    Console.WriteLine();
    Console.WriteLine("===== Statistika generovaných čísel =====");

    int sum = 0;
    int min = myRandNumbs[0];
    int max = myRandNumbs[0];

    for (int i = 0; i < n; i++)
    {
        sum += myRandNumbs[i];
        if (myRandNumbs[i] < min) min = myRandNumbs[i];
        if (myRandNumbs[i] > max) max = myRandNumbs[i];
    }

    double average = (double)sum / n;

    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Součet: {sum}");
    Console.WriteLine($"Průměr: {average:F2}");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
