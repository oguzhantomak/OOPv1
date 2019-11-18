namespace OOP.Inheritance_
{
    public class BasePhone
    {
        private string _brand;
        protected string _phoneType;
        protected string _connectionType;

        public BasePhone()
        {
            this._phoneType = "Ahizeli Telefon";
        }

        /// <summary>
        /// BasePhone Oluşturmak için kullanabilirsiniz
        /// </summary>
        /// <param name="brand">Telefon markası</param>
        /// <param name="connectionType">Telefon bağlantı türü</param>
        public BasePhone(string brand, string connectionType)
        {
            this._brand = brand.ToUpper();
            this._connectionType = connectionType;
            this._phoneType = "Ahizeli Telefon";
        }

        /// <summary>
        /// Telefon için bir marka belirleyiniz.
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { this._brand = value; }
        }

        /// <summary>
        /// Telefonun bağlantı türünü düzenleyiniz.
        /// </summary>
        public string ConnectionType
        {
            get { return _connectionType; }
            set { this._connectionType = value; }
        }

        /// <summary>
        /// Telefon çaldığında default olarak tanımlanan zil sesi teslim eder
        /// </summary>
        /// <returns></returns>
        public virtual string Sound()
        {
            // virtual anahtar kelimesi ovveride edilebilir demektir(ezilebilir)
            return "Klasik Telefon Sesi";
        }

        /// <summary>
        /// Telefonun o anki bağlantı türünü teslim eder.
        /// </summary>
        /// <returns></returns>
        public string ConnectionStatus()
        {
            return "Kablolu bağlantı mevcut";
        }
    }
}


// SmartPhone : MobilPhone   (2 constructor) ve sound metodu yeniden düzenlenecek sınıf içerisinde
// SecondCamera bool