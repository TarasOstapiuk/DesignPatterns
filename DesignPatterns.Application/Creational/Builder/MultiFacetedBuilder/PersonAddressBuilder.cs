namespace DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
          : base(person)
        {
        }

        public PersonAddressBuilder At(string streetName)
        {
            _person.Street = streetName;
            return this;
        }

        public PersonAddressBuilder WithZipCode(string zipCode)
        {
            _person.ZipCode = zipCode;
            return this;
        }
        public PersonAddressBuilder In(string city)
        {
            _person.City = city;
            return this;
        }
    }
}
