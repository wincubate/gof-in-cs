namespace Cuisines
{
    // This is the Abstract Factory (even though it's not called "Factory" ;-) )
    interface ICuisine
    {
        IMainCourse CreateMainCourse();
        IDessert CreateDessert();
    }
}
