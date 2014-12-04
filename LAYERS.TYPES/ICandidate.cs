using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidate
    {

        int CandidateId { get; set; }
        int VacancyId { get; set; }
        string CandidateName { get; set; }
        DateTime Dob { get; set; }
        string Loc { get; set; }
        string Gend { get; set; }
        double Per10 { get; set; }
        double Per12 { get; set; }
        string GapInEdu { get; set; }
        string GapInExp { get; set; }
        string Resume { get; set; }
        int BgcId { get; set; }
        string Remarks { get; set; }
    }
}
