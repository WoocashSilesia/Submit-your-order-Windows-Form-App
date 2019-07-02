using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika
{
    public interface ISkladnik
    {
        int CzasProdukcji { get; }
        float Cena { get; }
    }
}
