using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę oczek dla pierwszej kości (1-6): ");
        int wartosc = int.Parse(Console.ReadLine());

        Kosc kosc1 = new Kosc(wartosc);

        Console.WriteLine();
        Console.WriteLine("PIERWSZA KOŚĆ");
        Console.WriteLine("Liczba utworzonych instancji: " + Kosc.liczbaInstancji);
        Console.WriteLine("Liczba oczek: " + kosc1.liczbaOczek);
        Console.WriteLine("Liczba oczek słownie: " + kosc1.WynikSlownie());
        Console.WriteLine("Plik graficzny: " + kosc1.pliki[kosc1.identyfikatorPliku]);

        Console.WriteLine();

        Kosc kosc2 = new Kosc();

        Console.WriteLine("DRUGA KOŚĆ");
        Console.WriteLine("Liczba utworzonych instancji: " + Kosc.liczbaInstancji);
        Console.WriteLine("Liczba oczek: " + kosc2.liczbaOczek);
        Console.WriteLine("Liczba oczek słownie: " + kosc2.WynikSlownie());
        Console.WriteLine("Plik graficzny: " + kosc2.pliki[kosc2.identyfikatorPliku]);

        Console.WriteLine();
        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
