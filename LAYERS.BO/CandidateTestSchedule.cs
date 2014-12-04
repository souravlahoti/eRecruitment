using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional
using LAYERS.TYPES;
namespace LAYERS.BO
{
    public class CandidateTestSchedule:ICandidateTestSchedule
    {
        int testScheduleId;
        int testAdminId;
        int vacancyId;
        DateTime hrInterviewDate;
        DateTime technicalTestDate;
        DateTime writtenTestDate;

        //chandan
        public CandidateTestSchedule(int teststatus, int testscheduleid, bool dummy)
        {
            this.statusObj.TestStatus = teststatus;
            this.testScheduleId = testscheduleid;
        }
        //Chandan

        //Bhavna
        private DateTime requiredByDate;
        //Bhavna

        //Akshay

        ICandidateTestStatus statusObj = new CandidateTestStatus();
        IVacancy dateObj = new Vacancy();
        //Akshay

        public CandidateTestSchedule(int VacancyID)
        {
            this.vacancyId = VacancyID;
        }


        //Akshay

        public ICandidateTestStatus StatusObj
        {
            get
            {
                return statusObj;
            }
            set
            {
                statusObj = value;
            }
        }

        public IVacancy DateObj
        {
            get { return dateObj; }
            set { dateObj = value; }
        }

        //Akshay

        public int TestAdminId
        {
            get { return testAdminId; }
            set { testAdminId = value; }

        }

        public int TestScheduleId
        {
            get
            {
                return testScheduleId;
            }

            set
            {
                testScheduleId = value;
            }
        }

        public int VacancyId
        {
            get
            {
                return vacancyId;
            }

            set
            {
                vacancyId = value;
            }
        }

        public DateTime HrInterviewDate
        {
            get
            {
                return hrInterviewDate;
            }
            set
            {
                hrInterviewDate = value;
            }
        }

        public DateTime TechnicalTestDate
        {
            get
            {
                return technicalTestDate;
            }
            set
            {
                technicalTestDate = value;
            }
        }

        public DateTime WrittenTestDate
        {
            get
            {
                return writtenTestDate;
            }
            set
            {
                writtenTestDate = value;
            }
        }

        public DateTime RequiredByDate
        {
            get
            {
                return requiredByDate;
            }
            set
            {
                requiredByDate = value;
            }
        }

        public CandidateTestSchedule() { }



        //Ashish
        public CandidateTestSchedule(DateTime WrittenTestDate, DateTime TechnicalInterviewDate, DateTime HRInterviewDate)
        {
            this.writtenTestDate = WrittenTestDate;
            this.technicalTestDate = TechnicalInterviewDate;
            this.hrInterviewDate = HRInterviewDate;
        }

        public CandidateTestSchedule(int testAdminId, int vacancyId)
        {

            this.testAdminId = testAdminId;
            this.vacancyId = vacancyId;

        }

        //Ashish

        //Amruta

        IEmployee emp = new Employee();
        IVacancy vacancy = new Vacancy();

        public CandidateTestSchedule(IEmployee e, IVacancy v, int testAdminId)
        {
            this.testAdminId = testAdminId;
            emp.Name = e.Name;
            emp.Location = e.Location;
            emp.Designation = e.Designation;
            vacancy.YrExp = v.YrExp;


        }

        public CandidateTestSchedule(int testAdminId, bool dummy, bool dummy2)
        {
            this.testAdminId = testAdminId;
        }

        public IEmployee Emp
        {
            get { return emp; }
            set { }
        }

        public IVacancy Vcancy
        {
            get { return vacancy; }
            set { }
        }


        public CandidateTestSchedule(int testAdminId, bool x)
        {
            this.testAdminId = testAdminId;
        }
        //Amruta


        //Bhawna
        public CandidateTestSchedule(int VacancyId, int TestAdminId, DateTime WrittenTestDate, DateTime TechinterviewDate, DateTime HRInterviewDate)
        {

            this.vacancyId = VacancyId;
            this.testAdminId = TestAdminId;
            this.writtenTestDate = WrittenTestDate;
            this.technicalTestDate = TechinterviewDate;
            this.hrInterviewDate = HRInterviewDate;
        }

        public CandidateTestSchedule(DateTime RequiredByDate)
        {
            this.requiredByDate = RequiredByDate;
        }

        //Bhawna

        //Akshay
        public CandidateTestSchedule(ICandidateTestStatus StatusObj, DateTime WrittenTestDate, DateTime TechnicalTestDate, DateTime HRInterviewDate)
        {
            this.statusObj = StatusObj;
            this.writtenTestDate = WrittenTestDate;
            this.technicalTestDate = TechnicalTestDate;
            this.hrInterviewDate = HRInterviewDate;
        }

        //public CandidateTestSchedule(DateTime WrittenTestDate, DateTime TechnicalInterviewDate, DateTime HRInterviewDate)
        //{
        //    this.writtenTestDate = WrittenTestDate;
        //    this.technicalTestDate = TechnicalInterviewDate;
        //    this.hrInterviewDate = HRInterviewDate;
        //}

        public CandidateTestSchedule(IVacancy dateObj, DateTime WrittentestDate, DateTime TechnicalTestDate, DateTime HrInterview)
        {
            this.dateObj = dateObj;
            this.writtenTestDate = WrittentestDate;
            this.technicalTestDate = TechnicalTestDate;
            this.hrInterviewDate = HrInterview;
        }


        public CandidateTestSchedule(int vacancyId, DateTime WrittentestDate, DateTime TechnicalTestDate, DateTime HrInterview)
        {
            this.vacancyId = vacancyId;
            this.writtenTestDate = WrittentestDate;
            this.technicalTestDate = TechnicalTestDate;
            this.hrInterviewDate = HrInterview;
        }

        //Akshay


        //Sourav

        public CandidateTestSchedule(CandidateTestStatus candidate, DateTime writtenDates, DateTime technicalDates, DateTime hrDates, bool dummy)
        {
            this.writtenTestDate = writtenDates;
            this.technicalTestDate = technicalDates;
            this.hrInterviewDate = hrDates;
            StatusObj.TestStatus = candidate.TestStatus;
            StatusObj.CandidateID = candidate.CandidateID;
        }

        public CandidateTestSchedule(CandidateTestStatus c, bool dummy1, bool dummy2)
        {
            StatusObj.MedicalTestStatus = c.MedicalTestStatus;
            StatusObj.Certificate = c.Certificate;
            StatusObj.Remarks = c.Remarks;
            StatusObj.CandidateID = c.CandidateID;

        }
        public CandidateTestSchedule(int candidateId, int medicalTestStatus, int bgccheckStatus, string certificate, string remarks, int teststatus)
        {
            this.StatusObj.CandidateID = candidateId;
            this.StatusObj.CandidateID = candidateId;
            this.StatusObj.MedicalTestStatus = medicalTestStatus;
            this.StatusObj.Certificate = certificate;
            this.StatusObj.BgcCheckStatus = bgccheckStatus;
            this.StatusObj.Remarks = remarks;
            this.StatusObj.TestStatus = teststatus;

        }


        public CandidateTestSchedule(int candidateId, int testStatus, bool dummy1, bool dummy2)
        {
            StatusObj.CandidateID = candidateId;
            StatusObj.TestStatus = testStatus;

        }

        //Sourav
    }
}
