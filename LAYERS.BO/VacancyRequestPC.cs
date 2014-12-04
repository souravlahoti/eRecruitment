using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//addition

using LAYERS.TYPES;

namespace LAYERS.BO
{
    public class VacancyRequestPC:IVacancyRequestPC
    {
        int  vacancyRequestPcId; 
        int  vacancyId; 
        int  placementConsultantId;
        int  recruitmentId;

        public VacancyRequestPC()
        { }

        //Shivani
        public VacancyRequestPC(int vacancyRequestPcId, int vacancyId, int placementConsultantId, int recruitmentId)
        {
            this.vacancyRequestPcId = vacancyRequestPcId;
            this.vacancyId = vacancyId;
            this.placementConsultantId = placementConsultantId;
            this.recruitmentId = recruitmentId;
        }

        public int VacancyRequestPcId
        {
            get
            {
                return vacancyRequestPcId;
            }
            set
            {
                vacancyRequestPcId = value;
            }
        }
        public int VacancyId
        {
            get
            {
                return  vacancyId;
            }
            set
            {
                vacancyId = value;
            }
        }
        public int PlacementConsultantId
        {
            get
            {
                return placementConsultantId;
            }
            set
            {
                placementConsultantId = value;
            }
        }
        public int RecruitmentId
        {
            get
            {
                return recruitmentId;
            }
            set
            {
                recruitmentId = value;
            }
        }
    }
}

