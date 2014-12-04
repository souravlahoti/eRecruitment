using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//addition

using LAYERS.TYPES;

namespace LAYERS.BO
{
    public class PlacementConsultant:IPlacementConsultant
    {
        int placementConsultantId;
        string placementConsultantName;
        string placementConsultantLocation;
        string placementConsultantPassword;

        public PlacementConsultant()
        {
        }

        //Shivani
        public PlacementConsultant(int placementConsultantId, string placementConsultantName, string placementConsultantLocation, string placementConsultantPassword)
        {
            this.placementConsultantId = placementConsultantId;
            this.placementConsultantName = placementConsultantName;
            this.placementConsultantLocation = placementConsultantLocation;
            this.placementConsultantPassword = placementConsultantPassword;
        }

        public int PlacementConsultantId
        {
            get
            {
                return placementConsultantId;
            }
            set
            {
                placementConsultantId = value;
            }
        }

        public string PlacementConsultantName
        {
            get
            {
                return PlacementConsultantName;
            }
            set
            {
                PlacementConsultantName = value;
            }
        }

        public string PlacementConsultantLocation
        {
            get
            {
                return placementConsultantLocation;
            }
            set
            {
                placementConsultantLocation = value;
            }
        }

        public string PlacementConsultantPassword
        {
            get
            {
                return placementConsultantPassword;
            }
            set
            {
                placementConsultantPassword = value;
            }
        }
    }
}
