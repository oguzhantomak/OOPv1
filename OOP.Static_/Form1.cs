using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Static_
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FizikKutuphanesi fk = new FizikKutuphanesi();
            //double pi = fk.PI;


            //FizikKutuphanesi fk1 = new FizikKutuphanesi();
            //double pi1 = fk.PI;


            //FizikKutuphanesi fk2 = new FizikKutuphanesi();
            //double pi2 = fk.PI;

            FizikKutuphanesi.PI = 1234;
            double pi = FizikKutuphanesi.PI;


            FizikKutuphanesi fk = new FizikKutuphanesi();
            string _readonly = fk.Connection;
            string _connection = FizikKutuphanesi.ConnectionString;

            bool result = FizikKutuphanesi.Sale(1);
            MessageBox.Show("Satış işlemi başarı" + (result ? "lı" : "sız"));

            //Kutuphane kutuphane = new Kutuphane();
            //kutuphane.Clear();

            Kutuphane.Clear();
        }
    }
}



// Aralık 23-24-25-26 => eğitimdeyim (belirsiz)
// Aralık 30-31-(01)-02 => UIPath
// Ders sonlarında bitirelim :) 