using System;

namespace Wincubate.VisitorExamples
{
    class Program
    {
        static void Main( string[] args )
        {
            CompanyRepository repository = new CompanyRepository();
            Company company = repository.Get();

            RemainingExpensesVisitor visitor = new RemainingExpensesVisitor();
            company.Accept(visitor);

            Console.WriteLine($"{visitor.RemainingExpenses:c}");
            Console.WriteLine();

            Console.WriteLine("Before promotion:");
            foreach (Employee employee in company.Employees)
            {
                Console.WriteLine( employee );
            }
            Console.WriteLine();

            IVisitor otherVisitor = new PromotionVisitor();
            company.Accept(otherVisitor);

            Console.WriteLine("After promotion:");
            foreach (Employee employee in company.Employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
