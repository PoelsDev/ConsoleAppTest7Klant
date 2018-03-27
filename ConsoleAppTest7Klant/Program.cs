using System;

namespace ConsoleAppTest7Klant
{
    class Program
    {
        static void Main(string[] args)
        {
            Klant k1 = new Klant { Voornaam = "Bart", Achternaam = "De Bruine", KlantNummer = 1, Postcode = "2980" };
            Klant k2 = new Klant { Voornaam = "Dirk", Achternaam = "Master", KlantNummer = 2, Postcode = "2900" };


            var klanten = new KlantenBestand();
            klanten.VoegToe(k1);
            klanten.VoegToe(k2);
            //klanten.VoegToe(k3);

            var queryString = "mas";
            var query = klanten.Zoek(queryString);
            Console.WriteLine($"Volgende resultaten werden gevonden met '{queryString}' in de naam.");
            foreach (var k in query)
            {
                Console.WriteLine($"{k.KlantNummer} {k.Achternaam} {k.Voornaam} {k.Postcode}");
            }
        }
    }
}
