using DesignPatterns.Application.Creational.Builder.AutoFixtureBuilder;
using DesignPatterns.Application.Creational.Builder.GenericFluentBuilder;
using DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder;
using DesignPatterns.Application.Creational.Builder.NotFluentBuilder;

namespace DesignPatterns.Application.Creational.Builder
{
  public class BuilderHandler
  {
    public string Handle( string realization )
    {
      var realizationLowerCase = realization.ToLowerInvariant();
      return realizationLowerCase switch
      {
        "nonfluentbuilder" => new NotFluentBuilderHandler().Handle(),
        "autofixturecreation" => new HandlerAutoFixture().HandleFixtureCreating(),
        "autofixturebuilding" => new HandlerAutoFixture().HandleFixtureBuilding(),
        "automultifacetedbuilder" => new HandlerMultiFacetedBuilder().Handle(),
        "genericfluentbuilder" => new GenericFluentBuilderHandler().Handle(),
        _ => throw new Exception( "Not found" )
      };
    }
  }
}
