using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

//addition

using LAYERS.TYPES;
using LAYERS.BOFACTORY;
using LAYERS.BO;

namespace LAYERS.DAL
{
    public class VacancyDB:IVacancyDB
    {
        //Shivani
        public List<IVacancy> read()
        {
            List<IVacancy> vac1 = new List<IVacancy>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ReadVac_730844_s";
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int vacid = Convert.ToInt32(reader["VacancyID"].ToString());

                    int vac_reqid = Convert.ToInt32(reader["VacancyRequestID"].ToString());
                    int re_empid = Convert.ToInt32(reader["RequestedEmployeeID"].ToString());
                    int nop = Convert.ToInt32(reader["NumberOfPosition"].ToString());
                    string skills = reader["SkillSet"].ToString();
                    string ini_exp = reader["InitialExperience"].ToString();
                    float yr_exp = Convert.ToSingle(reader["YearOfExperience"].ToString());
                    string bus_dom = reader["BusinessDomain"].ToString();
                    string loc = reader["Location"].ToString();
                    DateTime req_date = Convert.ToDateTime(reader["RequiredByDate"].ToString());
                    string app_status = reader["ApprovalStatus"].ToString();
                    string status = reader["Status1"].ToString();

                    IVacancy v = VacancyBOFactory.create(vacid, vac_reqid, re_empid, nop, skills, ini_exp, yr_exp, bus_dom, loc, req_date, app_status, status);
                    vac1.Add(v);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return vac1;
        }

        //Shivani
        public List<IVacancy> display(IPlacementConsultant placementcon)
        {
            List<IVacancy> vac1 = new List<IVacancy>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_DisplayPc_730844_s";
                conn.Open();
                cmd.Parameters.AddWithValue("@PlacementConsultantId", placementcon.PlacementConsultantId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int vacid = Convert.ToInt32(reader["VacancyID"].ToString());

                    int vac_reqid = Convert.ToInt32(reader["VacancyRequestID"].ToString());
                    int re_empid = Convert.ToInt32(reader["RequestedEmployeeID"].ToString());
                    int nop = Convert.ToInt32(reader["NumberOfPosition"].ToString());
                    string skills = reader["SkillSet"].ToString();
                    string ini_exp = reader["InitialExperience"].ToString();
                    float yr_exp = Convert.ToSingle(reader["YearOfExperience"].ToString());
                    string bus_dom = reader["BusinessDomain"].ToString();
                    string loc = reader["Location"].ToString();
                    DateTime req_date = Convert.ToDateTime(reader["RequiredByDate"].ToString());
                    string app_status = reader["ApprovalStatus"].ToString();
                    string status = reader["Status1"].ToString();

                    IVacancy v = VacancyBOFactory.create(vacid, vac_reqid, re_empid, nop, skills, ini_exp, yr_exp, bus_dom, loc, req_date, app_status, status);
                    vac1.Add(v);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return vac1;
        }

        //Shivani

        public List<IVacancy> display(int placementid)
        {
            List<IVacancy> vacance = new List<IVacancy>();

            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_VACANCY_Read_730844";
                cmd.Parameters.AddWithValue("@PlacementConsultantID",placementid);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int vacid = Convert.ToInt32(reader["VacancyID"].ToString());

                    IVacancy v = VacancyBOFactory.create(vacid);
                    vacance.Add(v);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return vacance;
        }

        //Shivani

        public bool requiredByDate(IVacancy vacancy)
        {
            bool isRequiredByDate = false;
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_REqDate_730844_s";
                conn.Open();

                cmd.Parameters.AddWithValue("@VacancyId", vacancy.vacid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    vacancy.Rbd = Convert.ToDateTime(reader["RequiredByDate"].ToString());
                }
                DateTime date = DateTime.Now;

                if (((vacancy.Rbd - date).TotalDays) < 21)
                {
                    isRequiredByDate = true;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isRequiredByDate;
        }

        //Shivani


        public bool delete(IVacancy vacancy)
        {
            bool isdeleted = false;
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Display_730844_s";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyID", vacancy.vacid);
                conn.Open();
                int iRowsAffected = cmd.ExecuteNonQuery();
                isdeleted = (iRowsAffected > 0) ? true : false;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isdeleted;
        }

        //Shivani

        public bool updatedVacancyToSource(IVacancy vacancy)
        {
            bool isupdated = false;
            int rowsAffected;
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Display_730844_s";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyID", vacancy.vacid);
                rowsAffected = cmd.ExecuteNonQuery();
                isupdated = (rowsAffected > 0) ? true : false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isupdated;
        }

        //Shivani

        public bool updatedVacancyToFilled(IVacancy vacancy)
        {
            bool isupdated = false;
            int rowsAffected;
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_updateFilled_730844_s";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyID", vacancy.vacid);
                rowsAffected = cmd.ExecuteNonQuery();
                isupdated = (rowsAffected > 0) ? true : false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isupdated;
        }

        //Shivani

       

        //Shivani

        public List<IVacancy> totalCandidates(IVacancy vacancy)
        {
            List<IVacancy> vacance = new List<IVacancy>();
            bool dummy = true;
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_nopDisplay_730844_s";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyId", vacancy.vacid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int nop = Convert.ToInt32(reader["NumberOfPosition"].ToString());

                    IVacancy v = VacancyBOFactory.createNOP(nop, dummy);
                    vacance.Add(v);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return vacance;
        }
        //Shivani


        //Chandan

        //PC
        public List<IVacancy> Display()
        {
            List<IVacancy> vac = new List<IVacancy>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PDisplayVacancy_757860";
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int vac_id = (Convert.ToInt32(reader["VacancyID"].ToString()));
                    IVacancy c = VacancyBOFactory.createVacancy(vac_id);
                    vac.Add(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return vac;
        }


        //HR
        public List<IVacancy> displayHR()
        {
            List<IVacancy> vac = new List<IVacancy>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_HRDisplayVacancy_757860";
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int vac_id = (Convert.ToInt32(reader["VacancyID"].ToString()));
                    IVacancy c = VacancyBOFactory.createVacancy(vac_id);
                    vac.Add(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return vac;
        }
        //sourav

        public List<ICandidateTestSchedule> getTestVacancy(int testAdminId)
        {
            List<ICandidateTestSchedule> vList = new List<ICandidateTestSchedule>();
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_readVacancy_758575";
                cmd.Parameters.AddWithValue("@testadminid", testAdminId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    vList.Add(new CandidateTestSchedule(Convert.ToInt32(reader["VacancyId"].ToString())));
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
            return vList;
        }


        public List<ICandidateTestSchedule> getMedicalVacancy()
        {
            List<ICandidateTestSchedule> vList = new List<ICandidateTestSchedule>();
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_readMedicalVacancy_758575";

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    vList.Add(new CandidateTestSchedule(Convert.ToInt32(reader["VacancyId"].ToString())));
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
            return vList;
        }


    }
}