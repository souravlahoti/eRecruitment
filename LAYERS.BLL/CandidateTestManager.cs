using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYERS.DALFACTORY;

using LAYERS.TYPES;

namespace LAYERS.BLL
{
    public class CandidateTestManager : ICandidateTestManager
    {
        public List<ICandidateTestSchedule> viewCandidateTestStatus(ICandidateTestSchedule vacancyId)
        {
            List<ICandidateTestSchedule> candlist = new List<ICandidateTestSchedule>();
            ICandidateTestDB i = CandidateTestDBFactory.createCandidateTestDB();
            candlist = i.viewTestCandidate(vacancyId);
            return candlist;

        }

        public List<ICandidateTestSchedule> viewCandidatesMedicalTestStatus(ICandidateTestSchedule vacancyId)
        {
            List<ICandidateTestSchedule> candlist = new List<ICandidateTestSchedule>();
            ICandidateTestDB i = CandidateTestDBFactory.createCandidateTestDB();
            candlist = i.viewMedicalCandidates(vacancyId);
            return candlist;

        }

        public bool updateTestStatus(ICandidateTestSchedule t)
        {
            ICandidateTestDB i = CandidateTestDBFactory.createCandidateTestDB();
            bool isSaved = i.updateTestStatus(t);
            return isSaved;
        }

        public bool updateMedicalStatus(ICandidateTestSchedule t)
        {
            ICandidateTestDB i = CandidateTestDBFactory.createCandidateTestDB();
            bool isSaved = i.updateMedicalStatus(t);
            return isSaved;
        }
    }
}

