using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TREgitim.ArabaConstructor;

namespace TREgitim
{
    public partial class ArabaKayitFormu : Form
    {
        public ArabaKayitFormu()
        {
            InitializeComponent();
        }

        private void ArabaKayitFormu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Araba yeni = new Araba();
            label6.Text = yeni.siparisYaz();
        }
    }
}
