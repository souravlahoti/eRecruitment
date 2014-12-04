using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYERS.TYPES;
namespace LAYERS.BO
{
    public class Employee :IEmployee
    {
        //Ashish

        int employeeId;
        string name;
        DateTime dOB;
        string gender;
        string location;
        string skillSet;
        string dOJ;
        string designation;
        string division;
        double ctc;
        double projectId;
        double candidateId;
        string password;
        int isNew;
        double experience;



        public Employee(int id, string name, string skillSet, double experience)
        {
            this.employeeId = id;
            this.name = name;
            this.skillSet = skillSet;
            this.experience = experience;
        }

        

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SkillSet
        {
            get { return skillSet; }
            set { skillSet = value; }
        }

        public double Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        //Ashish

        //Amruta

        public Employee() { }

       


        public Employee(string name, string location, string designation)
        {
            this.name = name;
            this.designation = designation;
            this.location = location;


        }
       
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        //Amruta
    }
    
}

