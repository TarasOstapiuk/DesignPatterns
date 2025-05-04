using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;
using DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class CavalryFactory : WarriorFactory
    {
        public override Movement CreateMovement()
        {
            return new HorseRideMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Spear();
        }
    }
}
