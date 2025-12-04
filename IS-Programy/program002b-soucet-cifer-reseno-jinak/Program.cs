string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**** Součet cifer - řešeno stringem *******");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Hrabal *****************");
    Console.WriteLine("************** 04.12.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup textového řetězce
    Console.Write("Zadejte textový řetězec obsahující číslice: ");
    string number = Console.ReadLine() ?? "";

    // Inicializace proměnných pro výpočet
    int suma = 0;
    int multi = 1;
    List<int> digits = new List<int>();

    // Procházení každého znaku v řetězci
    foreach (char digitChar in number)
    {
        if (char.IsDigit(digitChar))
        {
            int digitNumber = int.Parse(digitChar.ToString());
            suma = suma + digitNumber;
            multi = multi * digitNumber;
            digits.Add(digitNumber);
        }
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Výsledky analýzy:");
    Console.WriteLine($"Zadaný text: {number}");
    Console.WriteLine($"Počet nalezených cifer: {digits.Count}");
    Console.WriteLine("================================================");

    Console.WriteLine();

    if (digits.Count > 0)
    {
        // Rozepis cifer
        Console.Write("Nalezené cifry: ");
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i]);
            if (i < digits.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        // Rozepis součtu
        Console.WriteLine();
        Console.Write("Součet cifer: ");
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i]);
            if (i < digits.Count - 1)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine($" = {suma}");

        // Rozepis součinu
        Console.Write("Součin cifer: ");
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i]);
            if (i < digits.Count - 1)
            {
                Console.Write(" × ");
            }
        }
        Console.WriteLine($" = {multi}");
    }
    else
    {
        Console.WriteLine("V zadaném textu nebyly nalezeny žádné číslice.");
    }

    Console.WriteLine();
    Console.WriteLine("Poznámka: Tento program zpracovává pouze číslice (0-9).");
    Console.WriteLine("Ostatní znaky (písmena, symboly atd.) jsou ignorovány.");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
