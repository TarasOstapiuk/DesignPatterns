namespace DesignPatterns.Application.Creational.Builder.NotFluentBuilder
{
    public class DoorItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }

        public DoorItem(string name, decimal price, double height, double width, double weight)
        {
            Name = name;
            Price = price;
            Height = height;
            Width = width;
            Weight = weight;
        }
    }
}
