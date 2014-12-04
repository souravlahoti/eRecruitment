using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface IVacancyRequestPC
    {
        int VacancyRequestPcId { get; set; }
        int VacancyId { get; set; }
        int PlacementConsultantId { get; set; }
        int RecruitmentId { get; set; }
    }
}
