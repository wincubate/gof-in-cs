namespace Wincubate.VisitorExamples
{
    class Project : IElement
    {
        public string Name { get; set; }
        public string ProjectCode { get; set; }
        public int HoursBudget { get; set; }
        public int HoursWorked { get; set; }
        public ProjectState State { get; set; }

        public void Accept( IVisitor visitor ) => visitor.Visit(this);
    }
}
