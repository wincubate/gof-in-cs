namespace Wincubate.MementoExamples
{
    readonly struct Guest
    {
        public Guest( string name, string company )
        {
            Name = name;
            Company = company;
        }

        public string Name { get; }
        public string Company { get; }
    }
}
