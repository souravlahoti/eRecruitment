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
    public class VacancyRequestPCDB:IVacancyRequestPCDB
    {
       //Shivani 

        public List<IVacancyRequestPC> read(IPlacementConsultant placementconsultant)
        {
            List<IVacancyRequestPC> ivac = new List<IVacancyRequestPC>();
            SqlConnection conn = DBUtility.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_INSERT_Req_730844";
                conn.Open();
                cmd.Parameters.AddWithValue("@PlacementConsultantId", placementconsultant.PlacementConsultantId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    int VacreqPcId = Convert.ToInt32(reader["VacancyRequestPcId"].ToString());

                    int VacId = Convert.ToInt32(reader["VacancyId"].ToString());
                    int PlaceConId = Convert.ToInt32(reader["PlacementConsultantId"].ToString());
                    int RecId = Convert.ToInt32(reader["RecruitmentId"].ToString());


                    IVacancyRequestPC obj = VacancyRequestPCBOFactory.createVacReq(VacreqPcId, VacId, PlaceConId, RecId);
                    ivac.Add(obj);
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
            return ivac;
        }

    }
}
