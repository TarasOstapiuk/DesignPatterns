namespace DesignPatterns.Application.Creational.Builder.FunctionalBuilder
{
    public class Person
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return Name + " " + Position;
        }
    }
}
