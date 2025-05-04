namespace DesignPatterns.Application.Creational.Builder.GenericFluentBuilder
{
    public class PersonInfoBuilder<TBuilder> : PersonBuilder
    where TBuilder : PersonInfoBuilder<TBuilder>
    {
        public TBuilder Called(string name)
        {
            person.Name = name;
            return (TBuilder)this;
        }
    }
}
