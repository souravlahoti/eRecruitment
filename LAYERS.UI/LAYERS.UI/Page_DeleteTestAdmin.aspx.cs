using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LAYERS.BO;
using LAYERS.TYPES;
using LAYERS.DAL;
using LAYERS.BLLFACTORY;
using LAYERS.BOFACTORY;
namespace LAYERS.UI
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Grid();
            }
        }
        private void Grid()
        {
            ICandidateTestScheduleManager j = CandidateTestScheduleManagerFactory.CreateDisplayManager();
            List<ICandidateTestSchedule> dis1 = j.Display();


            GridView1.DataSource = dis1;
            GridView1.DataBind();

            foreach (GridViewRow row in GridView1.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.Attributes.CssStyle["text-align"] = "center";
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ICandidateTestScheduleManager manager = CandidateTestScheduleManagerFactory.CreateDisplayManager();
            int x = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            ICandidateTestSchedule cs = new CandidateTestSchedule(x,1);
            // Label1.Text = cs.TestAdminId.ToString();
            int y = manager.delete(cs);
            if (y > 0)
                Response.Write(@"<script>alert('Successfully deleted')</script>");
            else
                Response.Write(@"<script>alert('Deletion Failed. Test Admin is already assigned to a test')</script>");
            GridView1.EditIndex = -1;
            Grid();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}