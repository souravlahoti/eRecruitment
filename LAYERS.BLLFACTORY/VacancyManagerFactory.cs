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
    public class VacancyManagerFactory
    {
        //Shivani
        public static IVacancyManager Createvacancy()
        {
            IVacancyManager i = new VacancyManager();
            return i;
        }
        //Shivani

        //Chandan
        public static IVacancyManager CreateVacancyDBManager()
        {
            IVacancyManager vacancyManager = new VacancyManager();
            return vacancyManager;
        }
        //Chandan

        //Sourav
        public static IVacancyManager createVacancyManager()
        {
            IVacancyManager i = new VacancyManager();
            return i;
        }
        //sourav
       


    }
}
