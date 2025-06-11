namespace DesignPatterns.Application.Behavioral.Iterator
{
  public class IteratorHandler
  {
    public string Handle()
    {
      var root = new Node<int>( 5, new Node<int>( 10 ), new Node<int>( 15 ) );
      var tree = new BinaryTree<int>( root );

      var threeItems = string.Join( ",", tree.GetAllItemsInOrder().Select( x => x.Value ) );

      return $"You moved throught all items in tree. Here they are {threeItems}";
    }
  }
}
