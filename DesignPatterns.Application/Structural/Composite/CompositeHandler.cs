using System.ComponentModel;

namespace DesignPatterns.Application.Structural.Composite
{
  public  class CompositeHandler
  {
    public string Handle()
    {
      var fileSystem = new MyDirectory( "File system" );
      var diskC = new MyDirectory( "Disk C" );

      var pngFile = new MyFile( "qwerty.png" );
      var docxFile = new MyFile( "doc.doc" );

      diskC.Add( pngFile );
      diskC.Add( docxFile );

      fileSystem.Add( diskC );
      var result = fileSystem.Print();

      return result;
    }
  }
}
