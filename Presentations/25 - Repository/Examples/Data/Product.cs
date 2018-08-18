namespace Wincubate.RepositoryExamples.Data
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public Category? Category { get; set; }

        public override string ToString()
            => $"[{Id}] {Category?.ToString() ?? "-"}: \"{Name}\" by {Manufacturer}";

        public Product()
        {
        }

        public Product( int id, string name, string manufacturer, Category? category = null )
        {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Category = category;
        }
    }
}