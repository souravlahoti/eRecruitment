using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//additional

using LAYERS.BO;
using LAYERS.TYPES;

namespace LAYERS.BOFACTORY
{
    public class PlacementConsultantBOFactory
    {   
        //Shivani
        public static IPlacementConsultant createPlacement(int placementConsultantId, string placementConsultantName, string placementConsultantLocation, string placementConsultantPassword)
        {
            IPlacementConsultant placecon = new PlacementConsultant(placementConsultantId, placementConsultantName, placementConsultantLocation, placementConsultantPassword);
            return placecon;
        }
        public static IPlacementConsultant createPlacement1()
        {
            IPlacementConsultant placecon = new PlacementConsultant();
            return placecon;
        }
        //Shivani
    }
}
