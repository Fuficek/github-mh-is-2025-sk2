string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Součet cifer *****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Tomáš Žižka ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup čísla od uživatele s validací
    Console.Write("Zadejte celé číslo pro výpočet součtu cifer: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    // Uložení původního čísla pro výpis
    int originalNumber = number;
    
    // Převod na absolutní hodnotu pro práci s ciframi (řešení záporných čísel)
    int absoluteNumber = Math.Abs(number);
    
    // Proměnná pro součet cifer
    int digitSum = 0;
    
    // Speciální případ pro číslo 0
    if (absoluteNumber == 0)
    {
        digitSum = 0;
    }
    else
    {
        // Výpočet součtu cifer pomocí modulo a celočíselného dělení
        int temp = absoluteNumber;
        while (temp > 0)
        {
            int digit = temp % 10;  // Získání poslední cifry
            digitSum += digit;      // Přičtení cifry k součtu
            temp = temp / 10;       // Odebrání poslední cifry
        }
    }
    
    Console.WriteLine();
    Console.WriteLine($"Zadané číslo: {originalNumber}");
    
    // Speciální výpis pro záporná čísla
    if (originalNumber < 0)
    {
        Console.WriteLine($"Absolutní hodnota: {absoluteNumber}");
        Console.WriteLine("Poznámka: Znaménko se při součtu cifer neuvažuje.");
    }
    
    Console.WriteLine($"Součet cifer: {digitSum}");
    
    // Rozepis cifer pro lepší pochopení
    Console.WriteLine();
    Console.Write("Rozepis cifer: ");
    
    if (absoluteNumber == 0)
    {
        Console.WriteLine("0");
    }
    else
    {
        // Získání jednotlivých cifer pro rozepis
        List<int> digits = new List<int>();
        int temp = absoluteNumber;
        
        while (temp > 0)
        {
            digits.Add(temp % 10);
            temp = temp / 10;
        }
        
        // Obrácení pořadí (cifry byly získány odzadu)
        digits.Reverse();
        
        // Výpis rozepisu
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i]);
            if (i < digits.Count - 1)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine($" = {digitSum}");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}