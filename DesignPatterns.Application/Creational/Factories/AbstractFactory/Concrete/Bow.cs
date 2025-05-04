using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class Bow : Weapon
    {
        public override string Hit()
        {
            return "Fired with arrow";
        }
    }
}
