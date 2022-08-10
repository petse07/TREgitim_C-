using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.ArabaConstructor
{
    public class ArabaKasasi
    {
        public string kasatipi { get; set; }
        public int id { get; set; }

        public ArabaKasasi()
        {

        }

        public ArabaKasasi(string kasatipi)
        {
            this.kasatipi = kasatipi;
        }
    }
}
