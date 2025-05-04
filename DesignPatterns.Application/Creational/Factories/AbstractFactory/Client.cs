using DesignPatterns.Application.Creational.Factories.AbstractFactory;
using DesignPatterns.Application.Creational.Factories.AbstractFactory.Concrete;

namespace DesignPatterns.Application.Creational.Factories.AbstractFactory
{
    public class AbstractFactoryHandler
    {
        public string Handle()
        {
            var infantryman = new Warrior(new InfantryFactory());
            infantryman.Move();
            infantryman.Hit();

            var knight = new Warrior(new CavalryFactory());
            knight.Move();
            knight.Hit();

            var archer = new Warrior(new ArcherFactory());
            archer.Move();
            archer.Hit();

            return infantryman.Act() + " " + knight.Act() + " " + archer.Act();
        }
    }
}
