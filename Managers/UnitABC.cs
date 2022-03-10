using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Managers
{
    public class UnitABC : IComissionManager
    {
        public decimal GetCommissionAmt()
        {
            
            return 10000;
        }
    }
}