using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;
using DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class ArcherFactory : WarriorFactory
    {
        public override Movement CreateMovement()
        {
            return new WalkMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Bow();
        }
    }
}
