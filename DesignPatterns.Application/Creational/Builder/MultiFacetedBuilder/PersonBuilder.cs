namespace DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder
{
    public class PersonBuilder
    {
        protected Person _person;

        public PersonBuilder()
        {
            _person = new Person();
        }

        public PersonBuilder(Person person)
        {
            _person = person;
        }

        public PersonAddressBuilder Lives => new PersonAddressBuilder(_person);

        public PersonJobBuilder Works => new PersonJobBuilder(_person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb._person;
        }
    }
}
