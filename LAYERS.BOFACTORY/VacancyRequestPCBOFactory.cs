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
    public class VacancyRequestPCBOFactory
    {
       //Shivani
       public static IVacancyRequestPC createVacReq(int vacancyRequestPcId, int vacancyId, int placementConsultantId, int recruitmentId)
        {
            IVacancyRequestPC ivacpc = new VacancyRequestPC(vacancyRequestPcId,vacancyId,placementConsultantId,recruitmentId);
            return ivacpc;
        }
        //Shivani
    }
}
