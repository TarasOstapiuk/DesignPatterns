namespace DesignPatterns.Application.Creational.Builder.AutoFixtureBuilder
{
    public class Address
    {
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public int HouseNumber { get; set; }

        public string GetAddress =>
          $"{AddressLine1} {AddressLine2}, {HouseNumber}";
    }
}
