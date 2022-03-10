using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;

namespace Web.Factory
{
    public class ComissionManagerFactory
    {
        public IComissionManager GetCommissionManager(int unitSold)
        {
            IComissionManager returnvalue = null;
            if (unitSold == 9)
            {
                returnvalue = new UnitABC();
            }
            else if (unitSold == 10)
            {
                returnvalue = new UnitDEF();
            }
            else if (unitSold == 11)
            {
                returnvalue = new UnitGHI();
            }
            return returnvalue;
        }
    }
}