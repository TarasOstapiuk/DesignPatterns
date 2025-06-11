namespace DesignPatterns.Application.Structural.Decorator
{
  public sealed class Circle : Shape
  {
    private double radius;

    public Circle( double radius )
    {
      this.radius = radius;
    }

    public override void ChangeSize( double multiplier )
    {
      radius *= multiplier;
    }

    public override string ToString() => $"Circle of radius {radius}";
  }
}
