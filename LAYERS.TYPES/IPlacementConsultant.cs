using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface IPlacementConsultant
    {
        int PlacementConsultantId { get; set;}
        string PlacementConsultantName { get; set; }
        string PlacementConsultantLocation { get; set; }
        string PlacementConsultantPassword { get; set; }
    }
}