using DesignPatterns.Application.Creational.Builder.NotFluentBuilder.Interfaces;

namespace DesignPatterns.Application.Creational.Builder.NotFluentBuilder
{
    public class InventoryBuildManager
    {
        private IProductReportBuilder _builder;

        public InventoryBuildManager(IProductReportBuilder builder)
        {
            _builder = builder;
        }

        public void BuildCompleteReport()
        {
            _builder.AddTitle("---Super Title---");
            _builder.AddDimentions();
            _builder.AddLogistics(DateTime.UtcNow);
        }
    }
}
