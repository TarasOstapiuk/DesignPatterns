using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class WalkMovement : Movement
    {
        public override string Move()
        {
            return "Walk";
        }
    }
}
