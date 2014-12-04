using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using LAYERS.TYPES;
using LAYERS.BO;
using LAYERS.BOFACTORY;

namespace LAYERS.DAL
{
    public class CandidateTestScheduleDB:ICandidateTestScheduleDB
    {

        //ashish
        public List<IVacancy> SelectVacancy()
        {
            SqlConnection conn = null;
            try
            {

                int id;
                string skillSet;
                List<IVacancy> vacancy = new List<IVacancy>();
                conn = DBUtility.getConnection();
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_vacancy_T144";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["VacancyID"].ToString());
                        skillSet = reader["SkillSet"].ToString();
                        IVacancy ivacancy = new Vacancy(id, skillSet);
                        vacancy.Add(ivacancy);

                    }


                }
                return vacancy;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        public List<IEmployee> SelectEmployee(string skillset)
        {
            SqlConnection conn = null;
            try
            {
            List<IEmployee> IEmployee = new List<IEmployee>();
            int id;
            string Skillset, name;
            double experience;

            conn = DBUtility.getConnection();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_employee_T144";
                SqlParameter param = new SqlParameter("@SkillSet", skillset);
                cmd.Parameters.Add(param);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["EmployeeID"].ToString());
                    name = reader["EmployeeName"].ToString();
                    Skillset = reader["SkillSet"].ToString();
                    experience = Convert.ToDouble(reader["Experience"].ToString());
                    IEmployee iemployee = new Employee(id, name, Skillset, experience);
                    IEmployee.Add(iemployee);


                }
            }

            return IEmployee;
           }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 conn.Close();
             }
        }


        public bool InsertTest(ICandidateTestSchedule testStatus)
        {
            SqlConnection conn = null;
            try
            {
            bool status = true;
            conn = DBUtility.getConnection();
            using (conn)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Sp_TestShedule_T144";
                SqlParameter param;
                param = new SqlParameter("@TestAdminEmployeeId", testStatus.TestAdminId);
                cmd.Parameters.Add(param);
                param = new SqlParameter("@VacancyId", testStatus.VacancyId);
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                conn.Close();

            }

            return status;
           }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        //ashish


        //Amruta

        public List<ICandidateTestSchedule> DisplayAll()
        {
            List<ICandidateTestSchedule> icreatetestschedule = new List<ICandidateTestSchedule>();
            SqlConnection conn = null;
            try
            {

            conn = DBUtility.getConnection();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_view_738641";
                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    IEmployee emp = new Employee(reader["EmployeeName"].ToString(), reader["Location"].ToString(), reader["Designation"].ToString());
                    IVacancy v = new Vacancy(Convert.ToDouble(reader["YearOfExperience"]));
                    int i = (Convert.ToInt32(reader["EmployeeID"]));
                    icreatetestschedule.Add(new CandidateTestSchedule(emp, v, Convert.ToInt32(reader["EmployeeID"])));
                }





            }

            return icreatetestschedule;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }


        //for delete
        public int delete(ICandidateTestSchedule admin)
        {
            int isDelete = 0;
            List<ICandidateTestSchedule> icreatetestschedule = new List<ICandidateTestSchedule>();
            SqlConnection conn = null;
             try
            {

            conn = DBUtility.getConnection();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_delete_738641";
                SqlParameter param;
                param = new SqlParameter("@empid", admin.TestAdminId);
                cmd.Parameters.Add(param);
                isDelete = cmd.ExecuteNonQuery();
            }

            conn.Close();

            return isDelete;
            }
             catch (Exception ex)
             {
                 throw ex;
             }
             finally
             {
                 conn.Close();
             }

        }

        //amruta



        //Bhawna

        public bool Save(ICandidateTestSchedule test)
        {
            bool isSaved = false;
            SqlConnection con = null;

            try
            {
                con = DBUtility.getConnection();
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TestSchedule_TeamD";

                cmd.Parameters.AddWithValue("@vid", test.VacancyId);
                cmd.Parameters.AddWithValue("@taid", test.TestAdminId);
                cmd.Parameters.AddWithValue("@WTD", test.WrittenTestDate);
                cmd.Parameters.AddWithValue("@TID", test.TechnicalTestDate);
                cmd.Parameters.AddWithValue("@HRID", test.HrInterviewDate);


                int iRowsAffected = cmd.ExecuteNonQuery();
                isSaved = (iRowsAffected > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return isSaved;
        }
        //display vacancy id
        public List<ICandidateTestSchedule> displayVacancyId()
        {
            try
            {
                //bool isSaved = false;
                SqlConnection con = null;


                List<ICandidateTestSchedule> VacancyIdList = new List<ICandidateTestSchedule>();

                con = DBUtility.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TestScheduleDisplay_TeamD";


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Console.WriteLine("\t {0} \t {1} \t {2} \t \t {3}", reader["EmployeeID"].ToString(), reader["EmployeeName"].ToString(), reader["Division"].ToString(), reader["Designation"].ToString());

                    ICandidateTestSchedule e = new CandidateTestSchedule(Convert.ToInt32(reader["TestAdminEmployeeID"].ToString()), Convert.ToInt32(reader["VacancyID"].ToString()));
                    VacancyIdList.Add(e);
                }
                {
                    con.Close();
                    return VacancyIdList;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        //display RequiredByDate

        public ICandidateTestSchedule displayRequiredByDate(ICandidateTestSchedule requiredbyDate)
        {
            SqlConnection con = null;
            ICandidateTestSchedule e = null;
            try
            {

                con = DBUtility.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Vacancy_TeamD";
                cmd.Parameters.AddWithValue("@vacanyid", requiredbyDate.VacancyId);


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    e = new CandidateTestSchedule(Convert.ToDateTime(reader["RequiredByDate"].ToString()));
                }

                con.Close();
                return e;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

       }
        //Bhawna
     
      
        //Akshay

        
         //<<VIEW/READ>>

       public List<ICandidateTestSchedule> displayTest(int vacancyId)
        {
            List<ICandidateTestSchedule> list = new List<ICandidateTestSchedule>();
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();
                using (con)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_displayTestSchedule_759020";
                    cmd.Parameters.AddWithValue("@VacancyID", vacancyId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ICandidateTestStatus i = new CandidateTestStatus(Convert.ToInt32(reader["CandidateID"].ToString()), Convert.ToInt32(reader["TestStatus"].ToString()));

                        list.Add(CandidateTestScheduleFactory.DisplayTestSchedule(i, Convert.ToDateTime(reader["WrittenTestDate"].ToString()), Convert.ToDateTime(reader["TechnicalTestDate"].ToString()), Convert.ToDateTime(reader["HRInterviewDate"].ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Warning:" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public List<ICandidateTestSchedule> getVacancy()
        {
            List<ICandidateTestSchedule> vlist = new List<ICandidateTestSchedule>();
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_getVacancy_759020";

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    vlist.Add(CandidateTestScheduleFactory.VacancyId(Convert.ToInt32(reader["VacancyID"].ToString())));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return vlist;
        }




        //<<UPDATE>>
        public bool editTest(ICandidateTestSchedule schedule)
        {
            SqlConnection con = null;
            bool s = false;
            try
            {
                con = DBUtility.getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_update_759020";
                cmd.Parameters.AddWithValue("@VacancyID", schedule.VacancyId);
                cmd.Parameters.AddWithValue("@WrittenTestDate", schedule.WrittenTestDate);
                cmd.Parameters.AddWithValue("@TechnicalTestDate", schedule.TechnicalTestDate);
                cmd.Parameters.AddWithValue("@HRInterviewDate", schedule.HrInterviewDate);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                s = (rows > 0) ? true : false;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Warning:" + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return s;
        }


        public List<ICandidateTestSchedule> fetchTest(ICandidateTestSchedule testschedule)
        {
            List<ICandidateTestSchedule> Testlist = new List<ICandidateTestSchedule>();
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();
                using (con)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_popupdate_759020";
                    cmd.Parameters.AddWithValue("@VacancyID", testschedule.VacancyId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IVacancy vacancy = new Vacancy(Convert.ToDateTime(reader["RequiredByDate"].ToString()));
                        Testlist.Add(CandidateTestScheduleFactory.createCandidateTestSchedule(vacancy, Convert.ToDateTime(reader["WrittenTestDate"].ToString()), Convert.ToDateTime(reader["TechnicalTestDate"].ToString()), Convert.ToDateTime(reader["HRInterviewDate"].ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Warning:" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return Testlist;
        }

        //Akshay


       
    }


}
