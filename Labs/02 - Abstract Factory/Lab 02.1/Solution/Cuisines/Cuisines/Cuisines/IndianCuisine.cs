namespace Cuisines
{
    class IndianCuisine : ICuisine
    {
        public IMainCourse CreateMainCourse() => new ChickenCurry(5);
        public IDessert CreateDessert() => new Kheer();
    }
}
