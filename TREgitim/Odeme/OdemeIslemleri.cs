using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.Odeme
{
    public class OdemeIslemleri
    {
        public IOdeme odemetipi;

        public OdemeIslemleri(IOdeme odemetipi)
        {
            this.odemetipi = odemetipi;
        }

        public string OdemeYap(int tutar)
        {
           return odemetipi.OdemeYap(tutar);
        }
    }
}
