string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Intervaly *******************");
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
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Vstup horní meze s validací
    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    // Kontrola, zda je horní mez větší než dolní
    while (hm < dm)
    {
        Console.WriteLine("Horní mez musí být větší nebo rovna dolní mezi!");
        Console.Write("Zadejte horní mez znovu: ");
        while (!int.TryParse(Console.ReadLine(), out hm))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
        }
    }

    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {dm}; Horní mez: {hm}");
    Console.WriteLine("==========================================");

    // Deklarace pole a generování náhodných čísel
    int[] myArray = new int[n];
    Random randomNumber = new Random();

    // Počítadla pro jednotlivé intervaly
    int int1 = 0;  // <dm, 25% hm>
    int int2 = 0;  // <25% hm + 1, 50% hm>
    int int3 = 0;  // <50% hm + 1, 75% hm>
    int int4 = 0;  // <75% hm + 1, hm>

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Náhodná čísla:");
    Console.Write("[");

    for (int i = 0; i < n; i++)
    {
        myArray[i] = randomNumber.Next(dm, hm + 1);
        Console.Write(myArray[i]);
        if (i < n - 1)
            Console.Write(", ");

        // Přiřazení do intervalů
        if (myArray[i] <= (0.25 * hm))
        {
            int1++;
        }
        else if (myArray[i] <= (0.5 * hm))
        {
            int2++;
        }
        else if (myArray[i] <= (0.75 * hm))
        {
            int3++;
        }
        else
        {
            int4++;
        }
    }
    Console.WriteLine("]");

    // Výpočet hranic intervalů
    double hranice25 = 0.25 * hm;
    double hranice50 = 0.5 * hm;
    double hranice75 = 0.75 * hm;

    Console.WriteLine();
    Console.WriteLine("===== Rozdělení do intervalů =====");
    Console.WriteLine();
    Console.WriteLine($"Interval 1: <{dm}, {hranice25:F2}>          Počet: {int1}");
    Console.WriteLine($"Interval 2: <{hranice25 + 1:F2}, {hranice50:F2}>    Počet: {int2}");
    Console.WriteLine($"Interval 3: <{hranice50 + 1:F2}, {hranice75:F2}>    Počet: {int3}");
    Console.WriteLine($"Interval 4: <{hranice75 + 1:F2}, {hm}>         Počet: {int4}");

    Console.WriteLine();
    Console.WriteLine("===== Statistika =====");
    Console.WriteLine($"Celkový počet čísel: {n}");
    Console.WriteLine();
    Console.WriteLine("Procentuální zastoupení:");
    Console.WriteLine($"Interval 1: {(double)int1 / n * 100:F2}%");
    Console.WriteLine($"Interval 2: {(double)int2 / n * 100:F2}%");
    Console.WriteLine($"Interval 3: {(double)int3 / n * 100:F2}%");
    Console.WriteLine($"Interval 4: {(double)int4 / n * 100:F2}%");

    // Grafické znázornění pomocí sloupců
    Console.WriteLine();
    Console.WriteLine("===== Grafické znázornění =====");
    int maxCount = Math.Max(Math.Max(int1, int2), Math.Max(int3, int4));
    int scale = maxCount > 50 ? maxCount / 50 : 1;

    Console.WriteLine($"(Měřítko: 1 znak = {scale} čísel)");
    Console.WriteLine();
    Console.WriteLine($"Int1: {new string('█', int1 / scale)} ({int1})");
    Console.WriteLine($"Int2: {new string('█', int2 / scale)} ({int2})");
    Console.WriteLine($"Int3: {new string('█', int3 / scale)} ({int3})");
    Console.WriteLine($"Int4: {new string('█', int4 / scale)} ({int4})");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
