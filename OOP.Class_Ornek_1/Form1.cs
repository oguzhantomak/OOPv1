using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Class_Ornek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void Temizle(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Phone = txtPhone.Text;
            employee.Mail = txtMail.Text;

            lstItems.Items.Add(employee);
            Temizle(groupBox1);  // this

        }
        Employee emp;
        int index = 0;
        private void tsmDuzenle_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen Eleman Seçiniz!");
                return;
            }

            emp = (Employee)lstItems.SelectedItem;  // database üzerinden gelen data
            txtFirstName.Text = emp.FirstName;
            txtLastName.Text = emp.LastName;
            txtMail.Text = emp.Mail;
            txtPhone.Text = emp.Phone;

            index = lstItems.SelectedIndex;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int i = lstItems.SelectedIndex;

            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Mail = txtMail.Text;
            emp.Phone = txtPhone.Text;

            lstItems.Items.RemoveAt(index);
            lstItems.Items.Insert(index, emp);
            Temizle(groupBox1);
            emp = null;
        }

        private void tsmSil_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Lütfen Eleman Seçiniz!");
                return;
            }
            lstItems.Items.Remove(lstItems.SelectedItem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
 