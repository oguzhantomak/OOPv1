using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Inheritance_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasePhone basePhone = new BasePhone("alcatel", "kablolu");

            BasePhone basePhone1 = new BasePhone();
            basePhone1.Brand = "Samsung";
            basePhone1.ConnectionType = "Kablolu";

            //MessageBox.Show(basePhone1.Sound());

            MobilPhone mobil = new MobilPhone(false, false, "nokia", "");
            //mobil.Brand = "Nokia";
            //mobil.ConnectionType = "Mobil";
            //mobil.HasCamere = false;
            //mobil.IsTouched = false;



            //MessageBox.Show(mobil.Sound());


            SmartPhone smartPhone = new SmartPhone(false, false, false, "nokia", "");


            MessageBox.Show("Smart : " + smartPhone.Brand + "\nMobil : " + mobil.Brand + "\nBase : " + basePhone.Brand);

        }
    }
}
