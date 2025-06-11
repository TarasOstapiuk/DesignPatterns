namespace DesignPatterns.Application.Structural.Decorator
{
  public class DecoratorHandler
  {
    public string Handle()
    {
      var circle = new Circle( 30 );
      var blueCircle = new ColoredShape( circle, "blue" );

      var blueTransparentSquare = new TransparentShape( blueCircle, 0.7f );
      var result = blueTransparentSquare.ToString();

      return result;
    }
  }
}
