using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//addition

using LAYERS.TYPES;
namespace LAYERS.BO
{
    public class Vacancy:IVacancy
    {

        int vacancyId;
        int vacancyRequestId;
        int requestedEmployeeId;
        int numberOfPosition;
        string skillSet;
        string initialExperience;
        float yearOfExperience;
        string businessDomain;
        string location;
        DateTime requiredByDate;
        string approvalStatus;
        string status;


        public Vacancy() { }

        //Shivani

        public Vacancy(int vacancyid, int VacReqId, int ReqEmpid, int NoP, string skills, string initialexp, float Yr_exp, string buss_domain, string location, DateTime rbd, string app_status, string status)
        {
            this.vacancyId = vacancyid;
            this.vacancyRequestId = VacReqId;
            this.requestedEmployeeId = ReqEmpid;
            this.numberOfPosition = NoP;
            this.skillSet = skills;
            this.initialExperience = initialexp;
            this.yearOfExperience = Yr_exp;
            this.businessDomain = buss_domain;
            this.location = location;
            this.requiredByDate = rbd;
            this.approvalStatus = app_status;
            this.status = status;

        }

        public Vacancy(int vacancyid)
        {
            this.vacancyId = vacancyid;
        }
        public Vacancy(int NoP, bool dummy)
        {
            this.numberOfPosition = NoP;
        }


        public int vacid
        {
            get { return vacancyId; }
            set { vacancyId = value; }
        }
        public int VacReqId
        {
            get { return vacancyRequestId; }
            set { vacancyRequestId = value; }
        }
        public int ReqEmpid
        {
            get { return requestedEmployeeId; }
            set { requestedEmployeeId = value; }
        }
        public int Nop
        {
            get { return numberOfPosition; }
            set { numberOfPosition = value; }
        }

        public string Skills
        {
            get { return skillSet; }
            set { skillSet = value; }
        }
        public string Initial_exp
        {
            get { return initialExperience; }
            set { initialExperience = value; }
        }
        public float YrExp
        {
            get { return yearOfExperience; }
            set { yearOfExperience = value; }
        }
        public string Bussdom
        {
            get { return businessDomain; }
            set { businessDomain = value; }
        }
        public string Loc
        {
            get { return location; }
            set { location = value; }
        }

        public DateTime Rbd
        {
            get { return requiredByDate; }
            set { requiredByDate = value; }
        }
        public string Appstatus
        {
            get { return approvalStatus; }
            set { approvalStatus = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }


        //Chandan
        public Vacancy(int v_id, int vr_id, int remp_id, int nop, string skills, string initialexp, int exp, string buss_domain, string location, DateTime rbd, string app_status, string status)
        {
            this.vacancyId = v_id;
            this.vacancyRequestId = vr_id;
            this.requestedEmployeeId = remp_id;

            this.Nop = nop;
            this.skillSet = skills;
            this.initialExperience = initialexp;
            this.yearOfExperience = exp;
            this.businessDomain = buss_domain;
            this.location = location;
            this.requiredByDate = rbd;
            this.approvalStatus = app_status;
            this.status = status;

        }
      
        //Chandan

        //Ashish
        public Vacancy(int id, string skillSet)
        {
            this.vacancyId = id;
            this.skillSet = skillSet;
        }


        public int VacancyId
        {
            get { return vacancyId; }
            set { vacancyId = value; }
        }

        public string SkillSet
        {
            get { return skillSet; }
            set { skillSet = value; }
        }
        //Ashish


        //amruta

        public Vacancy(double experience)
        {
            this.YrExp= Convert.ToSingle(experience);
        }
        public double Experience
        {
            get { return Convert.ToSingle(yearOfExperience); }
            set { yearOfExperience = Convert.ToSingle(value); }
        }
        //amruta

        //Akshay

        

        public Vacancy(DateTime d)
        {
            this.requiredByDate = d;
        }
            
        //Akshay
    }
}