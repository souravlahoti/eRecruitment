using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateTestSchedules
    {

        int TestAdminId { get; set; }
        int TestScheduleId { get; set; }
        int VacancyId { get; set; }
        DateTime HrInterviewDate { get; set; }
        DateTime TechnicalTestDate { get; set; }
        DateTime WrittenTestDate { get; set; }
        ICandidateTestStatus StatusObj { get; set; }
    }
}
