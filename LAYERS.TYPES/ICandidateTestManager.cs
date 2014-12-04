using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateTestManager
    {
        List<ICandidateTestSchedule> viewCandidateTestStatus(ICandidateTestSchedule vacancyId);
        List<ICandidateTestSchedule> viewCandidatesMedicalTestStatus(ICandidateTestSchedule vacancyId);
        bool updateTestStatus(ICandidateTestSchedule t);
        bool updateMedicalStatus(ICandidateTestSchedule t);
    }
}
