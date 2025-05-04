namespace DesignPatterns.Application.Creational.Builder.FunctionalBuilder
{
    public abstract class FunctionalBuilder<TSubject, TSelf>
      where TSelf : FunctionalBuilder<TSubject, TSelf>
      where TSubject : new()
    {
        public readonly List<Func<TSubject, TSubject>> Actions = new List<Func<TSubject, TSubject>>();

        public TSelf Do(Action<TSubject> action)
        {
            return AddAction(action);
        }

        public TSubject Build()
        {
            return Actions.Aggregate(
              new TSubject(),
              (p, f) => f(p)
              );
        }

        private TSelf AddAction(Action<TSubject> action)
        {
            Actions.Add(p =>
            {
                action(p);
                return p;
            });

            return (TSelf)this;
        }
    }
}
