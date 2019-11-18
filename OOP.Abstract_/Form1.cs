using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Abstract_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKeman_Click(object sender, EventArgs e)
        {
            Keman keman = new Keman();
            keman.Marka = "Stradivarius";
            keman.Aciklama = "Çok Pahalı";

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Hamza";
            muzisyen.Soyadi = "Kemansoy";
            muzisyen.Enstruman = keman;

            MessageBox.Show(keman.Cal());
        }

        private void BtnGitar_Click(object sender, EventArgs e)
        {
            Gitar gitar = new Gitar();
            gitar.Marka = "Fender";
            gitar.Aciklama = "Çok Pahalı";

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Hamza";
            muzisyen.Soyadi = "Gitarsoy";
            muzisyen.Enstruman = gitar;

            MessageBox.Show(gitar.Cal());
        }

        private void BtnBateri_Click(object sender, EventArgs e)
        {
            Bateri bateri = new Bateri();
            bateri.Marka = "Yamaha";
            bateri.Aciklama = "Çok Pahalı";

            Muzisyen muzisyen = new Muzisyen();
            muzisyen.Adi = "Hamza";
            muzisyen.Soyadi = "Baterisoy";
            muzisyen.Enstruman = bateri;
        }
    }
}
