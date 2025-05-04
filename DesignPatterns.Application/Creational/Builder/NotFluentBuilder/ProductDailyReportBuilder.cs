using System.Linq;
using DesignPatterns.Application.Creational.Builder.NotFluentBuilder.Interfaces;

namespace DesignPatterns.Application.Creational.Builder.NotFluentBuilder
{
    public class ProductDailyReportBuilder : IProductReportBuilder
    {
        private InventoryReport _report;
        private List<DoorItem> _items;

        public ProductDailyReportBuilder(List<DoorItem> items)
        {
            Reset();
            _items = items;
        }

        public void AddTitle(string title)
        {
            _report.TitleSection = title;
        }

        public void AddDimentions()
        {
            _report.DimensionsSection = string.Join(
              Environment.NewLine,
              _items.Select(product =>
                $"Product:{product.Name} Price:{product.Price} Height:{product.Height} Weight:{product.Weight}"
               ));
        }
        public void AddLogistics(DateTime date)
        {
            _report.LogisticsSection = $"Report generated on {date}";
        }

        public InventoryReport GetDailyReport()
        {
            InventoryReport finishedReport = _report;
            Reset();

            return finishedReport;
        }

        public void Reset()
        {
            _report = new InventoryReport();
        }
    }
}
