using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Random rand = new Random();
        int licznik = 0;
        int[] liczby = new int[n];

        Console.WriteLine($"Wersja 1 - Losowanie z poprawnością:");

        while (licznik < n)
        {
            int wylosowana = rand.Next(-8, 9);

            if (wylosowana % 2 == 0)
            {
                liczby[licznik] = wylosowana;
                licznik++;
            }
        }

        WypiszLiczby(liczby);
        Console.WriteLine($"Liczba faktycznych losowań: {licznik}");
    }

    static void WypiszLiczby(int[] liczby)
    {
        Console.Write(string.Join(", ", liczby));
        Console.WriteLine();
    }
}