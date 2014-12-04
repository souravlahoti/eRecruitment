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
    public partial class WebForm6 : System.Web.UI.Page
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
            ICandidateTestScheduleManager i = CandidateTestScheduleManagerFactory.CreateDisplayManager();
            List<ICandidateTestSchedule> dis = i.Display();
            if (dis.Count == 0)
            {
                Label2.Text = "No Administrators available";
                Label2.Visible = true;
                Label3.Visible = false;
            }
            else
            {

                GridView1.DataSource = dis;
                GridView1.DataBind();
            }

            foreach (GridViewRow row in GridView1.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.Attributes.CssStyle["text-align"] = "center";
                }
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Grid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }


}

