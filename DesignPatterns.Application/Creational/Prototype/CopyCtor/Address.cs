namespace DesignPatterns.Application.Creational.Prototype.CopyCtor
{
    public class Address
    {
        public string _street;
        public string _city;

        public Address(Address other)
        {
            _street = other._street;
            _city = other._city;
        }

        public Address(string street, string city)
        {
            _street = street;
            _city = city;
        }
    }
}
