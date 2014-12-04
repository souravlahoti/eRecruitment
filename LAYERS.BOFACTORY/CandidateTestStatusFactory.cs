using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LAYERS.TYPES;
using LAYERS.BO;

namespace LAYERS.BOFACTORY
{
    class CandidateTestStatusFactory
    {   
        //Akshay

        public static ICandidateTestStatus Save(int candidateId, int testStatus)
        {
            ICandidateTestStatus candi = new CandidateTestStatus(candidateId, testStatus);
            return candi;
        }

        //Akshay
    }
}
