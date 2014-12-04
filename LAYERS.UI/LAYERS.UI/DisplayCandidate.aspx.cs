using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LAYERS.TYPES;
using LAYERS.BLLFACTORY;
using LAYERS.BOFACTORY;
using LAYERS.DALFACTORY;

namespace LAYERS.UI
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IPlacementConsultant placementconsultant = PlacementConsultantBOFactory.createPlacement(702, "kamal", "ldh", "poiuy");
            Session["PlacementConsultantId"] = placementconsultant;

            if (!IsPostBack)
            {
                FillDropDown();
               // FillGridView();
            }
        }
        private void FillDropDown()
        {
            IVacancyManager obj = VacancyManagerFactory.Createvacancy();
            int placementid = 80001;
            List<IVacancy> vlist = obj.display(placementid);
            DropDownList1.DataSource = vlist;
            DropDownList1.DataTextField = "VacancyId";
            DropDownList1.DataValueField = "VacancyId";
            DropDownList1.DataBind();
        }
        private void FillGridView()
        {
            int vacancyid = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            IVacancy obj = VacancyBOFactory.create(vacancyid);
            ICandidateManager objt = CandidateManagerFactory.CreateCandidate();
            List<ICandidate> vlist = objt.display(obj);
            GridView1.DataSource = vlist;
            GridView1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Value == "-1")
            {
                GridView1.Visible = false;
            }
            else
            {
                FillGridView();
                GridView1.Visible = true;
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }

    }
}

