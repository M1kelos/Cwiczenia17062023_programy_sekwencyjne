using System;

class Program
{
    static void Main()
    {
        int n = WprowadzLiczbeCalkowitaNieujemna("Podaj wykładnik (n): ");
        int x = WprowadzLiczbeNaturalna("Podaj podstawę (x): ");

        long wynik = ObliczPotegowanie(x, n);
        long wynikBiblioteka = (long)Math.Pow(x, n);

        Console.WriteLine("Wynik otrzymany algorytmem: " + wynik);
        Console.WriteLine("Wynik prawidłowy (funkcja biblioteczna): " + wynikBiblioteka);

        if (wynik == wynikBiblioteka)
        {
            Console.WriteLine("Wyniki są zgodne.");
        }
        else
        {
            Console.WriteLine("Wyniki nie są zgodne.");
        }
    }

    static int WprowadzLiczbeCalkowitaNieujemna(string prompt)
    {
        int liczba;
        bool poprawna = false;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out liczba) && liczba >= 0)
            {
                poprawna = true;
            }
            else
            {
                Console.WriteLine("Błędne dane. Podaj poprawną liczbę całkowitą nieujemną.");
            }
        } while (!poprawna);

        return liczba;
    }

    static int WprowadzLiczbeNaturalna(string prompt)
    {
        int liczba;
        bool poprawna = false;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (int.TryParse(input, out liczba) && liczba > 0)
            {
                poprawna = true;
            }
            else
            {
                Console.WriteLine("Błędne dane. Podaj poprawną liczbę naturalną.");
            }
        } while (!poprawna);

        return liczba;
    }

    static long ObliczPotegowanie(int x, int n)
    {
        long wynik = x;
        int poprzedniWykladnik = 1;

        for (int i = 1; i <= n; i++)
        {
            int aktualnyWykladnik = (i % 2 == 1) ? (i / 2) + 1 : -(i / 2);

            int liczbaDodawan = x * (aktualnyWykladnik - poprzedniWykladnik);

            wynik += liczbaDodawan;

            poprzedniWykladnik = aktualnyWykladnik;
        }

        return wynik;
    }
}