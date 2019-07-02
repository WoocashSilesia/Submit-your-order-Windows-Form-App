using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class Pizza : IProdukt
    {
        List<ISkladnik> Skladniki = new List<ISkladnik>();
        bool czyZamowiona = false;
        int Srednica;

        public float Cena
        {
            get
            {
                return 5 + Srednica * 2 + Skladniki.Sum(x=>x.Cena); // Cena w zależności od srednicy i ilosci skladników
            }
        }

        public int CzasProdukcji
        {
            get
            {
                return Srednica + Skladniki.Sum(x => x.CzasProdukcji); // czas produkcji w zalezności od srednicy i ilosci składników
            }
        }

        public bool CzyZamowiona
        {
            get
            {
                return czyZamowiona;
            }
        }

        public void Zamow()
        {
            czyZamowiona = true;
        }

        public void DodajSkladnik(ISkladnik skladnik)
        {
            if(!czyZamowiona) Skladniki.Add(skladnik);
        }

        public Pizza(int srednica)
        {
            this.Srednica = srednica;
        }
    }
}
