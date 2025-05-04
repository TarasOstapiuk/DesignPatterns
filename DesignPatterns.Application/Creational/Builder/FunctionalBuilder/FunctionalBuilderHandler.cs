namespace DesignPatterns.Application.Creational.Builder.FunctionalBuilder
{
    public class FunctionalBuilderHandler
    {
        public string Handle()
        {
            var person = new PersonBuilder()
              .Called("Tarasito")
              .WorksAsA("WebDev")
              .Build();

            return person.ToString();
        }
    }
}
