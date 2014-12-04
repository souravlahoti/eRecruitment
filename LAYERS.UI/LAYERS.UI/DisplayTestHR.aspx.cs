using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//additional
using LAYERS.BOFACTORY;
using LAYERS.BLLFACTORY;
using LAYERS.TYPES;

namespace LAYERS.UI
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropDownList();
            }
        }
        private void FillGridView()
        {
            int vacancyId = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
            List<ICandidateTestSchedule> scheduleList = test.display(vacancyId);
            GridViewItems.DataSource = scheduleList;
            GridViewItems.DataBind();
        }

        private void FillDropDownList()
        {
            ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
            List<ICandidateTestSchedule> list = test.getVacancy();
            DropDownList1.DataSource = list;
            DropDownList1.DataTextField = "VacancyId";
            DropDownList1.DataValueField = "";
            DropDownList1.DataBind();

        }



        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Value == "Select")
            {}
            else
            {
                FillGridView();
            }
        }

        protected void GridViewItems_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridViewItems.PageIndex = e.NewPageIndex;
        }

    }
}

