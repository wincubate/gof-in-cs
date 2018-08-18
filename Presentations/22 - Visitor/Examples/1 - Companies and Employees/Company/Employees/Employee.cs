namespace Wincubate.VisitorExamples
{
    class Employee
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public EmployeeLevel Level { get; set; }
        public decimal Salary { get; set; }
        public int StockOptions { get; set; }

        public override string ToString() => $"{FullName} [{Level} {Title}]";
    }
}
