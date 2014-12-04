using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LAYERS.TYPES;
using LAYERS.DALFACTORY;

namespace LAYERS.BLL
{
    public class CandidateTestScheduleManager : ICandidateTestScheduleManager
    {
        //ashish
        public List<IVacancy> SelectVacancy()
        {
            ICandidateTestScheduleDB obj_itest = CandidateTestScheduleDBFactory.createtestschedule();
            List<IVacancy> list = new List<IVacancy>();
            list = obj_itest.SelectVacancy();
            return list;
        }




        public List<IEmployee> SelectEmployee(string skillset)
        {
            ICandidateTestScheduleDB obj_itest = CandidateTestScheduleDBFactory.createtestschedule();
            List<IEmployee> employee = obj_itest.SelectEmployee(skillset);
            return employee;

        }


        public bool InsertTest(ICandidateTestSchedule t)
        {
            ICandidateTestScheduleDB obj_itest = CandidateTestScheduleDBFactory.createtestschedule();
            bool x = obj_itest.InsertTest(t);
            return x;
        }
        //ashish


        //Amruta

        public List<ICandidateTestSchedule> Display()
        {
            ICandidateTestScheduleDB admin = CandidateTestScheduleDBFactory.CreateDisplayDB();
            List<ICandidateTestSchedule> dis = admin.DisplayAll();
            return dis;
        }

        public int delete(ICandidateTestSchedule admin)
        {
            ICandidateTestScheduleDB admindb = CandidateTestScheduleDBFactory.CreateDisplayDB();
            int isDelete = admindb.delete(admin);
            return isDelete;
        }
        //Amruta


        //Bhawna
        public bool Save(ICandidateTestSchedule test)
        {
            ICandidateTestScheduleDB testdb = CandidateTestScheduleDBFactory.UpdatetestDB();
            bool isSaved = testdb.Save(test);
            return isSaved;

        }

        //display id

        public List<ICandidateTestSchedule> displayVacancyId()
        {
            ICandidateTestScheduleDB VacancyIddb = CandidateTestScheduleDBFactory.displayIdDB();
            return VacancyIddb.displayVacancyId();

        }

        //displayRequiredByDate
        public ICandidateTestSchedule displayRequiredByDate(ICandidateTestSchedule requiredbyDate)
        {
            ICandidateTestScheduleDB RequiredByDatedb = CandidateTestScheduleDBFactory.displayRequiredByDateDB();
            return RequiredByDatedb.displayRequiredByDate(requiredbyDate);
        }

        //Bhawna


        //Akshay
       public List<ICandidateTestSchedule> display(int vacancyId)
        {
            ICandidateTestScheduleDB test = CandidateTestScheduleDBFactory.CreateSchedule();
            List<ICandidateTestSchedule> list = test.displayTest(vacancyId);
            return list;
        }
        
        public bool editTest(ICandidateTestSchedule schedule)
        {
            ICandidateTestScheduleDB test = CandidateTestScheduleDBFactory.CreateSchedule();
            bool save = test.editTest(schedule);
            return save;
        }

        public List<ICandidateTestSchedule> getVacancy()
        {
            ICandidateTestScheduleDB test = CandidateTestScheduleDBFactory.CreateSchedule();
            List<ICandidateTestSchedule> list = test.getVacancy();
            return list;
        }

        public List<ICandidateTestSchedule> fetchTestDates(ICandidateTestSchedule testschedule)
        {
            ICandidateTestScheduleDB test = CandidateTestScheduleDBFactory.CreateSchedule();
            List<ICandidateTestSchedule> testlist = test.fetchTest(testschedule);
            return testlist;
        }

      //Akshay


    }

}