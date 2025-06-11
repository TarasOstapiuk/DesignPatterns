namespace DesignPatterns.Application.Structural.Composite
{
  abstract class MyComponent
  {
    protected string name;

    public MyComponent( string name )
    {
      this.name = name;
    }

    public virtual void Add( MyComponent component ) { }

    public virtual void Remove( MyComponent component ) { }

    public virtual string Print()
    {
      return name;
    }
  }
}
