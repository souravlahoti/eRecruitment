using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LAYERS.BLL;
using LAYERS.BO;
using LAYERS.DAL;
using LAYERS.TYPES;
using LAYERS.DALFACTORY;
using LAYERS.BLLFACTORY;

namespace LAYERS.UI
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string x;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillDropDownList1();

            }

        }


        private void FillDropDownList1()
        {
            ICandidateTestScheduleManager manager = CandidateTestScheduleManagerFactory.createmanager();
            List<IVacancy> listitem = manager.SelectVacancy();
            DropDownList1.DataSource = listitem;
            DropDownList1.DataTextField = "VacancyId";
            DropDownList1.DataValueField = "SkillSet";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select");
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label6.Visible = false;
            Label7.Visible = false;
            TextBox1.Text = DropDownList1.SelectedValue;
            TextBox2.Text = " ";
            x = TextBox1.Text;
            ICandidateTestScheduleManager manager = CandidateTestScheduleManagerFactory.createmanager();
            List<IEmployee> list = manager.SelectEmployee(x);
            int count = list.Count;
            if (count == 0)
            {
                Label7.Visible = true;
            }
            GridView1.DataSource = list;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            TextBox2.Text = GridView1.SelectedDataKey.Value.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int vacancyid = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            int testadminid = Convert.ToInt32(GridView1.SelectedDataKey.Value.ToString());
            ICandidateTestScheduleManager manager = CandidateTestScheduleManagerFactory.createmanager();
            ICandidateTestSchedule i = new CandidateTestSchedule(testadminid, vacancyid);
            manager.InsertTest(i);
            Label6.Visible = true;
            FillDropDownList1();
            TextBox1.Text = " ";
            TextBox2.Text = " ";
           
           
       }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("TestAdministrator.aspx");
           
        }

    }
}