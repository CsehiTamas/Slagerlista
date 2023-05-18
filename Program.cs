using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void bekeres(List<string> zeneszamok)
    {
        // Üres lista létrehozása a zeneszámok tárolására
      

        // 10 zeneszám bekérése a felhasználótól
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Kérem a(z) {0}. zeneszámot: ", i + 1);
            string zeneszam = Console.ReadLine();
            zeneszamok.Add(zeneszam);
        }

        // Zeneszámok rögzítése egy állományba
        using(StreamWriter file = new StreamWriter("zeneszamok.txt"))
        {
            foreach (string zeneszam in zeneszamok)
            {
                file.WriteLine(zeneszam);
            }
        }

        Console.WriteLine("A zeneszámok sikeresen rögzítve lettek az 'zeneszamok.txt' állományba.");
        Console.ReadLine();
    }
    // Kiírom a konzolra az első 10 helyezett előadóját és címét.
    static void zenek(List<string> zeneszamok)
    {
        Console.WriteLine("A zenék:");
        for (int i = 0; i < zeneszamok.Count; i++)
        {
            Console.WriteLine($"{i + 1}. helyezett: {zeneszamok[i]}");
        }
    }
    static void Main(string[] args)
    {
        List<string> zeneszamok = new List<string>();

        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("1. Zeneszámok megadása", "2. Zeneszámok");
        string[] menupontok = { "1. Zeneszámok megadása", "2. Zeneszámok" };
        while (true)
        {
            Console.Clear();
            for (int i = 0; i < menupontok.Length; i++)
            {
                Console.WriteLine(menupontok[i]);
            }
            char valasz = Console.ReadKey().KeyChar;
            Console.Clear();
            switch (valasz)
            {
                case '1':
                    bekeres(zeneszamok);
                    break;
                case '2':
                    zenek(zeneszamok);
                    break;
            }
            Console.ReadKey();
        }
    }
}