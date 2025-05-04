namespace DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person) : base(person)
        {
        }

        public PersonJobBuilder AsA(string position)
        {
            _person.PositionAtWork = position;
            return this;
        }

        public PersonJobBuilder Earning(int salary)
        {
            _person.Salary = salary;
            return this;
        }

        public PersonJobBuilder At(string companyName)
        {
            _person.Company = companyName;
            return this;
        }
    }
}
