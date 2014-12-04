using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface IVacancy
    {


        int vacid { get; set; }
        int VacReqId { get; set; }
        int ReqEmpid { get; set; }
        int Nop { get; set; }
        string Skills { get; set; }
        string Initial_exp { get; set; }
        float YrExp { get; set; }
        string Bussdom { get; set; }
        string Loc { get; set; }
        DateTime Rbd { get; set; }
        string Appstatus { get; set; }
        string Status { get; set; }



        int VacancyId { get; set; }
        string SkillSet { get; set; }
    }
}
