using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class RunMovement : Movement
    {
        public override string Move()
        {
            return "Infantry run";
        }
    }
}
