using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Managers
{
    public interface ICondoDataManager
    {
        int GetBedroom();
        int GetBath();
        string GetFloorArea();
        decimal GetNetPrice();
     

    }
}
