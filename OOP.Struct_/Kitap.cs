using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Struct_
{
    public class Kitap
    {

        public Kitap()
        {

        }

        public Kitap(string kitapAdi)
        {
            this.KitapAdi = kitapAdi;
        }

        public Kitap(string kitapAdi, string yazarAdi): this(kitapAdi)
        {
            this.YazarAdi = yazarAdi;
        }

        public Kitap(string kitapAdi, string yazarAdi, string isbnno):this(kitapAdi,yazarAdi)
        {
            this.ISBNNo = isbnno;
        }

        public Kitap(string kitapAdi, string yazarAdi, string isbnno, string tur) : this(kitapAdi, yazarAdi, isbnno)
        {
            this.Tur = tur;
        }


        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string ISBNNo { get; set; }
        public string Tur { get; set; }

    }

    public struct Book
    {
        public Book(string kitapAdi, string yazarAdi, string isbnno, string tur)
        {
            this.Id = 0;
            this.KitapAdi = kitapAdi;
            this.YazarAdi = yazarAdi;
            this.ISBNNo = isbnno;
            this.Tur = tur;

        }
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string ISBNNo { get; set; }
        public string Tur { get; set; }

    }
}
