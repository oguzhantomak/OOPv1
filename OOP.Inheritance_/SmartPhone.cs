namespace OOP.Inheritance_
{
    public class SmartPhone : MobilPhone
    {
        public bool SecondCamera { get; set; }

        public SmartPhone()
        {
            base._phoneType = "Smart Phone";
        }

        public SmartPhone(bool secondCamera,
            bool hasCamera, bool isTouched, string brand, string connectionType)
            : base(hasCamera, isTouched, brand, connectionType)
        {
            this.SecondCamera = secondCamera;
            _phoneType = "Smart Phone";
        }

        public override string Sound()
        {
            return "Smartphone Sound";
        }
    }
}
