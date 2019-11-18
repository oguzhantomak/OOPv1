using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Enum_
{

    public enum Departman
    {
        Yazılım,Sistem,Grafik,Muhasebe,TeknikÇizim,Ofis
    }
    public class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Departman Departman { get; set; }

        public override string ToString()
        {
            //return $"{this.Adi} {this.Soyadi}";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(this.Adi);
            stringBuilder.Append(" ");
            stringBuilder.Append(this.Soyadi);
            stringBuilder.Append(" ");
            stringBuilder.Append(this.Departman);
            return stringBuilder.ToString();
        }
    }
}
