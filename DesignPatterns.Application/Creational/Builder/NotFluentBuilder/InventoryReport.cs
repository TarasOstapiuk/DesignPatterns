using System.Text;

namespace DesignPatterns.Application.Creational.Builder.NotFluentBuilder
{
    public class InventoryReport
    {
        public string TitleSection { get; set; }
        public string DimensionsSection { get; set; }
        public string LogisticsSection { get; set; }

        public string CreateReport()
        {
            return string.Concat(TitleSection, DimensionsSection, LogisticsSection);
        }
    }
}
