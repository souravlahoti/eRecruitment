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
    public partial class WebForm4 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                getVacancyID();

            }
        }


        private void getVacancyID()
        {
            List<ICandidateTestSchedule> vList = new List<ICandidateTestSchedule>();
            List<int> v_list = new List<int>();
            IVacancyManager i = VacancyManagerFactory.createVacancyManager();

            // Login by test admin id :
            vList = i.createVacancyID(50010);
            foreach (ICandidateTestSchedule e in vList)
            {
                int v = Convert.ToInt32(e.VacancyId);
                v_list.Add(v);

            }
            VacancyDL.DataSource = v_list;
            VacancyDL.DataBind();

        }


        private void CandidateFill()
        {
            int value = Convert.ToInt32(VacancyDL.SelectedItem.Text);
            ICandidateTestSchedule i = CandidateTestFactory.createVacancy();
            i.VacancyId = value;
            List<ICandidateTestSchedule> candList = readDatabase(i);

            template.DataSource = candList;
            template.DataBind();
            if (candList.Count == 0)
                Response.Write(@"<script language='javascript'>alert('No Details Available.')</script>");



        }
        private List<ICandidateTestSchedule> readDatabase(ICandidateTestSchedule vacancy)
        {
            ICandidateTestManager i = CandidateTestManagerFactory.createCandidateTestManager();
            List<ICandidateTestSchedule> candlist = new List<ICandidateTestSchedule>();
            candlist = i.viewCandidateTestStatus(vacancy);
            return candlist;
        }

        protected void getCandidateDetails(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(VacancyDL.SelectedItem.Value)) != -1)
            {
                CandidateFill();
            }


        }


        protected void template_RowEditing(object sender, GridViewEditEventArgs e)
        {
            template.EditIndex = e.NewEditIndex;
            CandidateFill();
            GridViewRow row = template.Rows[e.NewEditIndex];

            int flag1 = 0, flag2 = 0, flag3 = 0;
            DropDownList dWrittenStatus = row.FindControl("editwrittenteststatusDL") as DropDownList;
            Label lWrittenDate = row.FindControl("hwrittendate") as Label;
            DateTime lwrittendate = Convert.ToDateTime(lWrittenDate.Text);
            if (System.DateTime.Today.ToShortDateString() == (lwrittendate.ToShortDateString()))
            {
                dWrittenStatus.Enabled = true;
            }
            else
            {
                dWrittenStatus.Enabled = false;
                dWrittenStatus.SelectedItem.Text = "Approved";
                flag1 = 1;

            }

            DropDownList dTechnicalStatus = row.FindControl("edittechinterviewstatusDL") as DropDownList;
            Label ltechnicalDate = row.FindControl("htechdate") as Label;

            if (System.DateTime.Today.ToShortDateString() == (Convert.ToDateTime(ltechnicalDate.Text).ToShortDateString()))
            {
                dTechnicalStatus.Enabled = true;
            }
            else
            {
                dTechnicalStatus.Enabled = false;
                if (dWrittenStatus.Enabled == true)
                    dTechnicalStatus.SelectedItem.Text = "Pending";
                else
                    dTechnicalStatus.SelectedItem.Text = "Approved";
                flag2 = 1;

            }

            DropDownList dHrStatus = row.FindControl("edithrinterviewstatusDL") as DropDownList;
            Label lHrDate = row.FindControl("hhrdate") as Label;


            if (System.DateTime.Today.ToShortDateString() == (Convert.ToDateTime(lHrDate.Text).ToShortDateString()))
            {
                dHrStatus.Enabled = true;
            }
            else
            {
                dHrStatus.Enabled = false;
                if (dWrittenStatus.Enabled == true || dTechnicalStatus.Enabled == true)
                    dHrStatus.SelectedItem.Text = "Pending";
                else
                    dHrStatus.SelectedItem.Text = "Approved";
                flag3 = 1;
            }

            if (flag1 == 1 && flag2 == 1 && flag3 == 1)
            {
                Response.Write(@"<script language='javascript'>alert('Cannot Edit Status')</script>");
                template.EditIndex = -1;
                CandidateFill();
            }
            else
            {

            }


        }


        protected void template_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            template.EditIndex = -1;
            CandidateFill();
        }

        protected void template_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            Response.Write(@"<script language='javascript'>alert('Details saved successfully')</script>");
        }

        protected void template_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int value;
            GridViewRow row = template.Rows[e.RowIndex];


            DropDownList dWrittenStatus = row.FindControl("editwrittenteststatusDL") as DropDownList;
            DropDownList dTechnicalStatus = row.FindControl("edittechinterviewstatusDL") as DropDownList;
            DropDownList dHrInterviewStatus = row.FindControl("edithrinterviewstatusDL") as DropDownList;
            if (dWrittenStatus.Enabled == true)
                value = Convert.ToInt32(dWrittenStatus.SelectedItem.Value);
            else if (dTechnicalStatus.Enabled == true)
                value = Convert.ToInt32(dTechnicalStatus.SelectedItem.Value);
            else
                value = Convert.ToInt32(dHrInterviewStatus.SelectedItem.Value);

            Label candidateId = row.FindControl("candidateId") as Label;
            int candidateid = Convert.ToInt32(candidateId.Text);


            ICandidateTestManager i = CandidateTestManagerFactory.createCandidateTestManager();
            ICandidateTestSchedule ic = CandidateTestFactory.createCandidate(candidateid, value);
            bool status = i.updateTestStatus(ic);
            if (dHrInterviewStatus.SelectedValue == "3")
            {
                value = 4;
                ic = CandidateTestFactory.createCandidate(candidateid, value);
                i.updateTestStatus(ic);
            }

            if (status)
                Response.Write(@"<script language='javascript'>alert('Details saved successfully')</script>");
            else
                Response.Write(@"<script language='javascript'>alert('Details not saved')</script>");
            template.EditIndex = -1;
            CandidateFill();


        }

        protected void template_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            template.PageIndex = e.NewPageIndex;
            CandidateFill();
        }

    }
}