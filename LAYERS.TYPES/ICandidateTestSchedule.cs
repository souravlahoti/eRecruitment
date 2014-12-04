using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateTestSchedule
    {
        //Ashish

        int TestAdminId { get; set; }
        int TestScheduleId { get; set; }
        int VacancyId { get; set; }
        DateTime HrInterviewDate { get; set; }
        DateTime TechnicalTestDate { get; set; }
        DateTime WrittenTestDate { get; set; }
        //ICandidateTestStatus CandidateTestStatusObj { get; set; }

        //Ashish

        //Bhawna

        DateTime RequiredByDate { get; set; }

        //Bhawna

        //Akshay

        ICandidateTestStatus StatusObj { get; }
        IVacancy DateObj { get; set; }

        //Akshay

    }
}
