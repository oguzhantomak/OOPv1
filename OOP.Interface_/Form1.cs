using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Interface_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Forvet forvet = new Forvet()
        {
            Adi = "OĞUZHAN",
            Soyadi = "TOMAK",
            FormaNumarasi = "9",
            Agresiflik = 11,
            Takim = "FENERBAHÇE",
            MilliFutbolcu = true,
            Fiyat = 551,
            Mevki = "FORVET"
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //Forvet forvet = new Forvet();
            //forvet.Adi = "";

            Kaleci kaleci = new Kaleci()
            {
                Adi = "AHMET",
                Soyadi = "MEHMET",
                FormaNumarasi = "1",
                Agresiflik = 6,
                Takim = "FENERBAHÇE",
                MilliFutbolcu = false,
                Fiyat = 55,
                Mevki = "KALECİ",
                ElleTopKontrolu = 10
            };
        }


    }
}

