using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LAYERS.TYPES;
using LAYERS.BO;

namespace LAYERS.BOFACTORY
{
    public class CandidateTestFactory
    {
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

        public static ICandidateTestSchedule createCandidate(int candidateId, int testStatus)
        {
            ICandidateTestSchedule i = new CandidateTestSchedule(candidateId, testStatus,true,true);
            return i;
        }



        public static ICandidateTestSchedule createCandidate(int candidateId, int medicalTestStatus, int bgcCheckStatus, string certificate, string remarks, int teststatus)
        {
            ICandidateTestSchedule i = new CandidateTestSchedule(candidateId, medicalTestStatus, bgcCheckStatus, certificate, remarks, teststatus);
            return i;
        }


    }
}

