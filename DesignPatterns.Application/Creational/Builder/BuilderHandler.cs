using DesignPatterns.Application.Creational.Builder.AutoFixtureBuilder;
using DesignPatterns.Application.Creational.Builder.GenericFluentBuilder;
using DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder;
using DesignPatterns.Application.Creational.Builder.NotFluentBuilder;

namespace DesignPatterns.Application.Creational.Builder
{
  public class BuilderHandler
  {
    public string HandlerNonFluentBuilder()
    {
      var result = new NotFluentBuilderHandler().Handle();
      return result;
    }

    public string HandleAutoFixtureCreation()
    {
      var result = new HandlerAutoFixture().HandleFixtureCreating();
      return result;
    }

    public string HandleAutoFixtureBuilding()
    {
      var result = new HandlerAutoFixture().HandleFixtureBuilding();
      return result;
    }

    public string HandleMultiBuilder()
    {
      var result = new HandlerMultiFacetedBuilder().Handle();
      return result;
    }

    public string GenericFluentBuilderHandler()
    {
      var result = new GenericFluentBuilderHandler().Handle();
      return result;
    }
  }
}
