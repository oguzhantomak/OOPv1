namespace OOP.Class_Ornek_1
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
         
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
