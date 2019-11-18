using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Struct_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap kitap;
        private void BtnClass_Click(object sender, EventArgs e)
        {
            kitap = new Kitap();
            kitap.Id = 1;
            kitap.ISBNNo = "223213";
            kitap.KitapAdi = "Fakirler";
            kitap.YazarAdi = "Züğürt Ağa";
            kitap.Tur = "Yokluk";

            Kitap k = new Kitap();
        }
        Book book;
        private void BtnStruct_Click(object sender, EventArgs e)
        {
            book = new Book();
            book.Id = 1;
            book.ISBNNo = "24324324";
            book.KitapAdi = "Züğürtler";
            book.YazarAdi = "Gariban Ağa";
            book.Tur = "görgüsüzlük";
        }
    }
}
