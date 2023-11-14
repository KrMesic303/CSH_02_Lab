namespace Zad1.KompleksniBrojevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KompleksniBrojKlasa kbk = new(1, 2);
            KompleksniBrojStruktura kbs = new(3, 4);

            Console.WriteLine(kbk.ToString());
            Console.WriteLine(kbs.ToString());

            KompleksniBrojKlasa kbk2 = kbk;
            KompleksniBrojStruktura kbs2 = kbs;

            Console.WriteLine("Prije promjene: ");
            Console.WriteLine(kbk2.ToString());
            Console.WriteLine(kbs2.ToString());

            kbk2.RealniDio = 6;
            kbs2.RealniDio = 7;

            Console.WriteLine("Nakon promjene: ");
            Console.WriteLine("Kbk: " + kbk.ToString());
            Console.WriteLine("Kbs: " + kbs.ToString());
            Console.WriteLine("Kbk2: " + kbk2.ToString());
            Console.WriteLine("Kbs2: " + kbs2.ToString());

            // Klasa je referentni tip, dok je Struct vrijednosni tip
            // Prijevod: Klase su kopirane pomoću referenci/pointera,
            // Strukture su kopirane pomoću vrijednosti.
        }
    }
}