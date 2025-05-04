using DesignPatterns.Application.Creational.Factories.AbstractFactory;

namespace DesignPatterns.Application.Creational.Factories
{
    public class FactoryHandler
    {
        public string Handle()
        {
            var handler = new AbstractFactoryHandler();
            return handler.Handle();
        }
    }
}
