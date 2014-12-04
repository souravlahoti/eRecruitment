using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAYERS.TYPES
{
    public interface IEmployee
    {
        //Ashish
        int EmployeeId
        { get; set; }

        string Name
        { get; set; }

        string SkillSet
        { get; set; }

        double Experience
        { get; set; }
        //Ashish

        //Amruta 
        string Designation { get; set; }
        string Location { get; set; }
        //Amruta

    }
}
