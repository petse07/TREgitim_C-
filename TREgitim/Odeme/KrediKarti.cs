using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.Odeme
{
    public class KrediKarti : IOdeme
    {
        public string OdemeYap(int tutar)
        {
            return "Kredi kartı ile " + tutar + " kadar ödeme yapıldı." ;
        }
    }
}
