using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.Odeme
{
    public class Cash:IOdeme
    {
        public string OdemeYap(int tutar)
        {
            return "Cash ile " + tutar + " kadar ödeme yapıldı." ;
        }
    }
}
