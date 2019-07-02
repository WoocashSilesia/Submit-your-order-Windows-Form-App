using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class Pomidor : ISkladnik
    {
        public float Cena
        {
            get
            {
                return 1f;
            }
        }

        public int CzasProdukcji
        {
            get
            {
                return 2;
            }
        }
    }
}
