using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional
using LAYERS.DAL;
using LAYERS.TYPES;
using LAYERS.BO;


namespace LAYERS.DALFACTORY
{
    public class VacancyRequestPCDBFactory
    {   
        //Shivani
        public static IVacancyRequestPCDB createVacReqPcDB()
        {
            IVacancyRequestPCDB ivacpcDB = new VacancyRequestPCDB();
            return ivacpcDB;
        }
        //Shivani
    }
}
