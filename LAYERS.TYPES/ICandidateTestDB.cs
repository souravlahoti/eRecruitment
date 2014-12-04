using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateTestDB
    {
        List<ICandidateTestSchedule> viewTestCandidate(ICandidateTestSchedule vacancy);
        List<ICandidateTestSchedule> viewMedicalCandidates(ICandidateTestSchedule vacancy);
        bool updateTestStatus(ICandidateTestSchedule t);
        bool updateMedicalStatus(ICandidateTestSchedule t);
    }
}
