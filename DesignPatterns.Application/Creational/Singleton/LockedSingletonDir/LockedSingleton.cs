using DesignPatterns.Application.Creational.Singleton;
using DesignPatterns.Application.Creational.Singleton.LazySingletonDir;

namespace DesignPatterns.Application.Creational.Singleton.LockedSingletonDir
{
    public class LockedSingleton : IThreadSafeSingleton<LockedSingleton>
    {
        private static LockedSingleton _instance;

        private static readonly object _lock = new object();

        public static LockedSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new LockedSingleton();
                    }
                }
            }

            return _instance;
        }
    }
}
