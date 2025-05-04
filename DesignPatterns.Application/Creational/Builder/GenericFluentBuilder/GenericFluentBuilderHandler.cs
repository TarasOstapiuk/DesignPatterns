namespace DesignPatterns.Application.Creational.Builder.GenericFluentBuilder
{
    public class GenericFluentBuilderHandler
    {
        public string Handle()
        {
            var me = Person.New
              .Called("Tarasito")
              .WorksAs("WebDev")
              .Build();

            return me.ToString();
        }
    }
}
