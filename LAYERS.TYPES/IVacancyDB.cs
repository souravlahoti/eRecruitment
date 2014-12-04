using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface IVacancyDB
    {   
        //Shivani
        List<IVacancy> read();
        List<IVacancy> display(int placementid);
        //List<IVacancy> getVacancy(int id);
        List<IVacancy> display(IPlacementConsultant placementcon);
        List<IVacancy> totalCandidates(IVacancy vacancy);
        bool requiredByDate(IVacancy vacancy);
        bool delete(IVacancy vacancy);
        bool updatedVacancyToSource(IVacancy vacancy);
        bool updatedVacancyToFilled(IVacancy vacancy);
        //Shivani


        //Chandan
        List<IVacancy> Display();
        List<IVacancy> displayHR();
        //Chandan

        //Sourav

        List<ICandidateTestSchedule> getTestVacancy(int testAdmindId);
        List<ICandidateTestSchedule> getMedicalVacancy();
        //sourav
      

      
    }
}