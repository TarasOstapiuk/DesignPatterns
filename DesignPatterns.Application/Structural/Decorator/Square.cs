namespace DesignPatterns.Application.Structural.Decorator
{
  public sealed class Square : Shape
  {
    private double _side;

    public Square( double side )
    {
      _side = side;
    }

    public override string ToString() => $"A square with side {_side}";

    public override void ChangeSize( double multiplier )
    {
      _side = _side * multiplier;
    }
  }

}
