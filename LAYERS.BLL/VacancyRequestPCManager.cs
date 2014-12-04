using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional
using LAYERS.DAL;
using LAYERS.DALFACTORY;
using LAYERS.TYPES;

namespace LAYERS.BLL
{
    public class VacancyRequestPCManager : IVacancyRequestPCManager
    {
        //Shivani
        public List<IVacancyRequestPC> read(IPlacementConsultant placementconsultant)
        {
            //List<IVacancyRequestPcDB> vlist=null;
            IVacancyRequestPCDB ivacreqdb = VacancyRequestPCDBFactory.createVacReqPcDB();
            List<IVacancyRequestPC> obj = ivacreqdb.read(placementconsultant);
            return obj;
        }
        //Shivani
    }
}