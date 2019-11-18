using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Class_
{

    //- Eğer ben bir class'a erişim belirleyici(access modifier) belirtmezsem varsayılan olarak INTERNAL gelir.
    //- Internal: Bulunduğu assembly'nin(Dll veya exe dosyası) içinde erişime açık olan yapıdır.Dll veya exe dosyasının içerisinde erişim için kısıtlama yoktur, ama dışarıdan erişilemez.
    //- aynı zamanda class seviyesinde tanımlanan öğeler de (değişken, metot gibi) yine varsayılan olarak private erişim belirleyicisi ile tanımlanırlar.

    class FirstClass  // Personel, Kategori, Urun
    {
        //private -> Bir değerin private olarak tanımlanması demek, o değişkene sadece kendi class’ı içinden ulaşılabileceği anlamına gelmektedir. Program içinde kesinlikle değiştirilmemesi gereken, kritik kodlarda kullanılmaktadır.

        // Eğer, class içerisinde yer alan nesneye default olarak bir access modifier verilmezse, default değeri (private)

        //int Id;
        //string Ad;
        //string Soyad;
        //int Yas;
        //int Kilo;
        //int Boy;



        //public -> Bir değerin public olarak belirtilmesi; o değerin, kod içinde herhangi bir yerden erişilebilir durumda olmasını sağlamaktadır. Public erişim belirleyici tipinde hiç bir kısıtlama yoktur

        //public int Id;
        //public string Ad;
        //public string Soyad;

        //public int Kilo;
        //public int Boy;



        private int _yas;
        public int Yas
        {
            get
            {
                //return value
                return _yas;
            }
            set
            {
                if (value < 18 && value > 55)
                {
                    _yas = value;
                }
                else
                {
                    _yas = 0;
                }
            }
        }


        //public void Set(int yas)
        //{
        //    if (yas < 18 && yas > 55)
        //    {
        //        _yas = 0;
        //    }
        //    else
        //    {
        //        _yas = yas;
        //    } 
        //}

        //public int Get()
        //{
        //    return _yas;
        //}
        ////public int Yas;


        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }



        public string Test1 { get; }
        public string Test2 { get; private set; }
        public string Test3 { get; internal set; }
        public string Test4 { get; protected set; }

    }
}
