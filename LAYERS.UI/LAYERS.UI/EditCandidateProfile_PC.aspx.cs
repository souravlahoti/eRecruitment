using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LAYERS.BOFACTORY;
using LAYERS.TYPES;
using LAYERS.BLLFACTORY;
using System.IO;

namespace LAYERS.UI
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label12.Visible = false;
            if (!IsPostBack)
            {
                FillDropDownList1();
                Label14.Visible = false;
            }
        }

        private void FillDropDownList1()
        {
            IVacancyManager obj = VacancyManagerFactory.CreateVacancyDBManager();
            List<IVacancy> list = obj.Display();
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
                Label14.Visible = true;
            }
            else
            {
                int vid = Convert.ToInt32(DropDownList1.SelectedItem.Text);
                ICandidate obj1 = CandidateBOFactory.createCandidate(vid);
                ICandidateManager obj = CandidateManagerFactory.CreateCandidateManager();
                List<ICandidate> list = obj.display(obj1);
                if (list.Count == 0)
                {
                    Label12.Visible = true;
                    FillGridViewItems();
                }
                else
                {
                    FillGridViewItems();
                    GridView1.Visible = true;
                }

                Label14.Visible = false; 
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillGridViewItems();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];

            Label cid = row.FindControl("Label11") as Label;
            TextBox name = row.FindControl("TextBox1") as TextBox;
            TextBox dob = row.FindControl("TextBox2") as TextBox;
            TextBox location = row.FindControl("TextBox3") as TextBox;
            DropDownList gender = row.FindControl("DropDownList2") as DropDownList;
            TextBox tenth = row.FindControl("TextBox5") as TextBox;
            TextBox tweleth = row.FindControl("TextBox6") as TextBox;
            TextBox gapinedu = row.FindControl("TextBox7") as TextBox;
            TextBox gapinexp = row.FindControl("TextBox8") as TextBox;
            FileUpload resume = row.FindControl("Button1") as FileUpload;

            int cid1 = Convert.ToInt32(cid.Text);
            string newname = name.Text;
            DateTime newdob = Convert.ToDateTime(dob.Text);
            string loca = location.Text;
            string gend = gender.SelectedItem.Text;
            double ten = Convert.ToDouble(tenth.Text);
            double twe = Convert.ToDouble(tweleth.Text);
            string gapedu = gapinedu.Text;
            string gapexp = gapinexp.Text;
            string res = Path.GetFileName(resume.FileName);

            ICandidate obj1 = CandidateBOFactory.createCandidate(cid1, newname, newdob, loca, gend, ten, twe, gapedu, gapexp, res);
            ICandidateManager obj = CandidateManagerFactory.CreateCandidateManager();
            obj.Update(obj1);
            GridView1.EditIndex = -1;
            FillGridViewItems();
            Label1.Visible = true;

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillGridViewItems();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            FillGridViewItems();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlGapinEducation = sender as DropDownList;
            if (ddlGapinEducation.SelectedItem.Text == "Yes")
            {
                GridViewRow row = ddlGapinEducation.Parent.Parent as GridViewRow;
                TextBox textBoxGapinEdu = row.FindControl("TextBox7") as TextBox;
                textBoxGapinEdu.Visible = true;
            }
            if (ddlGapinEducation.SelectedItem.Text == "No")
            {
                GridViewRow row = ddlGapinEducation.Parent.Parent as GridViewRow;
                TextBox textBoxGapinEdu = row.FindControl("TextBox7") as TextBox;
                textBoxGapinEdu.Visible = false;
                textBoxGapinEdu.Text = "No Gap";
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddlGapinExperience = sender as DropDownList;
            if (ddlGapinExperience.SelectedItem.Text == "Yes")
            {
                GridViewRow row = ddlGapinExperience.Parent.Parent as GridViewRow;
                TextBox textBoxGapinExp = row.FindControl("TextBox8") as TextBox;
                textBoxGapinExp.Visible = true;
            }
            if (ddlGapinExperience.SelectedItem.Text == "No")
            {
                GridViewRow row = ddlGapinExperience.Parent.Parent as GridViewRow;
                TextBox textBoxGapinExp = row.FindControl("TextBox8") as TextBox;
                textBoxGapinExp.Visible = false;
                textBoxGapinExp.Text = "No Gap";
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowState & DataControlRowState.Edit) > 0)
            {
                GridViewRow row = e.Row;

                TextBox textboxGapinEdu = row.FindControl("TextBox7") as TextBox;
                TextBox textboxGapinExp = row.FindControl("TextBox8") as TextBox;
                textboxGapinEdu.Visible = false;
                textboxGapinExp.Visible = false;
            }
        }

        protected void DropDownList3_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}