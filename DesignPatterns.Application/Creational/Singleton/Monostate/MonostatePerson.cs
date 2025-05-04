namespace DesignPatterns.Application.Creational.Singleton.Monostate
{
    public class MonostatePerson
    {
        private static string _name;
        private static int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public override string ToString() => $"Person {nameof(Name)}: {Name} with {nameof(Age)}: {Age}";
    }
}
