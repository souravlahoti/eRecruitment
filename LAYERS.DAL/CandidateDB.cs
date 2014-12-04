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

namespace LAYERS.DAL
{
    public class CandidateDB:ICandidateDB
    {
        //Shivani


        public List<ICandidate> display(int id)
        {
            List<ICandidate> vac = new List<ICandidate>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_view_730844";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyID", id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //int cid = Convert.ToInt32(reader["CandidateId"].ToString());
                    int vacid = Convert.ToInt32(reader["VacancyID"].ToString());
                    string CandName = reader["CandidateName"].ToString();
                    DateTime date = Convert.ToDateTime(reader["dob"].ToString());
                    string loc = reader["Location"].ToString();
                    string gender = reader["Gender"].ToString();
                    float tenth = Convert.ToSingle(reader["Percentage10"].ToString());
                    float tweleth = Convert.ToSingle(reader["Percentage12"].ToString());
                    string gapiedu = reader["GapInEducation"].ToString();
                    string gapiexp = reader["GapInExperience"].ToString();
                    string res = reader["Resume1"].ToString();
                    int bgcid = Convert.ToInt32(reader["BGCID"].ToString());
                    string remarks = reader["Remarks"].ToString();

                    ICandidate c = CandidateBOFactory.addCandidateDetails(vacid, CandName, date, loc, gender, tenth, tweleth, gapiedu, gapiexp, res, bgcid, remarks);
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

        //Shivani

        public List<ICandidate> displayAllCandidate()
        {
            List<ICandidate> vacNew = new List<ICandidate>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_view_730844";
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //int cid = Convert.ToInt32(reader["CandidateId"].ToString());
                    int vacid = Convert.ToInt32(reader["VacancyID"].ToString());
                    string CandName = reader["CandidateName"].ToString();
                    DateTime date = Convert.ToDateTime(reader["dob"].ToString());
                    string loc = reader["Location"].ToString();
                    string gender = reader["Gender"].ToString();
                    float tenth = Convert.ToSingle(reader["Percentage10"].ToString());
                    float tweleth = Convert.ToSingle(reader["Percentage12"].ToString());
                    string gapiedu = reader["GapInEducation"].ToString();
                    string gapiexp = reader["GapInExperience"].ToString();
                    string res = reader["Resume1"].ToString();
                    int bgcid = Convert.ToInt32(reader["BGCID"].ToString());
                    string remarks = reader["Remarks"].ToString();

                    ICandidate c = CandidateBOFactory.addCandidateDetails(vacid, CandName, date, loc, gender, tenth, tweleth, gapiedu, gapiexp, res, bgcid, remarks);
                    vacNew.Add(c);
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
            return vacNew;

        }

        //Shivani

        public List<ICandidate> display(IVacancy vacancy)
        {
            List<ICandidate> vac2 = new List<ICandidate>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Display_730844";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyID", vacancy.vacid);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int cid = Convert.ToInt32(reader["CandidateID"].ToString());
                    int vacid = Convert.ToInt32(reader["VacancyID"].ToString());
                    string CandName = reader["CandidateName"].ToString();
                    DateTime date = Convert.ToDateTime(reader["DOB"].ToString());
                    string loc = reader["Location"].ToString();
                    string gender = reader["Gender"].ToString();
                    float tenth = Convert.ToSingle(reader["Percentage10"].ToString());
                    float tweleth = Convert.ToSingle(reader["Percentage12"].ToString());
                    string gapiedu = reader["GapInEducation"].ToString();
                    string gapiexp = reader["GapInExperience"].ToString();
                    string res = reader["Resume1"].ToString();
                    string bid=reader["BGCID"].ToString();
                    int bgcid = Convert.ToInt32(bid);
                    string remarks = reader["Remarks"].ToString();

                    ICandidate c = CandidateBOFactory.addCandidateDetails(cid, vacid, CandName, date, loc, gender, tenth, tweleth, gapiedu, gapiexp, res, bgcid, remarks);
                    vac2.Add(c);
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
            return vac2;
        }

        //Shivani

           

        //Shivani


        public bool edit(ICandidate candidate)
        {
            bool isEdited = false;
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_insert_730844";
                cmd.Parameters.AddWithValue("@VacancyID", candidate.VacancyId);
                cmd.Parameters.AddWithValue("@CandidateName", candidate.CandidateName);
                cmd.Parameters.AddWithValue("@DOB", candidate.Dob);
                cmd.Parameters.AddWithValue("@Location", candidate.Loc);
                cmd.Parameters.AddWithValue("@Gender", candidate.Gend);
                cmd.Parameters.AddWithValue("@Percentage10", candidate.Per10);
                cmd.Parameters.AddWithValue("@Percentage12", candidate.Per12);
                cmd.Parameters.AddWithValue("@GapInEducation", candidate.GapInEdu);
                cmd.Parameters.AddWithValue("@GapInExperience", candidate.GapInExp);
                cmd.Parameters.AddWithValue("@Resume1", candidate.Resume);
                cmd.Parameters.AddWithValue("@BGCID", candidate.BgcId);
                cmd.Parameters.AddWithValue("@Remarks", candidate.Remarks);

                con.Open();
                int iRowsAffected = cmd.ExecuteNonQuery();
                isEdited = (iRowsAffected > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return isEdited;
        }
        

        //Shivani

        public bool deleteCandidate(IVacancy vacancy)
        {
            bool isdeleted = false;
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Delete_730844";

                cmd.Parameters.AddWithValue("@VacancyID", vacancy.vacid);

                con.Open();
                int iRowsAffected = cmd.ExecuteNonQuery();
                isdeleted = (iRowsAffected > 0) ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return isdeleted;
        }




        //Chandan D Nadig
        //Display by PC
        public List<ICandidate> displayHR(ICandidate obj)
        {
            List<ICandidate> vac = new List<ICandidate>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PDisplay1_757860";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyID", obj.VacancyId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int cid = Convert.ToInt32(reader["CandidateID"].ToString());
                    string name = reader["CandidateName"].ToString();
                    DateTime date = Convert.ToDateTime(reader["DOB"].ToString());
                    string loca = reader["Location"].ToString();
                    string gender = reader["Gender"].ToString();
                    double tenth = Convert.ToDouble(reader["Percentage10"].ToString());
                    double tweleth = Convert.ToDouble(reader["Percentage12"].ToString());
                    string gapiedu = (reader["GapInEducation"].ToString());
                    string gapiexp = (reader["GapInExperience"].ToString());
                    string resume = reader["Resume1"].ToString();
                    ICandidate c = CandidateBOFactory.createCandidate(cid, name, date, loca, gender, tenth, tweleth, gapiedu, gapiexp, resume);
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

        //Chandan D Nadig
        //Display by HR
        public List<ICandidate> display(ICandidate obj1)
        {
            List<ICandidate> vac = new List<ICandidate>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PCandidateTestStatus_757860";
                conn.Open();
                cmd.Parameters.AddWithValue("@VacancyID", obj1.VacancyId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int cid = Convert.ToInt32(reader["CandidateID"].ToString());

                    string name = reader["CandidateName"].ToString();
                    DateTime date = Convert.ToDateTime(reader["DOB"].ToString());
                    string loca = reader["Location"].ToString();
                    string gender = reader["Gender"].ToString();
                    double tenth = Convert.ToDouble(reader["Percentage10"].ToString());
                    double tweleth = Convert.ToDouble(reader["Percentage12"].ToString());
                    string gapiedu = (reader["GapInEducation"].ToString());
                    string gapiexp = (reader["GapInExperience"].ToString());
                    string resume = reader["Resume1"].ToString();
                    int testScheduleId = Convert.ToInt32(reader["TestScheduleID"].ToString());
                    int testStatus = Convert.ToInt32(reader["TestStatus"].ToString());
                    ICandidateTestSchedule teststatus = CandidateTestScheduleFactory.createTest(testStatus,testScheduleId);
                    ICandidate c = CandidateBOFactory.createCandidate(cid, name, date, loca, gender, tenth, tweleth, gapiedu, gapiexp, resume, teststatus);
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

        //Chandan D Nadig
        //Update
        public bool update(ICandidate cus)
        {
            bool issaved = false;
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_PUpdate2_757860";
                cmd.Parameters.AddWithValue("@CandidateID", cus.CandidateId);
                cmd.Parameters.AddWithValue("@CandidateName", cus.CandidateName);
                cmd.Parameters.AddWithValue("@DOB", cus.Dob);
                cmd.Parameters.AddWithValue("@Location", cus.Loc);
                cmd.Parameters.AddWithValue("@Gender", cus.Gend);
                cmd.Parameters.AddWithValue("@Percentage10", cus.Per10);
                cmd.Parameters.AddWithValue("@Percentage12", cus.Per12);
                cmd.Parameters.AddWithValue("@GapInEducation", cus.GapInEdu);
                cmd.Parameters.AddWithValue("@GapInExperience", cus.GapInExp);
                cmd.Parameters.AddWithValue("@Resume1", cus.Resume);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    issaved = true;
                else
                    issaved = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return issaved;
        }
        //Chandan

    }
}

