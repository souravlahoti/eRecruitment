using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYERS.BO;
using LAYERS.TYPES;

namespace LAYERS.BOFACTORY
{
    public class CandidateTestScheduleFactory
    {


        // Chandan
        public static ICandidateTestSchedule createTest(int teststatus, int testscheduleid)
        {
            bool dummy = true;
            ICandidateTestSchedule obj = new CandidateTestSchedule(teststatus,testscheduleid,dummy);
            return obj;
        }
        //Chandan


        //ashish
        public static ICandidateTestSchedule VacancyId(int VacancyId)
        {
            ICandidateTestSchedule vacancyObj = new CandidateTestSchedule(VacancyId);
            return vacancyObj;
        }
        //Ashish

        //Amruta
        public static ICandidateTestSchedule CreateCandidateTestScheduleFactory(IEmployee e, IVacancy v, int testAdminId)
        {
            ICandidateTestSchedule candidatetestschedule = new CandidateTestSchedule(e, v, testAdminId);
            return candidatetestschedule;
        }
        public static ICandidateTestSchedule addtestadmin(IEmployee e, IVacancy v, int testAdminId)
        {
            ICandidateTestSchedule admin = new CandidateTestSchedule(e, v, testAdminId);
            return admin;
        }

        public static ICandidateTestSchedule addtest(int testAdminId)
        {
            ICandidateTestSchedule admin = new CandidateTestSchedule(testAdminId);
            return admin;
        }

        //Amruta

        //Bhawna

        public static ICandidateTestSchedule updateTest(int VacancyId, int TestAdminid, DateTime WrittenTestDate, DateTime TechinterviewDate, DateTime HRInterviewDate)
        {
            ICandidateTestSchedule test = new CandidateTestSchedule(VacancyId, TestAdminid, WrittenTestDate, TechinterviewDate, HRInterviewDate);
            return test;
        }

        public static ICandidateTestSchedule createVacancyId(int vacancyid)
        {
            ICandidateTestSchedule i = new CandidateTestSchedule(vacancyid);
            return i;
        }

        //Bhawna

        //Akshay

        public static ICandidateTestSchedule DisplayTestSchedule(ICandidateTestStatus statusObj, DateTime writtenTestDate, DateTime techInterviewDate, DateTime hrInterviewDate)
        {
            ICandidateTestSchedule displayObj = new CandidateTestSchedule(statusObj, writtenTestDate, techInterviewDate, hrInterviewDate);
            return displayObj;
        }

        public static ICandidateTestSchedule EditTestSchedule(DateTime writtenTestDate, DateTime techInterviewDate, DateTime hrInterviewDate)
        {
            ICandidateTestSchedule editObj = new CandidateTestSchedule(writtenTestDate, techInterviewDate, hrInterviewDate);
            return editObj;
        }


        public static ICandidateTestSchedule disTestSchedule(int vacancyId, DateTime writtenTestDate, DateTime techInterviewDate, DateTime hrInterviewDate)
        {
            ICandidateTestSchedule editObj = new CandidateTestSchedule(vacancyId, writtenTestDate, techInterviewDate, hrInterviewDate);
            return editObj;
        }

        //public static ICandidateTestSchedule VacancyId(int VacancyId)
        //{
        //    ICandidateTestSchedule vacancyObj = new CandidateTestSchedule(VacancyId);
        //    return vacancyObj;
        //}

        public static ICandidateTestSchedule createCandidateTestSchedule(IVacancy dateObj, DateTime WrittentestDate, DateTime TechnicalInterview, DateTime HrInterview)
        {
            ICandidateTestSchedule fetchObj = new CandidateTestSchedule(dateObj, WrittentestDate, TechnicalInterview, HrInterview);
            return fetchObj;
        }

        //Akshay


        //Sourav
        public static ICandidateTestSchedule createVacancy()
        {
            ICandidateTestSchedule i = new CandidateTestSchedule();
            return i;
        }

        public static ICandidateTestSchedule createVacancy(int vacancy)
        {
            ICandidateTestSchedule i = new CandidateTestSchedule(vacancy);
            return i;
        }

        public static ICandidateTestSchedule createCandidate(int candidateId, int testStatus, bool dummy1, bool dummy2)
        {
            ICandidateTestSchedule i = new CandidateTestSchedule(candidateId, testStatus, dummy1, dummy2);
            return i;
        }



        public static ICandidateTestSchedule createCandidate(int candidateId, int medicalTestStatus, int bgcCheckStatus, string certificate, string remarks, int teststatus)
        {
            ICandidateTestSchedule i = new CandidateTestSchedule(candidateId, medicalTestStatus, bgcCheckStatus, certificate, remarks, teststatus);
            return i;
        }


        //Sourav
    }
}
