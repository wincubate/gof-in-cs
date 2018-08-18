namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryClient client = new InventoryClient
            (
                new Adapter.ProductRepositoryAdapter(
                    new WebShop.ProductRepository()
                )
            );

            client.DisplayInventory();
        }
    }
}
