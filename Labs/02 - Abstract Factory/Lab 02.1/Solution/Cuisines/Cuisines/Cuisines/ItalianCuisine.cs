namespace Cuisines
{
    class ItalianCuisine : ICuisine
    {
        // Could have made use of Builder or similar
        public IMainCourse CreateMainCourse()
            => new Pizza( "Tomato Sauce", "Pepperoni", "Pineapple", "Cheese" );
        public IDessert CreateDessert() => new Tiramisu(); 
    }
}
