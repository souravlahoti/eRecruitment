using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LAYERS.TYPES;

namespace LAYERS.BO
{
    public class CandidateTestStatus:ICandidateTestStatus
    {
        int testStatus;
        int medicalTestStatus;
        int candidateId;
        string certificate = "";
        int bgcCheckStatus;
        string remarks;


        //constructor

        public CandidateTestStatus(int CandidateId, int TestStatus)
        {
            this.candidateId = CandidateId;
            this.testStatus = TestStatus;
        }
        //Sourav

        public CandidateTestStatus(int candidateId, int testStatus, int medicalTestStatus)
        {
            this.testStatus = testStatus;
            this.candidateId = candidateId;
            this.medicalTestStatus = medicalTestStatus;
        }

        public CandidateTestStatus(int candidateId, int testStatus, bool dummy)
        {
            this.testStatus = testStatus;
            this.candidateId = candidateId;

        }

        public CandidateTestStatus(int candidateId, int testStatus, string certificate, string remarks)
        {
            this.medicalTestStatus = testStatus;
            this.candidateId = candidateId;
            this.certificate = certificate;
            this.remarks = remarks;

        }
        public CandidateTestStatus()
        {
        }

        //properties

        public int BgcCheckStatus
        {
            get
            {
                return bgcCheckStatus;
            }
            set
            {
                bgcCheckStatus = value;
            }
        }

        public string Certificate
        {

            get
            {
                return certificate;
            }

            set
            {
                certificate = value;
            }
        }

        public string Remarks
        {
            get
            {
                return remarks;
            }
            set
            {
                remarks = value;
            }
        }

        public int CandidateID
        {
            get
            {
                return candidateId;
            }

            set
            {
                candidateId = value;
            }
        }

        public int TestStatus
        {
            get
            {
                return testStatus;
            }
            set
            {
                testStatus = value;
            }
        }

        public int MedicalTestStatus
        {
            get
            {
                return medicalTestStatus;
            }
            set
            {
                medicalTestStatus = value;
            }
        }
    }
}
