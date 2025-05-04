using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class Spear : Weapon
    {
        public override string Hit()
        {
            return "Pierced with a spear";
        }
    }
}
