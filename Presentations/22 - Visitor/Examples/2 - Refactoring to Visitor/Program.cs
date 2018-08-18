using System;

namespace Wincubate.VisitorExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyRepository repository = new CompanyRepository();
            Company company = repository.Get();

            RemainingExpensesVisitor visitor = new RemainingExpensesVisitor();
            company.Accept(visitor);

            Console.WriteLine( $"{visitor.RemainingExpenses:c}" );
        }
    }
}
