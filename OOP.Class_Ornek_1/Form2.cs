using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace OOP.Class_Ornek_1
{
    public partial class Form2 : MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tsmDuzenle_Click(object sender, EventArgs e)
        {
            if (lstKitaplar.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Lütfen Bir Kitap Seçiniz", "Kayıt Düzenleme Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            //MetroMessageBox.Show(this, "Kayıt Başarıyla Eklendi", "Kayıt Ekleme Bildirimi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text))
            {
                errorProvider1.SetError(txtKitapAdi, "Kitap Adı Boş Geçilemez");
            } 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbTur.Items.Add("Hikaye");
        }
    }
}
