using DesignPatterns.Application.Creational.Factories.AbstractFactory.Abstracts;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete
{
    public class HorseRideMovement : Movement
    {
        public override string Move()
        {
            return "Ride a hourse";
        }
    }
}
