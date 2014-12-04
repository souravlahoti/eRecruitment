using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Collections.Generic;

using LAYERS.BOFACTORY;
using LAYERS.TYPES;
using LAYERS.BLLFACTORY;

namespace LAYERS.UI
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        public enum Category
        {
            NotInitiated = 0,
            WrittenTestConducted = 1,
            WrittenTest_TechnicalInterviewConducted = 2,
            WrittenTest_TechnicalInterview_HRInterviewConducted = 3,
            MedicalTesting = 4,
            AwaitingBGC = 5,
            Confirmed = 6,
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label11.Visible = false;
            if (!IsPostBack)
            {
                FillDropDownList1();
                Label12.Visible = false;
            }
        }

        private void FillDropDownList1()
        {
            IVacancyManager obj = VacancyManagerFactory.CreateVacancyDBManager();
            List<IVacancy> list = obj.displayHR();
            DropDownList1.DataSource = list;
            DropDownList1.DataTextField = "VacancyId";
            DropDownList1.DataValueField = "VacancyId";
            DropDownList1.DataBind();
        }

        private void FillGridViewItems()
        {

            int vid = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            ICandidate obj1 = CandidateBOFactory.createCandidate(vid);
            ICandidateManager obj = CandidateManagerFactory.CreateCandidateManager();
            List<ICandidate> list = obj.display(obj1);
            GridView1.DataSource = list;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedItem.Text == "select")
            {
                GridView1.Visible = false;
                Label12.Visible = true;
            }
            else
            {
                int vid = Convert.ToInt32(DropDownList1.SelectedItem.Text);
                ICandidate obj1 = CandidateBOFactory.createCandidate(vid);
                ICandidateManager obj = CandidateManagerFactory.CreateCandidateManager();
                List<ICandidate> list = obj.display(obj1);
                if (list.Count == 0)
                {
                    Label11.Visible = true;
                    FillGridViewItems();
                }
                else
                {
                    FillGridViewItems();
                    GridView1.Visible = true;
                }
                Label12.Visible = false;
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }

       
    }
}