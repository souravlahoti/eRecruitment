using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateDB

    {

        //Shivani
        bool edit(ICandidate candidate);
        List<ICandidate> display(int id);
        List<ICandidate> displayAllCandidate();
        List<ICandidate> display(IVacancy vacancy);
        bool deleteCandidate(IVacancy vacancy);
        //Shivani

        //Chandan
        List<ICandidate> displayHR(ICandidate obj1);
        List<ICandidate> display(ICandidate obj);
        bool update(ICandidate cus);
        //Chandan
    }
}