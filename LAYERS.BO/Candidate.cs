using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//addition

using LAYERS.TYPES;

namespace LAYERS.BO
{
     public class Candidate:ICandidate
    {
        int candidateId;
        int vacancyId;
        string candidateName;
        DateTime dOB;
        string location;
        string gender;
        double percentage10;
        double percentage12;
        string gapInEducation;
        string gapInExperience;
        string resume;
        int bgcId;
        string remarks;

         //prooperties
        public Candidate()
        {

        }

         //Shivani
        public Candidate(int candidateid, int vacancyid, string candidateName, DateTime doB, string location, string gender, float per10, float per12, string gapinedu, string gapinexp, string resume, int Bgcid, string remarks)
        {
            this.candidateId = candidateid;
            this.vacancyId = vacancyid;
            this.candidateName = candidateName;
            this.dOB = doB;
            this.location = location;
            this.gender = gender;
            this.percentage10 = per10;
            this.percentage12 = per12;
            this.gapInEducation = gapinedu;
            this.gapInExperience = gapinexp;
            this.resume = resume;
            this.bgcId = Bgcid;
            this.remarks = remarks;
        }
        //Shivani
        public Candidate(int vacancyid, string candidateName, DateTime doB, string location, string gender, float per10, float per12, string gapinedu, string gapinexp, string resume, int Bgcid, string remarks)
        {

            this.vacancyId = vacancyid;
            this.candidateName = candidateName;
            this.dOB = doB;
            this.location = location;
            this.gender = gender;
            this.percentage10 = per10;
            this.percentage12 = per12;
            this.gapInEducation = gapinedu;
            this.gapInExperience = gapinexp;
            this.resume = resume;
            this.bgcId = Bgcid;
            this.remarks = remarks;
        }

        public Candidate(int vacancyid)
        {
            this.vacancyId = vacancyid;
        }

        public int CandidateId
        {
            get { return candidateId; }
            set { candidateId = value; }
        }
        public int VacancyId
        {
            get { return vacancyId; }
            set { vacancyId = value; }
        }
        public string CandidateName
        {
            get { return candidateName; }
            set { candidateName = value; }
        }
        public DateTime Dob
        {
            get { return dOB; }
            set { dOB = value; }
        }

        public string Loc
        {
            get { return location; }
            set { location = value; }
        }
        public string Gend
        {
            get { return gender; }
            set { gender = value; }
        }
        public double Per10
        {
            get { return percentage10; }
            set { percentage10 = value; }
        }
        public double Per12
        {
            get { return percentage12; }
            set { percentage12 = value; }
        }
        public string GapInEdu
        {
            get { return gapInEducation; }
            set { gapInEducation = value; }
        }
        public string GapInExp
        {
            get { return gapInExperience; }
            set { gapInExperience = value; }
        }
        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }
        public int BgcId
        {
            get { return bgcId; }
            set { bgcId = value; }
        }
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }


         //Chandan
        public Candidate(int can_id, int vac_id, string name, DateTime dob, string location, string gender, double tenth_percentage, double twelfth_percentage, string gap_in_education, string gap_in_experience, string resume)/*,ICandidateTestStatus obj)*/
        {
            this.candidateId = can_id;
            this.vacancyId = vac_id;
            this.candidateName = name;
            this.dOB = dob;
            this.location = location;
            this.gender = gender;
            this.percentage10 = tenth_percentage;
            this.percentage12 = twelfth_percentage;
            this.gapInEducation = gap_in_education;
            this.gapInExperience = gap_in_experience;
            this.resume = resume;
            //this.obj = obj;


        }

        ICandidateTestSchedule scheduleobj = new CandidateTestSchedule();
        public ICandidateTestSchedule ScheduleObj
        {
            get
            {
                return scheduleobj;
            }
            set
            {
                scheduleobj = value;
            }
        }

        public Candidate(int cid, string name, DateTime date, string loca, string gender, double tenth, double tweleth, string gapiedu, string gapiexp, string resume, ICandidateTestSchedule teststatus)
        {
            this.candidateId = cid;
            this.candidateName = name;
            this.dOB = date;
            this.location = loca;
            this.gender = gender;
            this.percentage10 = tenth;
            this.percentage12 = tweleth;
            this.gapInEducation = gapiedu;
            this.gapInExperience = gapiexp;
            this.resume = resume;
            this.scheduleobj.StatusObj.TestStatus = teststatus.StatusObj.TestStatus;
            this.scheduleobj.TestScheduleId = teststatus.TestScheduleId;
        }

        public Candidate(int can_id, string name, DateTime dob, string location, string gender, double tenth_percentage, double twelfth_percentage, string gap_in_education, string gap_in_experience, string resume)/*,ICandidateTestStatus obj)*/
        {
            this.candidateId = can_id;
            this.candidateName = name;
            this.dOB = dob;
            this.location = location;
            this.gender = gender;
            this.percentage10 = tenth_percentage;
            this.percentage12 = twelfth_percentage;
            this.gapInEducation = gap_in_education;
            this.gapInExperience = gap_in_experience;
            this.resume = resume;
        }

        
         //Chandan

    }
}