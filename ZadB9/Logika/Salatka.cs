using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class Salatka : IProdukt
    {
        public enum TypSalatki { ZPomidorem, ZKurczakiem, ZSerem };
        TypSalatki rodzaj;
        bool czyZamowiona;

        public float Cena
        {
            get
            {
                switch(rodzaj)
                {
                    case TypSalatki.ZKurczakiem: return 5f;
                    case TypSalatki.ZPomidorem: return 3f;
                    case TypSalatki.ZSerem: return 7f;
                    default: return 0f;
                }
            }
        }

        public int CzasProdukcji
        {
            get
            {
                switch (rodzaj)
                {
                    case TypSalatki.ZKurczakiem: return 5;
                    case TypSalatki.ZPomidorem: return 4;
                    case TypSalatki.ZSerem: return 6;
                    default: return 0;
                }
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

        public Salatka(TypSalatki typ)
        {
            this.rodzaj = typ;
        }
    }
}
