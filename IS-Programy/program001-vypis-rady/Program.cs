using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej první hodnotu (first): ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Zadej poslední hodnotu (last): ");
        int last = int.Parse(Console.ReadLine());

        Console.Write("Zadej krok (step): ");
        int step = int.Parse(Console.ReadLine());

        for (int i = first; i < last; i += step)
        {
            Console.WriteLine(i);
        }
    }
}
