using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional
using LAYERS.TYPES;
using LAYERS.BLL;

namespace LAYERS.BLLFACTORY
{
    public class VacancyRequestPCManagerFactory
    {
        //Shivani
        public static IVacancyRequestPCManager CreateVacancyReqPcManager()
        {
            IVacancyRequestPCManager ivacreqpcmgr = new VacancyRequestPCManager();
            return ivacreqpcmgr;
        }
        //Shivani
    }
}
