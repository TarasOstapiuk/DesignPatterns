using DesignPatterns.Application.Creational.Builder.NotFluentBuilder;

namespace DesignPatterns.Application.Creational.Builder.NotFluentBuilder
{
    public class NotFluentBuilderHandler
    {
        public string Handle()
        {
            var items = new List<DoorItem>()
      {
        new DoorItem("Milan", 55.5m, 57.8, 60.4, 180.3),
        new DoorItem("Verona", 65.5m, 57.8, 60.4, 183.3),
        new DoorItem("Milan", 45.5m, 53.8, 61.4, 178.3)
      };

            var inventoryBuilder = new ProductDailyReportBuilder(items);
            var manager = new InventoryBuildManager(inventoryBuilder);

            manager.BuildCompleteReport();
            var managerReport = inventoryBuilder.GetDailyReport();

            return "Report Created: " + managerReport.CreateReport();
        }
    }
}
