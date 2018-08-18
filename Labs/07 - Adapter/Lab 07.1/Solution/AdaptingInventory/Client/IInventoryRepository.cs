using System.Collections.Generic;

namespace Client
{
    interface IInventoryRepository
    {
        IEnumerable<ItemGroup> GetItemGroups();
    }
}
