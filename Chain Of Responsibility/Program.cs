using Chain_Of_Responsibility.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler william = new Handler(new Employee("William Worker", Decimal.Zero));
            Handler mary = new Handler(new Employee("Mary Manager", new Decimal(1000)));
            Handler victor = new Handler(new Employee("Victor Vicepres", new Decimal(5000)));
            Handler paula = new Handler(new Employee("Paula President", new Decimal(20000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);
            Decimal expenseReportAmount;

            if (TryReadDecimal("Expense report amount:", out expenseReportAmount))
            {
                ExpenseReport expense = new ExpenseReport(expenseReportAmount);
                ApprovalResponse response = william.HandleRequest(expense);
                Console.WriteLine("The request was {0}.", response);
                Console.ReadLine();
            }

        }

        public static bool TryReadDecimal(string prompt, out Decimal value)
        {
            value = default(Decimal);

            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    return false;
                }

                try
                {
                    value = Convert.ToDecimal(input);
                    return true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input is not a valid decimal.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The input is not a valid decimal.");
                }
            }
        }

    }
}
