using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TREgitim.ArabaConstructor
{
    public class Araba
    {
        public int kapi;
        public int pencere;
        public ArabaKasasi kasasi;
        public ArabaModeli modeli;
        public ArabaMarkasi markasi;

        public Araba()
        {

        }

        public Araba(int kapi, int pencere, ArabaKasasi kasasi, ArabaModeli modeli, ArabaMarkasi markasi)
        {
            this.kapi = kapi;
            this.pencere = pencere;
            this.kasasi = kasasi;
            this.modeli = modeli;
            this.markasi = markasi;
        }

        public string siparisYaz()
        {
            return "Arabanın markası: " + markasi.markasi + ", arabanın modeli: " + modeli.modeli + ", arabanın kasası: " + kasasi.kasatipi + ", arabanın kapı sayısı " + kapi + ", arabanın pencere sayısı " + pencere;
        }
    }
}
