using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest7Klant
{
    class KlantenBestand
    {
        private List<Klant> klanten = new List<Klant>();

        public void VoegToe(Klant k)
        {
            klanten.Add(k);
        }

        public List<Klant> Zoek(string naamfragement)
        {
            List<Klant> GezochteKlanten = new List<Klant>();
                        
                foreach (var klant in klanten)
                {
                    if (klant.Achternaam.ToLower().Contains(naamfragement) || klant.Voornaam.ToLower().Contains(naamfragement))
                        {
                            GezochteKlanten.Add(klant);
                        }
                }
                return GezochteKlanten;
            
        }
    }
}
