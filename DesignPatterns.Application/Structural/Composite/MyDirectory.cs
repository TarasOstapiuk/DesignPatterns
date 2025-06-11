using System.Text;

namespace DesignPatterns.Application.Structural.Composite
{
  class MyDirectory : MyComponent
  {
    private List<MyComponent> _components = new List<MyComponent>();

    public MyDirectory( string name )
        : base( name )
    {
    }

    public override void Add( MyComponent component )
    {
      _components.Add( component );
    }

    public override void Remove( MyComponent component )
    {
      _components.Remove( component );
    }

    public override string Print()
    {
      var sb = new StringBuilder()
        .Append( "Node: " )
        .Append( name )
        .Append( ". " )
        .Append( "Subnodes: " );

      for (int i = 0; i < _components.Count; i++)
      {
        sb.Append( _components[i].Print() );
      }

      return sb.ToString();
    }
  }
}
