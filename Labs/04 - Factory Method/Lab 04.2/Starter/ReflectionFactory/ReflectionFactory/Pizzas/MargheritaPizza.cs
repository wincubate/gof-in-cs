namespace Wincubate.FactoryMethodLabs
{
    class MargheritaPizza : Pizza
    {
        public MargheritaPizza()
        {
            Crust = CrustKind.Classic;
            HasSauce = true;
            Cheese = CheeseKind.Regular;
        }
    }
}
