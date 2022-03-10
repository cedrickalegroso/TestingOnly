using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Managers
{
    public class Duplex : ICondoDataManager
    {
        public int GetBath()
        {
            return 1;
        }

        public int GetBedroom()
        {
            return 2;
        }

        public string GetFloorArea()
        {
            return "100 sq.m";
        }

        public decimal GetNetPrice()
        {
            return 2000000;
        }
    }
}