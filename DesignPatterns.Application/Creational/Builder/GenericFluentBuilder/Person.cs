using DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder;

namespace DesignPatterns.Application.Creational.Builder.GenericFluentBuilder
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public class Builder : PersonJobBuilder<Builder>
        {
        }
        public static Builder New => new Builder();

        public override string ToString()
        {
            return Name + " " + Position;
        }
    }
}
