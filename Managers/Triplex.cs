using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Managers
{
    public class Triplex : ICondoDataManager
    {
        public int GetBath()
        {
            return 2;
        }

        public int GetBedroom()
        {
            return 3;
        }


        public string GetFloorArea()
        {
            return "200 sq.m";
        }

        public decimal GetNetPrice()
        {
            return 2800000;
        }
    }
}