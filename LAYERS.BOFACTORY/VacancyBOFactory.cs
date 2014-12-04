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
    public class VacancyBOFactory
    {
        //Shivani

        public static IVacancy create(int vacancyid, int VacReqId, int ReqEmpid, int NoP, string skills, string initialexp, float Yr_exp, string buss_domain, string location, DateTime rbd, string app_status, string status)
        {
            IVacancy ivac = new Vacancy(vacancyid, VacReqId, ReqEmpid, NoP, skills, initialexp, Yr_exp, buss_domain, location, rbd, app_status, status);
            return ivac;
        }
        public static IVacancy create(int vacancyid)
        {
            IVacancy ivac1 = new Vacancy(vacancyid);
            return ivac1;
        }
        public static IVacancy createNOP(int NoP, bool dummy)
        {
            IVacancy i = new Vacancy(NoP, dummy);
            return i;
        }
        //Shivani

        //Chandan

        public static IVacancy createVacancy(int v_id, int vr_id, int remp_id, int nop, string skills, string initialexp, int exp, string buss_domain, string location, DateTime rbd, string app_status, string status)
        {
            IVacancy obj1 = new Vacancy(v_id, vr_id, remp_id, nop, skills, initialexp, exp, buss_domain, location, rbd, app_status, status);
            return obj1;
        }

        public static IVacancy createVacancy(int v_id)
        {
            IVacancy obj1 = new Vacancy(v_id);
            return obj1;
        }
        //Chandan

        //Ashish
        public static IVacancy CreateVacancy(int id, string skillset)
        {
            IVacancy objivacancy = new Vacancy(id, skillset);
            return objivacancy;
        }
        //ashish

        //Amruta

        public static IVacancy CreateVacancyfactory(double experience)
        {
            IVacancy vacancy = new Vacancy(experience);
            return vacancy;
        }
        //Amruta
    }
}
