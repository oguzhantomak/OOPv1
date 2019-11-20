using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface_
{
    public class Kaleci : IFutbolcu
    {
        public  string Adi { get; set; }
        public  string Soyadi { get; set; }
        public  string FormaNumarasi { get; set; }
        public  string Takim { get; set; }
        public  string Mevki { get; set; }
        public  bool MilliFutbolcu { get; set; }
        public  byte Agresiflik { get; set; }
        public decimal Fiyat { get; set; }

        public void Sutcek()
        {
            throw new NotImplementedException();
        }
    }
}
