using System;
using System.Collections.Generic;

class Program
{
   
    enum Miesiace
    {
        Styczen = 1,
        Luty,
        Marzec,
        Kwiecien,
        Maj,
        Czerwiec,
        Lipiec,
        Sierpien,
        Wrzesien,
        Pazdziernik,
        Listopad,
        Grudzien
    }

    static void Main()
    {
        // 1. Lista zakupów
        List<string> listaZakupow = new List<string>();

        // Dodajemy 5 produktów
        listaZakupow.Add("Chleb");
        listaZakupow.Add("Mleko");
        listaZakupow.Add("Masło");
        listaZakupow.Add("Jajka");
        listaZakupow.Add("Ser");

        // Wypisujemy wszystkie
        Console.WriteLine("Lista zakupów:");
        foreach (var produkt in listaZakupow)
        {
            Console.WriteLine(produkt);
        }

        // Wypisujemy alfabetycznie
        listaZakupow.Sort();
        Console.WriteLine("\nLista zakupów");
        foreach (var produkt in listaZakupow)
        {
            Console.WriteLine(produkt);
        }

        // Usuwamy 3 produkty
        listaZakupow.Remove("Chleb");
        listaZakupow.Remove("Mleko");
        listaZakupow.Remove("Masło");

        // Wypisujemy pozostałe
        Console.WriteLine("\nLista zakupów po usunięciu 3:");
        foreach (var produkt in listaZakupow)
        {
            Console.WriteLine(produkt);
        }

        // 2. Wypisanie numeru miesiąca z enuma
        Console.WriteLine("\nPodaj miesiąc");
        string userMiesiac = Console.ReadLine();

        if (Enum.TryParse(userMiesiac, true, out Miesiace miesiacEnum))
        {
            Console.WriteLine($"Numer miesiąca {userMiesiac}: {(int)miesiacEnum}");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy miesiąc!");
        }

        // 3. Słownik PL-EN
        Dictionary<string, string> slownik = new Dictionary<string, string>()
        {
            {"Styczen", "January"},
            {"Luty", "February"},
            {"Marzec", "March"},
            {"Kwiecien", "April"},
            {"Maj", "May"},
            {"Czerwiec", "June"},
            {"Lipiec", "July"},
            {"Sierpien", "August"},
            {"Wrzesien", "September"},
            {"Pazdziernik", "October"},
            {"Listopad", "November"},
            {"Grudzien", "December"}
        };

        Console.WriteLine("\nPodaj miesiąc zeby dac na angielski:");
        string plMiesiac = Console.ReadLine();

        if (slownik.ContainsKey(plMiesiac))
        {
            Console.WriteLine($"{plMiesiac} po angielsku to {slownik[plMiesiac]}");
        }
        else
        {
            Console.WriteLine("Nie ma takiego miesiąca ");
        }
    }
}

















