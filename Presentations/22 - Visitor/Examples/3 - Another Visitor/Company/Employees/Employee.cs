namespace Wincubate.VisitorExamples
{
    class Employee : IElement
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public EmployeeLevel Level { get; set; }
        public decimal Salary { get; set; }
        public int StockOptions { get; set; }

        public void Accept( IVisitor visitor ) => visitor.Visit(this);

        public override string ToString() => $"{FullName} [{Level} {Title}]";
    }
}
