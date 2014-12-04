using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using LAYERS.BO;
using LAYERS.TYPES;
using LAYERS.DAL;
using LAYERS.BLLFACTORY;
using LAYERS.BOFACTORY;
namespace LAYERS.UI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public enum Category
        {

            Pending = 0,

            Approved = 1,

            Rejected = 2

        }
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
            vList = i.createMedicalVacancyID();
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
            candlist = i.viewCandidatesMedicalTestStatus(vacancy);
            return candlist;
        }

        protected void getCandidateDetails(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(VacancyDL.SelectedItem.Value)) != -1)
            {
                CandidateFill();
            }
            else
            {
            }


        }

        protected void template_RowEditing(object sender, GridViewEditEventArgs e)
        {
            template.EditIndex = e.NewEditIndex;
            CandidateFill();



        }

        protected void template_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            template.EditIndex = -1;
            CandidateFill();
        }

        protected void template_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = template.Rows[e.RowIndex];
            DropDownList dStatus = row.FindControl("medicalteststatusDL") as DropDownList;
            Label candidateId = row.FindControl("candidateId") as Label;
            FileUpload file = row.FindControl("FileUpload1") as FileUpload;
            int CandidateId = Convert.ToInt32(candidateId.Text);
            int medicalTestStatus = Convert.ToInt32(dStatus.Text);
            string certificate = "";
            string strFileExtention = System.IO.Path.GetExtension(file.PostedFile.FileName).ToUpper();
            if (file.HasFile)
            {
                try
                {
                    if (strFileExtention == ".pdf".ToUpper() || strFileExtention == ".doc".ToUpper())
                    {

                        string filename = Path.GetFileName(file.PostedFile.FileName);
                        certificate = filename;
                        string path = Server.MapPath("Files") + "\\" + filename;
                        file.PostedFile.SaveAs(path);
                        // Response.Write(@"<script language='javascript'>alert('File Uploaded')</script>");
                    }
                    else
                        Response.Write(@"<script language='javascript'>alert('Upload status: The file format not matched.Only pdf and doc file allowed')</script>");
                }
                catch (Exception ex)
                {
                    Response.Write(@"<script language='javascript'>alert('Upload status: The file could not be uploaded.')</script>");
                }
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Upload status: The file has not been uploaded.')</script>");
            }

            if (file.HasFile)
            {
                if (strFileExtention == ".pdf".ToUpper() || strFileExtention == ".doc".ToUpper())
                {
                    int bgcCheckStatus;
                    if (medicalTestStatus == 2)
                        bgcCheckStatus = 0;
                    else
                        bgcCheckStatus = 1;

                    string remarks;
                    TextBox remarksstatus = row.FindControl("remarks") as TextBox;
                    if (remarksstatus.Text.ToString() == null)
                        remarks = "Approved ";
                    else
                        remarks = remarksstatus.Text.ToString();

                    int teststatus = 4;
                    ICandidateTestManager i = CandidateTestManagerFactory.createCandidateTestManager();
                    if (dStatus.SelectedItem.Text == "Approved")
                        teststatus = 5;
                    else
                        teststatus = 4;
                    ICandidateTestSchedule ic = CandidateTestFactory.createCandidate(CandidateId, medicalTestStatus, bgcCheckStatus, certificate, remarks, teststatus);
                    bool status = i.updateMedicalStatus(ic);
                    if (status)
                        Response.Write(@"<script language='javascript'>alert('Details saved successfully')</script>");
                    else
                        Response.Write(@"<script language='javascript'>alert('Details not saved')</script>");
                    template.EditIndex = -1;
                    CandidateFill();
                }
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Details not updated.Please upload Medical certificate')</script>");
            }
        }




        protected void template_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            template.PageIndex = e.NewPageIndex;
            CandidateFill();
        }

        protected void template_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //Mam code
        }
    }
}

