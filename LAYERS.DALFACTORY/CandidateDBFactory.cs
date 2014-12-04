using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional
using LAYERS.DAL;
using LAYERS.TYPES;
using LAYERS.BO;

namespace LAYERS.DALFACTORY
{
    public class CandidateDBFactory
    {
        //Shivani
         public static ICandidateDB createCandidate()
        {
            ICandidateDB i = new CandidateDB();
            return i;
        }
        public static ICandidateDB addCandidateDetails()
        {
            ICandidateDB cand= new CandidateDB();
            return cand;
        }
        //Shivani

        //Chandan
        public static ICandidateDB CreateCandidateDB()
        {
            ICandidateDB candidatedb = new CandidateDB();
            return candidatedb;
        }
        //Chandan
       
    }
}
