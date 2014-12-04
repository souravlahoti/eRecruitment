using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAYERS.BO;
using LAYERS.TYPES;
using System.Data.SqlClient;
using System.Data;

namespace LAYERS.DAL
{
    public class CandidateTestDB : ICandidateTestDB
    {
        public List<ICandidateTestSchedule> viewTestCandidate(ICandidateTestSchedule vacancy)
        {
            List<ICandidateTestSchedule> candlist = new List<ICandidateTestSchedule>();
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_candidate_view_758575";
                cmd.Parameters.AddWithValue("@vacancyid", vacancy.VacancyId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    CandidateTestStatus i = new CandidateTestStatus(Convert.ToInt32(reader["CandidateID"].ToString()), Convert.ToInt32(reader["TestStatus"].ToString()), true);
                    candlist.Add(new CandidateTestSchedule(i, Convert.ToDateTime(reader["WrittenTestDate"].ToString()), Convert.ToDateTime(reader["TechnicalTestDate"].ToString()), Convert.ToDateTime(reader["HRInterviewDate"].ToString()), true));
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
            return candlist;
        }

        public List<ICandidateTestSchedule> viewMedicalCandidates(ICandidateTestSchedule vacancy)
        {
            List<ICandidateTestSchedule> candlistmedical = new List<ICandidateTestSchedule>();
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_candidate_view_medical_758575";
                cmd.Parameters.AddWithValue("@vacancyid", vacancy.VacancyId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    CandidateTestStatus i = new CandidateTestStatus(Convert.ToInt32(reader["CandidateID"].ToString()), Convert.ToInt32(reader["MedicalStatus"].ToString()), reader["MedicalCertificate"].ToString(), reader["Remarks"].ToString());
                    candlistmedical.Add(new CandidateTestSchedule(i, true, true));
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
            return candlistmedical;
        }

        public bool updateTestStatus(ICandidateTestSchedule testStatus)
        {
            bool isSaved = false;
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_candidate_update_758575";

                cmd.Parameters.AddWithValue("@can_id", testStatus.StatusObj.CandidateID);
                cmd.Parameters.AddWithValue("@newteststatus", testStatus.StatusObj.TestStatus);

                con.Open();
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

        public bool updateMedicalStatus(ICandidateTestSchedule testStatus)
        {
            bool isSaved = false;
            SqlConnection con = null;
            try
            {
                con = DBUtility.getConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_candidate_update_medical_758575";

                cmd.Parameters.AddWithValue("@can_id", testStatus.StatusObj.CandidateID);
                cmd.Parameters.AddWithValue("@newmedicalstatus", testStatus.StatusObj.MedicalTestStatus);
                cmd.Parameters.AddWithValue("@bgcCheckStatus", testStatus.StatusObj.BgcCheckStatus);
                cmd.Parameters.AddWithValue("@certificate", testStatus.StatusObj.Certificate);
                cmd.Parameters.AddWithValue("@remarks", testStatus.StatusObj.Remarks);
                cmd.Parameters.AddWithValue("@teststatus", testStatus.StatusObj.TestStatus);
                con.Open();
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
    }
}
