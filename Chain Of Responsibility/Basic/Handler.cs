using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Basic
{
    interface IRequestHandler
    {
        ApprovalResponse HandleRequest(ExpenseReport employee);
        void RegisterNext(Handler next);
    }
   
    public class Handler : IRequestHandler
    {
        public Handler(Employee employee)
        {
            _employee = employee;
            _next = EndOfChainHandler.Instance; ;
        }

        public ApprovalResponse HandleRequest(ExpenseReport expenseReport)
        {
            ApprovalResponse response = _employee.ApproveExpense(expenseReport.Total);
            if (response == ApprovalResponse.BeyondApprovalLimit)
                return _next.HandleRequest(expenseReport);
            return response;
        }
         
        public void RegisterNext(Handler next)
        {
            _next = next;
        }

        private readonly Employee _employee;
        private IRequestHandler _next;
    }
}
