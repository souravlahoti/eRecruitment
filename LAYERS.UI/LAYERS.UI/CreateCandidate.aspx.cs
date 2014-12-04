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
    public partial class WebForm13 : System.Web.UI.Page
    {
       // int Error = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            IPlacementConsultant placementconsultant = PlacementConsultantBOFactory.createPlacement(80001, "kamal", "ldh", "poiuy");
            Session["PlacementConsultantId"] = placementconsultant;


            if (!IsPostBack)
            {
                FillDropDown();
            }

        }
        private void FillDropDown()
        {
            IVacancyManager obj = VacancyManagerFactory.Createvacancy();
            int placementid=80002;
            List<IVacancy> vlist = obj.display(placementid);

            DropDownList1.DataSource = vlist;
            DropDownList1.DataTextField = "vacid";
            DropDownList1.DataValueField = "vacid";
            DropDownList1.DataBind();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vacid = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            IVacancyManager ivacmgr = VacancyManagerFactory.Createvacancy();
            IVacancy ivacdb = VacancyBOFactory.create(vacid);
            bool isRequiredByDate = ivacmgr.requiredByDate(ivacdb);
            if (isRequiredByDate == true)
            {
                LabelMessage.Text = "Candidate can not be entered , minimum gap should be 3 weeks ";
                LabelMessage.Visible = true;
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                TextBox3.Enabled = false;
                TextBox5.Enabled = false;
                TextBox6.Enabled = false;
                DropDownList4.Enabled = false;
                TextBox7.Enabled = false;
                DropDownList3.Enabled = false;
                TextBox8.Enabled = false;
                Button2.Visible = true;
            }
            else
            {
                TextBox1.Enabled = true;
                TextBox2.Enabled = true;
                TextBox3.Enabled = true;
                TextBox5.Enabled = true;
                TextBox6.Enabled = true;
                DropDownList4.Enabled = true;
                TextBox7.Enabled = true;
                DropDownList3.Enabled = true;
                TextBox8.Enabled = true;
                //Button2.Visible = true;
            }

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((DropDownList3.SelectedItem.Text == "1") || (DropDownList3.SelectedItem.Text == "2"))
            {
                TextBox8.Visible = true;
            }
            else
            {
                TextBox8.Visible = false;
            }

        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((DropDownList4.SelectedItem.Text == "1") || (DropDownList4.SelectedItem.Text == "2"))
            {
                TextBox7.Visible = true;
            }
            else
            {
                TextBox7.Visible = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int vacancyid = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            string candidatename = TextBox1.Text;
            DateTime dob = Convert.ToDateTime(TextBox2.Text);
            string location = TextBox3.Text;
            string gender = null;
            if (RadioButton2.Checked)
            {
                gender = RadioButton2.Text;
            }
            if (RadioButton3.Checked)
            {
                gender = RadioButton3.Text;
            }
            float percentage10 = Convert.ToSingle(TextBox5.Text);
            float percentage12 = Convert.ToSingle(TextBox6.Text);
            string gapinedu = "no gap";
            if ((DropDownList4.SelectedItem.Text == "1") || (DropDownList4.SelectedItem.Text == "2"))
            {
                gapinedu = TextBox7.Text;
            }
            string gapinexp = "no gap";
            if ((DropDownList3.SelectedItem.Text == "1") || (DropDownList3.SelectedItem.Text == "2"))
            {
                gapinexp = TextBox8.Text;
            }
            string fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
            string path = Server.MapPath("Resume") + "\\" + fn;
            if (FileUpload1.HasFile)
            {
                FileUpload1.PostedFile.SaveAs(path);
            }
            string resume = fn;

            //Check for candidate existence
            ICandidateManager check = CandidateManagerFactory.Addcandidatedetails();
            IVacancy vacancyId = VacancyBOFactory.create(vacancyid);
            List<ICandidate> candidatedetails = new List<ICandidate>();
            int flag = 0;
            int count = 0;


            candidatedetails = check.display(vacancyId);
            foreach (ICandidate c in candidatedetails)
            {
                if (c.CandidateName == candidatename && c.Dob == dob && c.Loc == location)
                    flag = 1;


            }

            if (flag == 1)
            {
                Response.Write(@"<script>alert('Candidate already exist');</script>");
            }
            else
            {
                //1st Candidate
                foreach (ICandidate c in candidatedetails)
                    count++;
                if (count == 1)
                {
                    dataEntry(vacancyid, candidatename, dob, location, gender, percentage10, percentage12, gapinedu, gapinexp, resume);
                    IVacancyManager ivac = VacancyManagerFactory.Createvacancy();
                    IVacancy ivac1 = VacancyBOFactory.create(vacancyid);
                    bool isupdated = ivac.updatedVacancyToSource(ivac1);

                }
                else
                {
                    IVacancyManager ivm = VacancyManagerFactory.Createvacancy();
                    List<IVacancy> result = new List<IVacancy>();
                    result = ivm.totalCandidates(vacancyId);
                    int value = 0;
                    foreach (IVacancy ex in result)
                        value = Convert.ToInt32(ex.Nop);
                    int minValue = value + ((20 * value) / 100);
                    int maxValue = value + ((50 * value) / 100);
                    //Count != maxvalue 
                    if (count != maxValue)
                        dataEntry(vacancyid, candidatename, dob, location, gender, percentage10, percentage12, gapinedu, gapinexp, resume);

                    //check for in between
                    if ((count >= minValue) && (count < maxValue))
                    {
                        Button3.Visible = true;

                        //dataEntry(vacancyid, candidatename, dob, location, gender, percentage10, percentage12, gapinedu, gapinexp, resume);

                    }
                    //check for last value
                    if (count == maxValue)
                    {


                        LabelMessage.Text = "Vacancy filled";
                        LabelMessage.Visible = true;
                        TextBox1.Enabled = false;
                        TextBox2.Enabled = false;
                        TextBox3.Enabled = false;
                        TextBox5.Enabled = false;
                        TextBox6.Enabled = false;
                        DropDownList4.Enabled = false;
                        TextBox7.Enabled = false;
                        DropDownList3.Enabled = false;
                        TextBox8.Enabled = false;
                        IVacancyManager ivac = VacancyManagerFactory.Createvacancy();
                        IVacancy ivac2 = VacancyBOFactory.create(vacancyid);
                        bool isupdated = ivac.updatedVacancyToFilled(ivac2);
                    }

                }
            }




        }

        protected void dataEntry(int vacancyid, string candidatename, DateTime dob, string location, string gender, float percentage10, float percentage12, string gapinedu, string gapinexp, string resume)
        {
            ICandidateManager ican = CandidateManagerFactory.CreateCandidate();
            ICandidate obj = CandidateBOFactory.createCandidate(vacancyid, candidatename, dob, location, gender, percentage10, percentage12, gapinedu, gapinexp, resume, 0, "null");
            bool isedit = ican.edit(obj);
            if (isedit)
            {


                TextBox1.Text = " ";
                TextBox2.Text = " ";
                TextBox3.Text = " ";
                RadioButton2.Text = " ";
                RadioButton3.Text = " ";
                TextBox5.Text = " ";
                TextBox6.Text = " ";

                TextBox7.Text = " ";
                TextBox8.Text = " ";



                LabelMessage.Visible = true;
                LabelMessage.Text = "Candidate Saved";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int VACID = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            IVacancy VAC = VacancyBOFactory.create(VACID);
            ICandidateManager CANDMGR = CandidateManagerFactory.CreateCandidate();
            bool isdeleted = CANDMGR.deleteCandidate(VAC);
            LabelMessage.Text = "Vacancy cancelled";
            LabelMessage.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           

            LabelMessage.Text = " Candidate added successfully";           
            LabelMessage.Visible = true;
            int VACID = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            IVacancyManager ivac = VacancyManagerFactory.Createvacancy();
            IVacancy ivac2 = VacancyBOFactory.create(VACID);
            bool isupdated = ivac.updatedVacancyToFilled(ivac2);
            LabelMessage.Text = "Candidate Saved";

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

            DateTime date = DateTime.Now;
            DateTime d = Convert.ToDateTime(TextBox2.Text);
            int years = date.Year - d.Year;
            if (years < 18)
            {
               // Error = 1;
                args.IsValid = true;
            }

        }
    }


}