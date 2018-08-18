using System.Collections.Generic;

namespace Client
{
    class ItemGroup
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public override string ToString() => $"\"{Name} ({Count} item(s))";

        public IEnumerable<Item> Items { get; set; }
    }
}
