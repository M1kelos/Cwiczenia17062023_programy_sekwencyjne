using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int wysokosc = int.Parse(Console.ReadLine());

        RysujTrojkat(wysokosc);
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = wysokosc * 2 - 1;
        int srodek = szerokosc / 2;

        for (int i = 0; i < wysokosc; i++)
        {
            for (int j = 0; j < szerokosc; j++)
            {
                if (j >= srodek - i && j <= srodek + i)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}