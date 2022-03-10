using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Managers
{
    public class UnitGHI : IComissionManager
    {
        public decimal GetCommissionAmt()
        {
            return 50000;
        }
    }
}