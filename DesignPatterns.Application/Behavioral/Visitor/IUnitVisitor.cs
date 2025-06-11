using DesignPatterns.Application.Behavioral.TemplateMethod;

namespace DesignPatterns.Application.Behavioral.Visitor
{
  public interface IUnitVisitor
  {
    string Visit( Artillery artillery );
    string Visit( MortarTeam mortarTeam );
  }
}
