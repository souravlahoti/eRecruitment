using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYERS.TYPES;
using LAYERS.DALFACTORY;
using LAYERS.BLL;
namespace LAYERS.BLLFACTORY
{
    public class CandidateTestScheduleManagerFactory
    {
        //ashish
        public static ICandidateTestScheduleManager createmanager()
        {
            ICandidateTestScheduleManager ischedulemanager = new CandidateTestScheduleManager();
            return ischedulemanager;

        }
        //ashish

        //Amruta
        public static ICandidateTestScheduleManager CreateDisplayManager()
        {
            ICandidateTestScheduleManager displayManager = new CandidateTestScheduleManager();
            return displayManager;
        }

        //Amruta


        //Bhawna

        public static ICandidateTestScheduleManager Updatetestmanager()
        {
            ICandidateTestScheduleManager testmanager = new CandidateTestScheduleManager();
            return testmanager;
        }
        public static ICandidateTestScheduleManager displayVacancyId()
        {
            ICandidateTestScheduleManager VacancyIdmanager = new CandidateTestScheduleManager();
            return VacancyIdmanager;
        }
        public static ICandidateTestScheduleManager displayRequiredByDate()
        {
            ICandidateTestScheduleManager RequiredByDatemanager = new CandidateTestScheduleManager();
            return RequiredByDatemanager;
        }

        //Bhawna

        //Akshay
        public static ICandidateTestScheduleManager createScheduleManager()
        {
            ICandidateTestScheduleManager testScheduleManager = new CandidateTestScheduleManager();
            return testScheduleManager;
        }
        //Akshay

       
    }

}
