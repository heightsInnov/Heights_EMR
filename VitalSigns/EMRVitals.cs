using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VitalSigns
{
    public partial class VitalSign : Form
    {
        heightsemr_dbEntities db = new heightsemr_dbEntities();
        public VitalSign()
        {
            InitializeComponent();
            Enabled_Pnl(summarySearchPanel);
        }

        private void Enabled_Pnl(Panel n)
        {
            try
            {
                Panel[] _tabs = { vitalSignPanel, summarySearchPanel };
                foreach (Panel t in _tabs)
                {
                    if (n == t)
                    {
                        t.Visible = true;
                    }
                    else
                    {
                        t.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }
        protected string BMIInterpretation(double BMI)
        {
            StringBuilder interpretation = new StringBuilder();
            if (BMI < 18.5)
                interpretation.Append("UNDERWEIGHT");
            else if (BMI >= 18.5 && BMI <= 24.9)
                interpretation.Append("HEALTHY WEIGHT");
            else if (BMI >= 25.0 && BMI <= 29.9)
                interpretation.Append("OVERWEIGHT");
            else if (BMI > 30.0)
                interpretation.Append("OBESE");
            return interpretation.ToString();


        }
        private void link_btnBMI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (txtWeight.Text.Trim().Equals(""))
                {
                    MessageBox.Show("You must enter the Weight in Kg to calculate BMI!");
                    return;
                }
                if (txtHeight.Text.Trim().Equals(""))
                {
                    MessageBox.Show("You must enter the Height in Metres to calculate BMI!");
                    return;
                }

                double weight = Convert.ToDouble(txtWeight.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                double Calc = weight / (Math.Pow(height, 2));
                double BMI = Math.Round(Calc, 1);

                lblBMI.Text = BMI.ToString();
                BMIlabel.Text = BMIInterpretation(BMI);
                MessageBox.Show(string.Format("Patient's BMI is - {0:0.0} - {1}", BMI, BMIInterpretation(BMI)));
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
        }

        private void btn_sSearch_Click(object sender, EventArgs e)
        {
            if (txt_Filter.Text != "")
            {
                string query = string.Format("SELECT * FROM PATIENT WHERE (PATIENTID + ' ' + LASTNAME + ' ' + FIRSTNAME + ' ' + MOBILEPHONE) LIKE '%{0}%'", txt_Filter.Text);
                var data = db.Database.SqlQuery<Patient>(query).ToList();
                var data1 = (from d in data
                             select new { d.patientid, d.hmono1, d.lastname, d.firstname, d.middlename, d.dob, d.gender, d.mobilephone, d.email, d.hmoname1 }).ToList();

                if (data.Any())
                {
                    sSearchGrid.DataSource = data1;
                    sSearchGrid.Visible = true;
                }
                else { MessageBox.Show("No record found, Try again!"); }
            }
        }

        private void sSearchGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in sSearchGrid.SelectedRows)
                {
                    string pid = row.Cells["patientid"].Value.ToString();
                    var data = db.Patients.Where(p => p.patientid == pid).FirstOrDefault();
                    var card = db.enrollee_type.Where(r => r.ID == data.cardtypeid).Select(c => c.type).FirstOrDefault();
                    var vs = (from v in db.VitalSigns
                              where v.patientid == pid
                              orderby v.dateadded
                              select new { v.temperature, v.pulse, v.bloodpressure, v.respiration, v.weight, v.height, v.BMI,  v.dateadded }).ToList();
                    //Load Demograph
                    lblName.Text = (string.Format("{0}  {1}", data.firstname, data.lastname)).ToUpper();
                    if (data.hmoname1 != null) lblHmoname.Text = data.hmoname1;
                    lblCardNumber.Text = (data.patientid).ToUpper();
                    if (data.hmono1 != null) lblHmoid.Text = (data.hmono1).ToUpper();
                    if (data.dob != null) lblDOB.Text = data.dob.ToString();
                    if(data.servicetype != null) lblServiceType.Text = (data.servicetype).ToUpper();
                    if (data.plantype != null) lblPlanType.Text = (data.plantype).ToUpper();
                    lblPatientType.Text = (card).ToUpper();

                    gridVitals.DataSource = vs;
                }
                sSearchGrid.Visible = false;
                Enabled_Pnl(vitalSignPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error,contact Administrator!");
            }
        }

        private void link_btnPatientFinder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Enabled_Pnl(summarySearchPanel);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblBMI.Text == "")
            {
                MessageBox.Show("Calculate BMI before proceed!");
                return;
            }

            VitalSign vs = new VitalSign();

            vs.temperature = txtTemperature.Text;
            vs.pulse = txtPulse.Text;
            vs.respiration = txtResp.Text;
            vs.bloodpressure = txtBP.Text;
            vs.weight = txtWeight.Text;
            vs.height = txtHeight.Text;
            vs.BMI = lblBMI.Text;
            vs.dateadded = DateTime.Now;
            //if(staffID.Text != null || staffID.Text.Trim() != "")
            //{
            //    vs.staffid = Convert.ToInt32(staffID.Text);
            //}

            db.VitalSigns.Add(vs);
            db.SaveChanges();
            MessageBox.Show("Saved Successfully!");
            gridVitals.Refresh();
        }
    }
}
