using static System.Net.Mime.MediaTypeNames;

namespace DesignPatterns.Application.Behavioral.Chains
{
  public class CarServiceBase
  {
    public static CarServiceBase Create()
    {
      return new CarServiceBase();
    }
    public CarServiceBase Next { get; set; }

    public CarServiceBase AddChain( CarServiceBase carService )
    {
      if (Next != null)
      {
        Next.AddChain( carService );
      }
      else
      {
        Next = carService;
      }

      return this;
    }

    public virtual void Serve(Car car) => Next?.Serve(car);
  }
}
