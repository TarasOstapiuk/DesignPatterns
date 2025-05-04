namespace DesignPatterns.Application.Creational.Builder.GenericFluentBuilder
{
    public class PersonJobBuilder<TBuilder>
    : PersonInfoBuilder<TBuilder>
    where TBuilder : PersonJobBuilder<TBuilder>
    {
        public TBuilder WorksAs(string position)
        {
            person.Position = position;
            return (TBuilder)this;
        }
    }
}
