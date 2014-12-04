using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional

using LAYERS.BO;
using LAYERS.TYPES;

namespace LAYERS.BOFACTORY
{
    public class CandidateBOFactory
    {
        //Shivani
 
        public static ICandidate createCandidate(int candidateid,int vacancyid,string candidatename, DateTime dob,string location, string gender, float per10, float per12,string  gapinedu, string  gapinexp,string resume,int Bgcid,string remarks)
        {
            ICandidate candidate = new Candidate(candidateid,vacancyid, candidatename, dob, location, gender, per10, per12, gapinedu, gapinexp, resume, Bgcid, remarks);
            return candidate;
        }
        public static ICandidate createCandidate( int vacancyid, string candidatename, DateTime dob, string location, string gender, float per10, float per12, string gapinedu, string gapinexp, string resume, int Bgcid, string remarks)
        {
            ICandidate candidate = new Candidate(vacancyid, candidatename, dob, location, gender, per10, per12, gapinedu, gapinexp, resume, Bgcid, remarks);
            return candidate;
        }
        public static ICandidate addCandidateDetails(int vacancyid)
        {
            ICandidate candidate = new Candidate(vacancyid);
            return candidate;
        }
        public static ICandidate addCandidateDetails( int vacancyid, string candidatename, DateTime dob, string location, string gender, float per10, float per12, string gapinedu, string gapinexp, string resume, int Bgcid, string remarks) 
        {
            ICandidate candidate = new Candidate(vacancyid, candidatename, dob, location, gender, per10, per12, gapinedu, gapinexp, resume, Bgcid, remarks); 
            return candidate;
        }
        public static ICandidate addCandidateDetails(int candidateid,int vacancyid, string candidatename, DateTime dob, string location, string gender, float per10, float per12, string gapinedu, string gapinexp, string resume, int Bgcid, string remarks)
        {
            ICandidate candidate = new Candidate(candidateid,vacancyid, candidatename, dob, location, gender, per10, per12, gapinedu, gapinexp, resume, Bgcid, remarks);
            return candidate;
        }
        //Shivani


        //Chandan
        //public static ICandidate createCandidate(int vac_id, string name, DateTime dob, string location, string gender, double tenth_percentage, double twelfth_percentage, string gap_in_education, string gap_in_experience, string resume, int bgc_test_id, string remarks)
        //{
        //    ICandidate candidate1 = new Candidate(vac_id, name, dob, location, gender, tenth_percentage, twelfth_percentage, gap_in_education, gap_in_experience, resume);
        //    return candidate1;
        //}
        //public static ICandidate createCandidate(int can_id, int vac_id, string name, DateTime dob, string location, string gender, double tenth_percentage, double twelfth_percentage, string gap_in_education, string gap_in_experience, string resume, int bgc_test_id, string remarks)
        //{
        //    ICandidate candidate1 = new Candidate(can_id, vac_id, name, dob, location, gender, tenth_percentage, twelfth_percentage, gap_in_education, gap_in_experience, resume);
        //    return candidate1;
        //}
        public static ICandidate createCandidate(int can_id, string name, DateTime dob, string location, string gender, double tenth_percentage, double twelfth_percentage, string gap_in_education, string gap_in_experience, string resume)
        {
            ICandidate candidate1 = new Candidate(can_id, name, dob, location, gender, tenth_percentage, twelfth_percentage, gap_in_education, gap_in_experience, resume);
            return candidate1;
        }
        public static ICandidate createCandidate(int vac_id)
        {
            ICandidate candidate1 = new Candidate(vac_id);
            return candidate1;
        }

        public static ICandidate createCandidate(int cid,string name,DateTime date,string loca,string gender,double tenth,double tweleth,string gapiedu,string gapiexp, string resume,ICandidateTestSchedule teststatus)
        {
            ICandidate candidate1 = new Candidate(cid, name, date, loca, gender, tenth, tweleth, gapiedu, gapiexp, resume, teststatus);
            return candidate1;
        }

        //Chandan
    }
}
