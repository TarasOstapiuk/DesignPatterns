namespace DesignPatterns.Application.Creational.Builder.GenericFluentBuilder
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}
