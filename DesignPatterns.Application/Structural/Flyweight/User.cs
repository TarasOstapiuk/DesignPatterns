namespace DesignPatterns.Application.Structural.Flyweight
{
  public class User
  {
    private static List<string> stringsStorage = new ();
    private int[] names;
    private static int allStringsHeavyWeightCount;

    public static int AllStringsHeavyWeightCount => allStringsHeavyWeightCount;
    public static int AllStringsFlyWeightCount => stringsStorage.Count;
    public string FullName => string.Join( " ", names.Select( i => stringsStorage[i] ) );
    public User( string fullName )
    {
      names = fullName.Split( ' ' ).Select( GetOrAdd ).ToArray();
    }

    private int GetOrAdd( string s )
    {
      allStringsHeavyWeightCount++;
      int index = stringsStorage.IndexOf( s );
      if (index != -1)
      {
        return index;
      }
      else
      {
        stringsStorage.Add( s );
        return stringsStorage.Count - 1;
      }
    }
  }
}
