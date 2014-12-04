using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYERS.TYPES;
using LAYERS.DAL;
namespace LAYERS.DALFACTORY
{
    public class CandidateTestScheduleDBFactory
    {

        //Ashish
        public static ICandidateTestScheduleDB createtestschedule()
        {
            ICandidateTestScheduleDB testscheduledb = new CandidateTestScheduleDB();
            return testscheduledb;
        }

        //public static ICandidateTestScheduleDB CreateSchedule()
        //{
        //    ICandidateTestScheduleDB displayObj = new CandidateTestScheduleDB();
        //    return displayObj;
        //}
        //Ashish

        //Amruta
        public static ICandidateTestScheduleDB CreateDisplayDB()
        {
            ICandidateTestScheduleDB displaydb = new CandidateTestScheduleDB();
            return displaydb;
        }
        //Amruta

        //Bhawna

        public static ICandidateTestScheduleDB UpdatetestDB()
        {
            ICandidateTestScheduleDB testdb = new CandidateTestScheduleDB();
            return testdb;
        }
        public static ICandidateTestScheduleDB displayIdDB()
        {
            ICandidateTestScheduleDB VacancyIddb = new CandidateTestScheduleDB();

            return VacancyIddb;
        }
        public static ICandidateTestScheduleDB displayRequiredByDateDB()
        {
            ICandidateTestScheduleDB requiredbyDatedb = new CandidateTestScheduleDB();

            return requiredbyDatedb;
        }
        //Bhawna


        //Akshay

        public static ICandidateTestScheduleDB CreateSchedule()
        {
            ICandidateTestScheduleDB displayObj = new CandidateTestScheduleDB();
            return displayObj;
        }

        //Akshay


        
    }
}
