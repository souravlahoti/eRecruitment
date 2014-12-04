using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//additional

using LAYERS.BLLFACTORY;
using LAYERS.BOFACTORY;
using LAYERS.TYPES;

namespace LAYERS.UI
{
    public partial class WebForm10 : System.Web.UI.Page
    {

        int error = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                FillDropDownList();
            }
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


        private void FillTextbox()
        {
            int vacancyId = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            ICandidateTestSchedule vacancyObj = CandidateTestScheduleFactory.VacancyId(vacancyId);
            ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
            List<ICandidateTestSchedule> list = test.fetchTestDates(vacancyObj);
            foreach (ICandidateTestSchedule e in list)
            {
                Label10.Visible = true;
                Label10.Text = e.DateObj.Rbd.ToShortDateString();
                TextBox1.Text = e.WrittenTestDate.ToShortDateString();
                TextBox2.Text = e.TechnicalTestDate.ToShortDateString();
                TextBox3.Text = e.HrInterviewDate.ToShortDateString();
            }
        }

        private void checkValidation()
        {
            DateTime WrittenTest = DateTime.Now, TechnicalDate = DateTime.Now, HrDate = DateTime.Now;
            int vacancyId = Convert.ToInt32(DropDownList1.SelectedItem.Value);
            ICandidateTestSchedule vacancyObj = CandidateTestScheduleFactory.VacancyId(vacancyId);
            ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
            List<ICandidateTestSchedule> list = test.fetchTestDates(vacancyObj);
            foreach (ICandidateTestSchedule e in list)
            {
                WrittenTest = Convert.ToDateTime(e.WrittenTestDate.ToShortDateString());
                TechnicalDate = Convert.ToDateTime(e.TechnicalTestDate.ToShortDateString());
                HrDate = Convert.ToDateTime(e.HrInterviewDate.ToShortDateString());
            }
            DateTime writeDate = Convert.ToDateTime(TextBox1.Text);
            DateTime techDate = Convert.ToDateTime(TextBox2.Text);
            DateTime hrDate = Convert.ToDateTime(TextBox3.Text);
            DateTime requireDate = Convert.ToDateTime(Label10.Text);
            TimeSpan b = (requireDate - hrDate);

            if ((writeDate.Day - WrittenTest.Day) > 2 || (writeDate.Day - WrittenTest.Day) < 0)
            {
                error = 1;
                Label6.Visible = true;
                Label6.Text = "New Date must be between " + WrittenTest.ToShortDateString() + " and " + WrittenTest.AddDays(2).ToShortDateString();
            }
            else if ((techDate.Day - TechnicalDate.Day) > 2 || (techDate.Day - TechnicalDate.Day) < 0)
            {
                Label6.Visible = false;
                error = 1;
                Label7.Visible = true;
                Label7.Text = "New Date must be between " + TechnicalDate.ToShortDateString() + " and " + writeDate.AddDays(2).ToShortDateString(); TechnicalDate.ToShortDateString();
            }
            else if ((hrDate.Day - HrDate.Day) > 2 || (hrDate.Day - HrDate.Day) < 0)
            {
                Label7.Visible = false;
                error = 1;
                Label8.Visible = true;
                Label8.Text = "New Date must be between " + HrDate.ToShortDateString() + " and " + techDate.AddDays(2).ToShortDateString();
            }

            else if (b.Days < 7)
            {
                error = 1;

                Response.Write(@"<script>alert('HR Interview Date should be conducted one week before Required by date')</script>");
            }
            else
            {
                Label6.Visible = false;
                Label7.Visible = false;
                Label8.Visible = false;
                error = 0;
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTextbox();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            checkValidation();
            if (error == 1)
            {
                if (Label6.Visible == true)
                    TextBox1.Focus();
                else if (Label7.Visible == true)
                    TextBox2.Focus();
                else if (Label8.Visible == true)
                    TextBox3.Focus();
            }

            if (error == 0)
            {
                int vacancyId = Convert.ToInt32(DropDownList1.SelectedItem.Value);
                DateTime writtenTestDate = Convert.ToDateTime(TextBox1.Text);
                DateTime technicalTestDate = Convert.ToDateTime(TextBox2.Text);
                DateTime hrTestDate = Convert.ToDateTime(TextBox3.Text);
                ICandidateTestSchedule editObj = CandidateTestScheduleFactory.disTestSchedule(vacancyId, writtenTestDate, technicalTestDate, hrTestDate);
                ICandidateTestScheduleManager test = CandidateTestScheduleManagerFactory.createScheduleManager();
                bool editStatus = test.editTest(editObj);
                if (editStatus == true)
                {
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    Label10.Visible = false;
                    DropDownList1.SelectedIndex = 0;
                    Response.Write("<script>alert('Data updated successfully.')</script>");

                }
                else
                    Response.Redirect("EditTestSchedule.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditTestSchedule.aspx");
        }


    }
}