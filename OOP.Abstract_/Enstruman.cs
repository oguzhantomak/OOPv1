using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstract_
{
    public abstract class Enstruman
    {
        public string Marka { get; set; }
        public string Aciklama { get; set; }

        string ses1;
        public abstract string Cal();
    }

    public class Muzisyen
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public Enstruman Enstruman { get; set; }
    }

    

    public class Keman:Enstruman
    {
        public override string Cal()
        {
            return "Keman Sesi";
        }
    }
    public class Bateri : Enstruman
    {

        public override string Cal()
        {
            return "Bateri Sesi";
        }
    }
        public class Gitar:Enstruman {

        public override string Cal()
        {
            return "Gitar Sesi";
        }

    }
}
