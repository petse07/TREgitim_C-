using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.Odeme
{
    public class MailOrder: IOdeme
    {
        public string OdemeYap(int tutar)
        {
            return "Mail Order ile " + tutar + " kadar ödeme yapıldı." ;
        }
    }
}
