namespace DesignPatterns.Application.Structural.Proxy
{
  public class Target
  {
    public string Name { get; set; }
    public int ImportanceLevel { get; set; }

    public bool IsScouted { get; set; }
    public Target(string name ) 
    {
      Name = name;
    }

    public bool IsWorthFire( int shellsCount )
    {
      if ((ImportanceLevel == 3 && shellsCount > 100)
        || (ImportanceLevel == 2 && shellsCount > 50)
        || (ImportanceLevel == 1 && shellsCount > 0))
      {
        return true;
      }
      return false;
    }
  }
}
