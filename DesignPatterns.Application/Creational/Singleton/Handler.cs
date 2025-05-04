using DesignPatterns.Application.Creational.Singleton.LazySingletonDir;
using DesignPatterns.Application.Creational.Singleton.LockedSingletonDir;
using DesignPatterns.Application.Creational.Singleton.Monostate;
using DesignPatterns.Application.Creational.Singleton.Multitone;

namespace DesignPatterns.Application.Creational.Singleton
{
  public class SingletonHandler
  {
    public string HandleLazySingleton() => HandleSingleton<LazySingleton>();

    public string HandleLockedSingleton() => HandleSingleton<LockedSingleton>();

    public string HandleMonoState()
    {
      var person = new MonostatePerson();
      person.Name = "Tarasito";
      person.Age = 18;

      var person2 = new MonostatePerson();
      return person2.ToString();
    }

    public string HandleMultiTone()
    {
      var person1 = MultiTonePerson.GetPerson( GenderEnum.Male );
      var person2 = MultiTonePerson.GetPerson( GenderEnum.Female );
      var person3 = MultiTonePerson.GetPerson( GenderEnum.Male );

      return ReferenceEquals( person1, person3 )
        ? $"MultiTone created same instance"
        : $"MultiTone created different instances";
    }

    private string HandleSingleton<TSingleton>()
      where TSingleton : class, IThreadSafeSingleton<TSingleton>
    {
      TSingleton instance1 = null;
      TSingleton instance2 = null;

      var process1 = new Thread( () =>
      {
        instance1 = TSingleton.GetInstance();
      } );
      var process2 = new Thread( () =>
      {
        instance2 = TSingleton.GetInstance();
      } );

      process1.Start();
      process2.Start();

      process1.Join();
      process2.Join();

      return ReferenceEquals( instance1, instance2 )
        ? $"{typeof( TSingleton ).Name} created same instance"
        : $"{typeof( TSingleton ).Name} created different instances";
    }
  }
}
