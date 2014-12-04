using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateTestScheduleDB
    {
        //Ashish
        List<IVacancy> SelectVacancy();
        List<IEmployee> SelectEmployee(string skillset);
        bool InsertTest(ICandidateTestSchedule t);
        //Ashish

        //Amruta
        List<ICandidateTestSchedule> DisplayAll();
        int delete(ICandidateTestSchedule admin);
        //amruta

        //Bhawna
        bool Save(ICandidateTestSchedule test);
        List<ICandidateTestSchedule> displayVacancyId();
        ICandidateTestSchedule displayRequiredByDate(ICandidateTestSchedule requiredbyDate);
        //Bhawna


        //Akshay
        bool editTest(ICandidateTestSchedule schedule);
        List<ICandidateTestSchedule> getVacancy();
        List<ICandidateTestSchedule> displayTest(int vacancyId);
        List<ICandidateTestSchedule> fetchTest(ICandidateTestSchedule testschedule);
        //Akshay

        
    }
}
