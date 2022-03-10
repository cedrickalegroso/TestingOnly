using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;

namespace Web.Factory
{
    public class CondoDataManagerFactory
    {
        public ICondoDataManager GetCondoDataManager(int unitTypeId)
        {
            ICondoDataManager returnvalue = null;
            if(unitTypeId == 1)
            {
                returnvalue = new Studio();
            }
            else if (unitTypeId == 2)
            {
                returnvalue = new Duplex();
            }
            else if (unitTypeId == 3)
            {
                returnvalue = new Triplex();
            }
            return returnvalue;
        }
    }
}