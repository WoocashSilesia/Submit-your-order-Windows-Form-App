using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public interface IProdukt
    {
        float Cena { get; }
        int CzasProdukcji { get; }
        bool CzyZamowiona { get; }

        void Zamow();

    }
}
