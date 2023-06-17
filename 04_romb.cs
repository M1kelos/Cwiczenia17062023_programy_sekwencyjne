using System;

class Program
{
    static void Main()
    {
        int maxAttempts = 3;
        int invalidInputCount = 0;

        int wysokosc = WprowadzWysokosc(maxAttempts, invalidInputCount);

        if (wysokosc == -1)
        {
            Console.WriteLine("Błędne dane. Zakończono program.");
        }
        else
        {
            RysujRomb(wysokosc);
        }
    }

    static int WprowadzWysokosc(int maxAttempts, int invalidInputCount)
    {
        while (invalidInputCount < maxAttempts)
        {
            Console.Write("Podaj wysokość rombu (liczba nieparzysta >= 3): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int wysokosc))
            {
                if (wysokosc >= 3 && wysokosc % 2 == 1)
                {
                    return wysokosc;
                }
            }

            invalidInputCount++;
        }

        return -1;
    }

    static void RysujRomb(int wysokosc)
    {
        Random rand = new Random();

        Console.WriteLine("Rysowanie rombu:");

        // Rysowanie górnej połowy rombu
        for (int i = 0; i < wysokosc / 2 + 1; i++)
        {
            RysujWiersz(wysokosc, i, rand);
        }

        // Rysowanie dolnej połowy rombu
        for (int i = wysokosc / 2 - 1; i >= 0; i--)
        {
            RysujWiersz(wysokosc, i, rand);
        }
    }

    static void RysujWiersz(int wysokosc, int numerWiersza, Random rand)
    {
        int szerokosc = wysokosc - 1;
        int srodek = szerokosc / 2;

        for (int j = 0; j < szerokosc; j++)
        {
            if (j >= srodek - numerWiersza && j <= srodek + numerWiersza)
            {
                if (numerWiersza == 0 || numerWiersza == wysokosc / 2)
                {
                    Console.Write(LosujZnak(new[] { "#", "@", "|", "*" }));
                }
                else
                {
                    Console.Write(LosujZnak(new[] { ".", ":", "-", "+" }));
                }
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }

    static char LosujZnak(string[] znaki)
    {
        int indeks = new Random().Next(znaki.Length);
        return znaki[indeks][0];
    }
}