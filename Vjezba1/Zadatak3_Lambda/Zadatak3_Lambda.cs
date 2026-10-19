// Zadatak 3: lambda izrazi
// Lambda je metoda bez imena napisana na mjestu gdje se koristi: (parametri) => izraz.

Console.OutputEncoding = System.Text.Encoding.UTF8;
Zadatak3_Lambda.Pokreni();

delegate int Calc3(int x);

static class Zadatak3_Lambda
{
    public static void Pokreni()
    {
        Calc3 kvadrat = x => x * x;
        Console.WriteLine($"kvadrat(7) = {kvadrat(7)}");

        Calc3 zbroji = x =>
        {
            int s = 0;
            for (int i = 1; i <= x; i++) s += i;
            return s;
        };
        Console.WriteLine($"zbroj 1..10 = {zbroji(10)}");

        // Lambda "hvata" varijable iz okoline (closure).
        int faktor = 3;
        Calc3 puta = x => x * faktor;
        Console.WriteLine($"puta(5), faktor = 3: {puta(5)}");

        faktor = 10;
        Console.WriteLine($"puta(5), faktor = 10: {puta(5)}");   // zašto je rezultat drukčiji?

        //Lambda za apsol vrijednost bez Math.Abs
        Calc3 abs = x => x < 0 ? -x : x;
        Console.WriteLine($"abs(-8) = {abs(-8)}");

        //Lambda bez parametara koja ispisuje trenutno vrijeme
        Action ispisiVrijeme = () =>
        {
            Console.WriteLine($"Trenutno vrijeme: {DateTime.Now}");
        };
        ispisiVrijeme();
    }
}
