using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using LAYERS.BLL;
using LAYERS.TYPES;

namespace LAYERS.BLLFACTORY
{
    public class CandidateTestManagerFactory
    {
        public static ICandidateTestManager createCandidateTestManager()
        {
            ICandidateTestManager i = new CandidateTestManager();
            return i;
        }
    }
}