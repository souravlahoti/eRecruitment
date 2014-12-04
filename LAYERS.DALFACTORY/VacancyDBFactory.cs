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
    public class VacancyDBFactory
    {   
        //Shivani
        public static IVacancyDB createVacancy()
        {
            IVacancyDB v1 = new VacancyDB();
            return v1;
        }

        
        //Shivani


        //Chandan
        public static IVacancyDB Createvacancy()
        {
            IVacancyDB vacDB = new VacancyDB();
            return vacDB;
        }

        //Chandan

        //Sourav

        public static IVacancyDB createVacancyDB()
        {
            IVacancyDB i = new VacancyDB();
            return i;
        }

        //Sourav

      
    }
}
