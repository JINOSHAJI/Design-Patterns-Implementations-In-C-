using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility.Basic
{
    public class EndOfChainHandler : IRequestHandler
    {
        private EndOfChainHandler() { }
        public static EndOfChainHandler Instance
        {
            get { return _instance; }
        }
        private static readonly EndOfChainHandler _instance = new EndOfChainHandler();
        public ApprovalResponse HandleRequest(ExpenseReport expenseReport)
        {
            return ApprovalResponse.Denied;
        }
        public void RegisterNext(Handler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }
    }
}
