namespace OOP.Inheritance_
{
    public class MobilPhone : BasePhone
    {
        public bool HasCamere { get; set; }
        public bool IsTouched { get; set; }

        public MobilPhone()
        {
            // * işareti protected olduğu anlamına gelir. Protected nesnelere sadece miras alan sınıflar üzerinden ulaşılabilir.
            _phoneType = "Mobil Phone";
        }

        public MobilPhone(bool hasCamera, bool isTouched, string brand, string connectionType)
            : base(brand, connectionType)
        {
            this.HasCamere = hasCamera;
            this.IsTouched = isTouched;
             
            //base.Brand = brand;
            //base.ConnectionType = connectionType;

            _phoneType = "Mobil Phone";
        }

        public string TakePhoto()
        {
            if (this.HasCamere)
            {
                return "You can take a photo";
            }
            else
            {
                return "git kamera taktır.";
            }
        }

        public override string Sound()
        {
            return "Mobil Telefon Sesi";
        } 
    }
}
