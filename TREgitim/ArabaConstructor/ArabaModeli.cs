using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.ArabaConstructor
{
    public class ArabaModeli
    {
        public string modeli { get; set; }
        public int id { get; set; }



        public ArabaModeli()
        {

        }

        public ArabaModeli(string modeli)
        {
            this.modeli = modeli;
        }
    }
}
