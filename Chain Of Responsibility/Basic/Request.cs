using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Basic
{
    /// <summary>
    /// Request Class
    /// </summary>
    public class Employee
    {
        public string Name { get; private set; }
        public Decimal _approvalLimit;

        public Employee(string name, Decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public ApprovalResponse ApproveExpense(Decimal Total)
        {
            return Total > _approvalLimit
                    ? ApprovalResponse.BeyondApprovalLimit
                    : ApprovalResponse.Approved;
        }
    }

   
}
