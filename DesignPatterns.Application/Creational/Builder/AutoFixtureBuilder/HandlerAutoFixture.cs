namespace DesignPatterns.Application.Creational.Builder.AutoFixtureBuilder
{
    public class HandlerAutoFixture
    {
        private readonly MyFixture _fixture;
        public HandlerAutoFixture()
        {
            _fixture = new MyFixture();
        }
        public string HandleFixtureCreating()
        {
            var person = _fixture.Create<Person>();

            return $"Person created with name {person.Name} and address {person.Address.GetAddress}";
        }

        public string HandleFixtureBuilding()
        {
            var person = _fixture.Build<Person>()
              .With(x => x.Name, "Tarasito")
              .With(x => x.Age, 18)
              .Without(x => x.Address)
              .Create();

            return $"Person build with name {person.Name} and age {person.Age}";
        }
    }
}