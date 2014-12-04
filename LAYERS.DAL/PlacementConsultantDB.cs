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
    public class PlacementConsultantDB : IPlacementConsultantDB
    {
        //Shivani
        //        public IPlacementConsultant Read()
        //        {
        //            IPlacementConsultant obj = PlacementConsultantBOFactory.createPlacement1();
        //            SqlConnection conn = DBUtility.getConnection();
        //            try
        //            {
        //                SqlCommand cmd = new SqlCommand();
        //                cmd.Connection = conn;
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.CommandText = "SP_insertPlacement_730844";
        //                conn.Open();

        //                SqlDataReader reader = cmd.ExecuteReader();
        //                while (reader.Read())
        //                {

        //                    int placeconid = Convert.ToInt32(reader["placementConsultantId"].ToString());
        //                    string placeconName = reader["placementConsultantName"].ToString();
        //                    string placeconlocation = reader["placementConsultantLocation"].ToString();
        //                    string placeconpass = reader["placementConsultantPassword"].ToString();
        //                    obj = PlacementConsultantBOFactory.createPlacement(placeconid, placeconName, placeconlocation, placeconpass);

        //                }


        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            finally
        //            {
        //                conn.Close();
        //            }
        //            return obj;
        //        }
        //    }
    }
}
