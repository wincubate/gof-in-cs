namespace BrewingCoffee
{
    /// <summary>
    /// See http://baresso.com/menukort/
    /// </summary>
    public interface ICoffee
    {
        CoffeeKind Kind { get; }
        int Strength { get; }
        CoffeeSize Size { get; }

        void Serve( string customerName );
    }
}
