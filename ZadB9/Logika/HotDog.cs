using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class HotDog : IProdukt
    {
        bool CzyMusztarda;
        bool CzyKeczup;
        bool czyZamowione;

        public float Cena
        {
            get
            {
                int cena = 8; //Cena podstawowa
                if (CzyMusztarda) cena += 1;  //dodatek 1
                if (CzyKeczup) cena += 1; // dodatek 2
                return cena;
            }
        }

        public int CzasProdukcji
        {
            get
            {
                return 5;
            }
        }

        public bool CzyZamowiona
        {
            get
            {
                return czyZamowione;
            }
        }

        public void Zamow()
        {
            czyZamowione = true;
        }

        public HotDog(bool Keczup, bool Muszarda)
        {
            this.CzyKeczup = Keczup;
            this.CzyMusztarda = Muszarda;
            czyZamowione = false;
        }
    }
}
