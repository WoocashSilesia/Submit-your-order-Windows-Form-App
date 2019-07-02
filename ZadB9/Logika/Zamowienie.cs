using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class Zamowienie
    {
        List<IProdukt> Produkty = new List<IProdukt>();
        public bool CzyZamowione { get; private set; }

        public float Cena
        {
            get
            {
                float cena = 0;
                foreach (IProdukt p in Produkty)
                    cena += p.Cena;
                return cena;
            }
        }

        public int CzasProdukcji
        {
            get
            {
                return Produkty.Sum(x => x.CzasProdukcji);
            }
        }

        public void Zamow()
        {
            foreach (IProdukt p in Produkty) p.Zamow();
            CzyZamowione = true;
        }

        public void DodajProdukt(IProdukt produkt)
        {
            Produkty.Add(produkt);
        }
    }
}
