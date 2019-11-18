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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.Adi = textBox1.Text;
            personel.Soyadi = textBox2.Text;
            personel.Departman = (Departman)Enum.Parse(typeof(Departman),comboBox1.Text);

            MessageBox.Show($@"Personel Adı : {personel.Adi}
Personel soyadı : {personel.Soyadi}
Personel Departman: {personel.Departman}");

            listBox1.Items.Add(personel);
            textBox1.Text = textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Departman)));
        }
    }
}
