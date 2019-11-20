using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface_
{
    public interface IFutbolcu
    {
        string Adi { get; set; }
        string Soyadi { get; set; }
        string FormaNumarasi { get; set; }
        string Takim { get; set; }
        string Mevki { get; set; }
        bool MilliFutbolcu { get; set; }
        byte Agresiflik { get; set; }
        decimal Fiyat { get; set; }
        byte TopHakimiyeti { get; set; }

        void Sutcek();

    }
}
