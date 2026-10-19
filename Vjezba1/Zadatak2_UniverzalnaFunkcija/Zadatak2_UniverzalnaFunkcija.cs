// Zadatak 2: univerzalna funkcija
// Jedna funkcija radi za sve uvjete jer se uvjet predaje kao delegat.

Console.OutputEncoding = System.Text.Encoding.UTF8;
Zadatak2_UniverzalnaFunkcija.Pokreni();

delegate bool Uvjet(int x);

static class Zadatak2_UniverzalnaFunkcija
{
    static bool JeParan(int x) => x % 2 == 0;
    static bool JeVeciOdDeset(int x) => x > 10;

    static bool JeDjeljivSaTri(int x) => x % 3 == 0;
    static int Ispisi(int[] niz, Uvjet uvjet)
    {
        int brojac = 0;

        foreach (int x in niz)
            if (uvjet(x))
                Console.Write(x + " ");
        Console.WriteLine();
        return brojac; 
    }

    public static void Pokreni()
    {
        int[] niz = { 3, 8, 12, 15, 20, 7, 4 };

        Console.Write("Parni: ");
        Ispisi(niz, JeParan);

        Console.Write("Veći od 10: ");
        Ispisi(niz, JeVeciOdDeset);

        Console.Write("Djeljiv sa 3:");
        Ispisi(niz, JeDjeljivSaTri);

        Console.WriteLine("Ispisano elemenata: {brojElemenata}");
    }
}
