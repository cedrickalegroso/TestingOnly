using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Managers
{
    public class UnitDEF : IComissionManager
    {
        public decimal GetCommissionAmt()
        {
            return 25000;
        }
    }
}