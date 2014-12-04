using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//additional
using LAYERS.TYPES;
using LAYERS.BO;
namespace LAYERS.BOFACTORY
{
    public class EmployeeFactory
    {
        //ashish
        public static IEmployee CreateEmployee(int id, string name, string skillSet, double experience)
        {
            IEmployee objiemployee = new Employee(id, name, skillSet, experience);
            return objiemployee;
        }
        //ashish

        //Amruta
        public static IEmployee CreateEmployeeFactory(string name, string location, string designation)
        {
            IEmployee employee = new Employee(name, location, designation);
            return employee;
        }
        //Amruta
    }
}
