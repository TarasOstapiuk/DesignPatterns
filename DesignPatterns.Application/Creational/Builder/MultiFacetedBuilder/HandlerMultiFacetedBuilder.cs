using DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder;

namespace DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder
{
    public class HandlerMultiFacetedBuilder
    {
        public string Handle()
        {
            var personBuilder = new PersonBuilder();
            Person person = personBuilder
              .Lives
                .At("Sambirska")
                .In("Drohobych")
                .WithZipCode("82100")
              .Works
                .At("Eleks")
                .AsA("WebDev")
                .Earning(100); ;

            return person.ToString();
        }
    }
}
