using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Managers
{
    public class Studio : ICondoDataManager
    {
        public int GetBath()
        {
            return 1;
        }

        public int GetBedroom()
        {
            return 1;
        }


        public string GetFloorArea()
        {
            return "50 sq.m";
        }

        public decimal GetNetPrice()
        {
            return 1000000;
        }
    }
}