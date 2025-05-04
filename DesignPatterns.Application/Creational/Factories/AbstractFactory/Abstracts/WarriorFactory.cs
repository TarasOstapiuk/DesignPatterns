namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts
{
    public abstract class WarriorFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
