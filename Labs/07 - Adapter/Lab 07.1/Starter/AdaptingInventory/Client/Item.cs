namespace Client
{
    class Item
    {
        public string Name { get; set; }
        public string Supplier { get; set; }

        public override string ToString() => $"\"{Name}\" by {Supplier}";
    }
}
