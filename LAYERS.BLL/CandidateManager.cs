using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//additional
using LAYERS.DAL;
using LAYERS.DALFACTORY;
using LAYERS.TYPES;

namespace LAYERS.BLL
{
    public class CandidateManager : ICandidateManager
    {
        //Shivani
        public bool edit(ICandidate candidate)
        {
            ICandidateDB i = CandidateDBFactory.createCandidate();
            bool isEdit = i.edit(candidate);
            return isEdit;
        }
        public List<ICandidate> displayCandidate(int id)
        {
            //ICandidate c = new candidate();
            List<ICandidate> cList = null;
            ICandidateDB obj = CandidateDBFactory.addCandidateDetails();
            cList = obj.display(id);

            return cList;
        }
        public List<ICandidate> display(IVacancy vacancy)
        {
            List<ICandidate> CLIST = null;
            ICandidateDB obj1 = CandidateDBFactory.addCandidateDetails();
            CLIST = obj1.display(vacancy);
            return CLIST;
        }
     

        public bool deleteCandidate(IVacancy vacancy)
        {
            ICandidateDB CAND = CandidateDBFactory.createCandidate();
            bool isdeleted = CAND.deleteCandidate(vacancy);
            return isdeleted;
        }


       
        //Shivani

        //Chandan
        public List<ICandidate> Display1(ICandidate obj)
        {
            ICandidateDB candidatedb = CandidateDBFactory.CreateCandidateDB();
            List<ICandidate> list1 = candidatedb.displayHR(obj);
            return list1;
        }

        public List<ICandidate> display(ICandidate c)
        {
            ICandidateDB candidatedb = CandidateDBFactory.CreateCandidateDB();
            List<ICandidate> list = candidatedb.display(c);
            return list;
        }
        public bool Update(ICandidate candidate)
        {
            ICandidateDB candidatedb = CandidateDBFactory.CreateCandidateDB();
            bool issaved = candidatedb.update(candidate);
            return issaved;
        }

        //Chandan















    }
}
