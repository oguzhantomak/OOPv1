using System;
using System.Windows.Forms;

namespace OOP.Class_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  yeni bir örnek alma (instance) 
            FirstClass fc1 = new FirstClass();
            fc1.Adi = "Murat";
            fc1.Yas = 20;
             
            //fc1.Test1 = "Bilge Adam";
            //fc1.Test2 = "Bilge Adam";
        }
    }
}


