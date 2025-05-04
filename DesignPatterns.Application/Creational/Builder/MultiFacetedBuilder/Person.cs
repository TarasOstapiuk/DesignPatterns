namespace DesignPatterns.Application.Creational.Builder.MultiFacetedBuilder
{
    public class Person
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Company { get; set; }

        public string PositionAtWork { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{nameof(Street)}: Street, {nameof(City)}: {City}, {nameof(ZipCode)}: {ZipCode}," +
              $"{nameof(Company)}: {Company}, {nameof(PositionAtWork)}: {PositionAtWork}, {nameof(Salary)}: {Salary}";
        }
    }
}
