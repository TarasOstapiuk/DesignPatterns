namespace DesignPatterns.Application.Creational.Singleton.Monostate
{
  public class MonoStateHandler
  {
    public string Handle()
    {
      var person = new MonostatePerson();
      person.Name = "Tarasito";
      person.Age = 18;

      var person2 = new MonostatePerson();
      return person2.ToString();
    }
  }
}
