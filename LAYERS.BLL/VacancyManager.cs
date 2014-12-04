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
    public class VacancyManager : IVacancyManager
    {
        //Shivani
        public List<IVacancy> read()
        {
            List<IVacancy> list = null;
            IVacancyDB vacdb1 = VacancyDBFactory.createVacancy();
            list = vacdb1.read();
            return list;
        }


        public List<IVacancy> display(int placementid)
        {
            List<IVacancy> VList = null;
            IVacancyDB v3 = VacancyDBFactory.createVacancy();
            VList = v3.display(placementid);
            return VList;
        }
     public  List<IVacancy> display(IPlacementConsultant placementcon)
        {
            List<IVacancy> vaclist = null;
            IVacancyDB v4 = VacancyDBFactory.createVacancy();
            vaclist = v4.display(placementcon);
            return vaclist;
        }
        public bool requiredByDate(IVacancy vacancy)
        {
            IVacancyDB vacreqdate = VacancyDBFactory.createVacancy();
            bool isRequiredbydate = vacreqdate.requiredByDate(vacancy);
            return isRequiredbydate;
        }

        public bool delete(IVacancy vacancy)
        {
            IVacancyDB vacdb = VacancyDBFactory.createVacancy();
            bool isdeleted = vacdb.delete(vacancy);
            return isdeleted;
        }


        public List<IVacancy> totalCandidates(IVacancy vacancy)
        {
            List<IVacancy> list = null;
            IVacancyDB vacc = VacancyDBFactory.createVacancy();
            list = vacc.totalCandidates(vacancy);
            return list;
        }
        public bool updatedVacancyToSource(IVacancy vacancy)
        {
            IVacancyDB ivc = VacancyDBFactory.createVacancy();
            bool isupdated = ivc.updatedVacancyToSource(vacancy);
            return isupdated;
        }
        public bool updatedVacancyToFilled(IVacancy vacancy)
        {
            IVacancyDB ivc1 = VacancyDBFactory.createVacancy();
            bool isupdated = ivc1.updatedVacancyToFilled(vacancy);
            return isupdated;
        }


        //Shivani


        //Chandan
        public List<IVacancy> Display()
        {
            IVacancyDB vacDB = VacancyDBFactory.Createvacancy();
            List<IVacancy> vacancy = vacDB.Display();
            return vacancy;
        }

        public List<IVacancy> displayHR()
        {
            IVacancyDB vacDB = VacancyDBFactory.Createvacancy();
            List<IVacancy> vacancy = vacDB.displayHR();
            return vacancy;
        }

        //Chandan

        //Sourav

        public List<ICandidateTestSchedule> createVacancyID(int testAdminId)
        {
            List<ICandidateTestSchedule> vlist = new List<ICandidateTestSchedule>();
            IVacancyDB i = VacancyDBFactory.createVacancyDB();
            vlist = i.getTestVacancy(testAdminId);
            return vlist;
        }


        public List<ICandidateTestSchedule> createMedicalVacancyID()
        {
            List<ICandidateTestSchedule> vlist = new List<ICandidateTestSchedule>();
            IVacancyDB i = VacancyDBFactory.createVacancyDB();
            vlist = i.getMedicalVacancy();
            return vlist;
        }

        //sourav
      
    }
}
