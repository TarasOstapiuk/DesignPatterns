using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory
{
    public class Warrior
    {
        private Weapon _weapon;
        private Movement _movement;

        public Warrior(WarriorFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public string Move()
        {
            return _movement.Move();
        }

        public string Hit()
        {
            return _weapon.Hit();
        }

        public string Act()
        {
            return Move() + " " + Hit();
        }
    }
}
