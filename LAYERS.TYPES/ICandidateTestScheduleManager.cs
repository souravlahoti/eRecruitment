using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateTestScheduleManager
    {
        //Ashish
        List<IVacancy> SelectVacancy();
        List<IEmployee> SelectEmployee(string skillset);
        bool InsertTest(ICandidateTestSchedule t);
        //Ashish

        //Amruta
        List<ICandidateTestSchedule> Display();      
        int delete(ICandidateTestSchedule admin);
        //Amruta

        //Bhawna

        bool Save(ICandidateTestSchedule test);
        List<ICandidateTestSchedule> displayVacancyId();
        ICandidateTestSchedule displayRequiredByDate(ICandidateTestSchedule requiredbyDate);

        //Bhawna

        //Akshay

        List<ICandidateTestSchedule> display(int vacancyId);
        bool editTest(ICandidateTestSchedule schedule);
        List<ICandidateTestSchedule> getVacancy();
        List<ICandidateTestSchedule> fetchTestDates(ICandidateTestSchedule testschedule);

        //Akshay

      
    }
}
