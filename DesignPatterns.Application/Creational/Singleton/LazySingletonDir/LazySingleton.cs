using DesignPatterns.Application.Creational.Singleton;

namespace DesignPatterns.Application.Creational.Singleton.LazySingletonDir
{
    public class LazySingleton : IThreadSafeSingleton<LazySingleton>
    {
        private static Lazy<LazySingleton> _instance =
          new Lazy<LazySingleton>(() => new LazySingleton());

        public static int InstanceCount;
        private LazySingleton()
        {
            InstanceCount++;
        }

        public static LazySingleton GetInstance()
        {
            return _instance.Value;
        }
    }
}
