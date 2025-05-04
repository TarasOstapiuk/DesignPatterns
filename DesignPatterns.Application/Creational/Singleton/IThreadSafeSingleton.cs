namespace DesignPatterns.Application.Creational.Singleton
{
    public interface IThreadSafeSingleton<T>
      where T : class
    {
        static abstract T GetInstance();
    }
}
