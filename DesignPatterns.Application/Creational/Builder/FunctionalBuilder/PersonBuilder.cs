namespace DesignPatterns.Application.Creational.Builder.FunctionalBuilder
{
    public class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name)
          => Do(p => p.Name = name);

    }
}
