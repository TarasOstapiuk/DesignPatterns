using DesignPatterns.Application.Creational.Singleton.LazySingletonDir;
using DesignPatterns.Application.Creational.Singleton.LockedSingletonDir;
using DesignPatterns.Application.Creational.Singleton.Monostate;
using DesignPatterns.Application.Creational.Singleton.Multitone;

namespace DesignPatterns.Application.Creational.Singleton
{
  public class SingletonHandler
  {
    public string Handle( string realization )
    {
      var realizationToLower = realization.ToLower();
      return realizationToLower switch
      {
        "lazysingleton" => HandleSingleton<LazySingleton>(),
        "lockedsingleton" => HandleSingleton<LockedSingleton>(),
        "multitone" => new MultiToneHandler().Handle(),
        "monostate" => new MonoStateHandler().Handle(),
        _ => throw new Exception( "Not found" )
      };
    }

    public string HandleLazySingleton() => HandleSingleton<LazySingleton>();

    public string HandleLockedSingleton() => HandleSingleton<LockedSingleton>();


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
