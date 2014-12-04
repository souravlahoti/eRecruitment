using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYERS.DAL;
using LAYERS.TYPES;
namespace LAYERS.DALFACTORY
{
    public class CandidateTestDBFactory
    {
        public static ICandidateTestDB createCandidateTestDB()
        {
            ICandidateTestDB i = new CandidateTestDB();
            return i;
        }
    }
}
