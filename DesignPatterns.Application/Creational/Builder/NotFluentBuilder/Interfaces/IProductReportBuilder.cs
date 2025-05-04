using DesignPatterns.Application.Creational.Builder.NotFluentBuilder;

namespace DesignPatterns.Application.Creational.Builder.NotFluentBuilder.Interfaces
{
    public interface IProductReportBuilder
    {
        void AddTitle(string title);
        void AddDimentions();
        void AddLogistics(DateTime date);

        InventoryReport GetDailyReport();
    }
}
