namespace DesignPatterns.Application.Structural.Decorator
{
  public class TransparentShape : Shape
  {
    private readonly Shape _shape;
    private readonly float _transparency;

    public TransparentShape( Shape shape, float transparency )
    {
      _shape = shape;
      _transparency = transparency;
    }

    public override string ToString() =>
      $"{_shape.ToString()} has {_transparency * 100.0f}% transparency";

    public override void ChangeSize( double multiplier )
    {
      _shape.ChangeSize( multiplier );
    }
  }
}
