using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateTestStatus
    {
        int TestStatus { get; set; }
        int MedicalTestStatus { get; set; }
        int CandidateID { get; set; }
        string Certificate { get; set; }
        int BgcCheckStatus { get; set; }
        string Remarks { get; set; }

    }
}
