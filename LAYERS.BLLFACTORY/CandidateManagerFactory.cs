using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional
using LAYERS.TYPES;
using LAYERS.BLL;

namespace LAYERS.BLLFACTORY
{
    public class CandidateManagerFactory
    {   
        //Shivani
        public static ICandidateManager CreateCandidate()
        {
            ICandidateManager i = new CandidateManager();
            return i;
        }
        public static ICandidateManager Addcandidatedetails()
        {
            ICandidateManager cand = new CandidateManager();
            return cand;
        }
        //Shivani


        //chandan
        public static ICandidateManager CreateCandidateManager()
        {
            ICandidateManager candidateManager = new CandidateManager();
            return candidateManager;
        }

        //chandan
    }
}