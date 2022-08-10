using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.ArabaConstructor
{
    public class ArabaMarkasi
    {
        public string markasi { get; set; }
        public int id { get; set; }

        public ArabaMarkasi()
        {

        }

        public ArabaMarkasi(string markasi)
        {
            this.markasi = markasi;
            //this.id = id;
        }
    }
}
