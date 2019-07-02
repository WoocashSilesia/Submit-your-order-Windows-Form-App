using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public class Ser : ISkladnik
    {
        public float Cena
        {
            get
            {
                return 4f;
            }
        }

        public int CzasProdukcji
        {
            get
            {
                return 4;
            }
        }
    }
}
