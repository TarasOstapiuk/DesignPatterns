namespace DesignPatterns.Application.Behavioral.Iterator
{
  public class BinaryTree<T>
  {
    private Node<T> _root;

    public BinaryTree( Node<T> root )
    {
      _root = root;
    }

    public IEnumerable<Node<T>> GetAllItemsInOrder()
    {
      foreach (var node in MoveInOrder( _root ))
      {
        yield return node;
      }
    }

    private IEnumerable<Node<T>> MoveInOrder( Node<T> current )
    {
      if (current.Left != null)
      {
        foreach (var left in MoveInOrder( current.Left ))
        {
          yield return left;
        }
      }
      yield return current;
      if (current.Right != null)
      {
        foreach (var right in MoveInOrder( current.Right ))
        {
          yield return right;
        }
      }
    }
}
}
