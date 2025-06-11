namespace DesignPatterns.Application.Structural.Decorator
{
  public class ColoredShape : Shape
  {
    private readonly Shape _shape;
    private readonly string _color;

    public ColoredShape( Shape shape, string color )
    {
      _shape = shape;
      _color = color;
    }

    public override string ToString() => $"{_shape.ToString()} has the color {_color}";

    public override void ChangeSize( double multiplier )
    {
      _shape.ChangeSize( multiplier );
    }
  }

}
