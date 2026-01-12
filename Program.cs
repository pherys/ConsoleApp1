using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== TABUADA COMPLETA (1 AO 10) ===\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"--- Tabuada do {i} ---");

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
