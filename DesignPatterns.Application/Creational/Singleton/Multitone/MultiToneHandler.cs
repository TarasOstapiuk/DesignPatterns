namespace DesignPatterns.Application.Creational.Singleton.Multitone
{
  public class MultiToneHandler
  {
    public string Handle()
    {
      var person1 = MultiTonePerson.GetPerson( GenderEnum.Male );
      var person2 = MultiTonePerson.GetPerson( GenderEnum.Female );
      var person3 = MultiTonePerson.GetPerson( GenderEnum.Male );

      return ReferenceEquals( person1, person3 )
        ? $"MultiTone created same instance"
        : $"MultiTone created different instances";
    }
  }
}
