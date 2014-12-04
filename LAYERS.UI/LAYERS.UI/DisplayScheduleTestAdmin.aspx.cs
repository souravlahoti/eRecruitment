using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LAYERS.BOFACTORY;
using LAYERS.BLLFACTORY;
using LAYERS.TYPES;
namespace LAYERS.UI
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        private void FillGridView()
        {
            int vacancyId = Convert.ToInt32(TextBox1.Text);
            ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
            List<ICandidateTestSchedule> scheduleList = test.display(vacancyId);
            GridViewItems.DataSource = scheduleList;
            GridViewItems.DataBind();
        }

        //private void FillDropDownList()
        //{
        //    ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
        //    List<ICandidateTestSchedule> list = test.getVacancy();
        //    DropDownList1.DataSource = list;
        //    DropDownList1.DataTextField = "VacancyId";
        //    DropDownList1.DataValueField = "";
        //    DropDownList1.DataBind();
       
        //}




        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            FillGridView();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int vacancyId = Convert.ToInt32(TextBox1.Text);
            ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
            List<ICandidateTestSchedule> scheduleList = test.display(vacancyId);
            if (scheduleList.Count == 0)
            {
                Label2.Visible = true;
            }
            else
            {
                Label2.Visible = false;
                FillGridView();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DisplayScheduleTestAdmin.aspx");
        }

        protected void GridViewItems_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewItems.PageIndex = e.NewPageIndex;
        }

    }
}
