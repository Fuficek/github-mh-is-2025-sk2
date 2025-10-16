string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Tomáš Žižka ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
    }

    Console.Write("Zadejte rozdíl mezi čísly (celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte rozdíl znovu: ");
    }

    if (step == 0)
    {
        Console.WriteLine("Rozdíl nemůže být 0!");
    }
    else if ((step > 0 && first > last) || (step < 0 && first < last))
    {
        Console.WriteLine("Neplatná kombinace hodnot - řada nebude konečná!");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Číselná řada:");
        
        if (step > 0)
        {
            for (int i = first; i <= last; i += step)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            for (int i = first; i >= last; i += step)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}