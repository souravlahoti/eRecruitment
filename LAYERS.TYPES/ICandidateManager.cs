using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface ICandidateManager
    {
        //Shivani
        bool edit(ICandidate candidate);
        List<ICandidate> displayCandidate(int vacancid);
        List<ICandidate> display(IVacancy vacancy);
        bool deleteCandidate(IVacancy vacancy);
      
        //Shivani

        //Chandan
        List<ICandidate> Display1(ICandidate obj);
        List<ICandidate> display(ICandidate c);
        bool Update(ICandidate candidate);
        //Chandan
    }
}
