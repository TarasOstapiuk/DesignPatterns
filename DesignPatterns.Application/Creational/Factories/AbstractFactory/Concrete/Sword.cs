using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    class Sword : Weapon
    {
        public override string Hit()
        {
            return "Hit with sword";
        }
    }
}
