using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;
using DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class InfantryFactory : WarriorFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
