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

        Console.WriteLine($"Wersja 2 - Losowanie liczby parzystej:");

        while (licznik < n)
        {
            int wylosowana = rand.Next(-4, 5) * 2;
            liczby[licznik] = wylosowana;
            licznik++;
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