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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        [Flags]
        public enum Roles
        {
            Admin,
            User,
            Moderator,
            Ceo,
            LocalUser,
            Guest,
            MasterAdmin= LocalUser | Ceo | Admin // Tanımlanan rol.
        }
        public class Personel
        {
            public string FullName { get; set; }
            public Roles Roles { get; set; }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.FullName = "Oğuzhan Tomak";
            p.Roles = Roles.LocalUser | Roles.Ceo | Roles.Admin;
            //Kullanıcıya birden fazla rol atama böyle yapılır. Ama atama yapılınca listede olmayan bir enum numarası döner. bunun için kullanıcının rolü ne ise onun aynısına ait rolü enum içerisinde de tanımlıyoruz.

            var masterAdmin = Roles.LocalUser | Roles.Ceo | Roles.Admin;
            var result = masterAdmin.HasFlag(p.Roles);
            //result'ı masterAdmin.HasFlag p.Roles'deki değerlerden birine eşitse (masterAdmindeki bayrakla işaretlenmiş değerleri result'a eşitle)
            MessageBox.Show(result? "Master Admindir": "Master Admin değildir");

            if (Enum.IsDefined(typeof(Roles),p.Roles))
            {
                MessageBox.Show("Kullanıcının Rolü: "+p.Roles.ToString());
            }
            else
            {
                MessageBox.Show("Kullanıcının yetkisi yok !");
            }

            MessageBox.Show(((Roles)p.Roles).ToString());

        }
    }
}
