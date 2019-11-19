using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Enum_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public enum Sehirler
        {
            Ankara = 2,
            Edirne = 22,
            İstanbul = 34,
            Eskişehir = 26,
            Adana = 1,
            Gaziantep
        }

        public enum Cities : byte
        {
            Ankara, Edirne, İstanbul, Eskişehir, Adana, Gazianetp
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //string enumMetni = Sehirler.Adana.ToString();
            //MessageBox.Show(enumMetni);
            /////// Sonuç Adana çıktısıdır.

            //int enumDegeri = (int)Sehirler.Adana;
            /////// Cast etmemiz gerekiyor.

            //MessageBox.Show(enumDegeri.ToString());

            //byte citiesValue = (byte)Cities.Adana;
            //MessageBox.Show(citiesValue.ToString());


            int enumDegeri = 22;
            //Sehirler sehir = (Sehirler)enumDegeri;
            //MessageBox.Show(sehir.ToString());

            //Eğer enum değeri listede var ise şehrin ismini, yok ise verilen enumDegeri ni yazar !

            if (Enum.IsDefined(typeof(Sehirler), enumDegeri))
            {
                MessageBox.Show("Enum değeri yer almaktadır");
            }
            else
            {
                MessageBox.Show("Enum Değeri yer almamaktadır");
            }

            if (Enum.IsDefined(typeof(Sehirler), "Edirne"))
            {
                MessageBox.Show("Enum değeri yer almaktadır");
            }
            else
            {
                MessageBox.Show("Enum Değeri yer almamaktadır");
            }
        }
    }
}
