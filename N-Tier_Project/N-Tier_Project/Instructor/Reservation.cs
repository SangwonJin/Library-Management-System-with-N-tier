using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Reservation : Form
    {
        private Student s;
        private Resource r;
        private Main main;
        public Reservation(Main m)
        {
            main = m;
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchKeyword.Text == string.Empty)
                {
                    MessageBox.Show("StudendID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtSearchKeyword.Text.Length > 8)
                {
                    MessageBox.Show("StudendID cannot exceed length of 8", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListsBL listBL = new ListsBL();
                    lstMatchingStudents.DataSource = listBL.GetStudents(txtSearchKeyword.Text);
                    lstMatchingStudents.DisplayMember = "FullName";
                    lstMatchingStudents.ValueMember = "StudentId";

                    string msg = "";
                    foreach (ValidationError error in listBL.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    if (msg != string.Empty)
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtResourceIdEntry.Text == string.Empty)
                {
                    MessageBox.Show("ResourceID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!int.TryParse(txtResourceIdEntry.Text, out int a))
                {
                    MessageBox.Show("ResourceID should be number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetResourceAndPopulate(Convert.ToInt32(txtResourceIdEntry.Text));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lstMatchingStudents_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMatchingStudents.SelectedIndex == -1)
                {
                    MessageBox.Show("Please search studend first then select", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StudentBL studentBL = new StudentBL();
                    s = studentBL.GetStudent(lstMatchingStudents.SelectedValue.ToString());
                    string msg = "";

                    //Check Studend Status and overdueBalance
                    foreach (ValidationError error in studentBL.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }
                    if (msg != string.Empty)
                    {
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtStudentId.Text = s.StudentId;
                    txtProgramOption.Text = s.Program.ToString();
                    txtFirstName.Text = s.FirstName;
                    txtLastName.Text = s.lastName;
                    dtpEndDate.Value = s.EndDate;
                    dtpStartDate.Value = s.StartDate;
                    txtBalanceDue.Text = s.BalanceDue.ToString("c");
                    chkIsActive.Checked = s.IsActive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClearResource_Click(object sender, EventArgs e)
        {
            lstMatchingStudents.DataSource = null;
            txtResourceIdEntry.Clear();
            chkIsActive.Checked = false;
            txtResourceTitle.Clear();
            txtResourceType.Clear();
            txtResourceStatus.Clear();
            txtReservedStudend.Clear();
            chkIsReserved.Checked = false;
        }
        private void btnClearStudent_Click(object sender, EventArgs e)
        {
            txtSearchKeyword.Clear();
            txtStudentId.Clear();
            txtProgramOption.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpEndDate.Value = DateTime.Today;
            dtpStartDate.Value = DateTime.Today;
            txtBalanceDue.Clear();
        }
        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                LoanBL loanBL = new LoanBL(s, r);
                loanBL.Validation();

                if (loanBL.Errors.Count == 0)
                {
                    ResourceBL resourceBL = new ResourceBL();
                    if (resourceBL.changeReservation(r.ResourceId, s.StudentId, Convert.ToInt32(chkIsReserved.Checked)))
                    {
                        MessageBox.Show("Reserve changed!");
                    }
                    GetResourceAndPopulate(r.ResourceId);
                }
                else
                {
                    string msg = "";
                    foreach (ValidationError error in loanBL.Errors)
                    {
                        msg += error.Description + Environment.NewLine;
                    }

                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetResourceAndPopulate(int resourceId)
        {
            ResourceBL resourceBL = new ResourceBL();
            r = resourceBL.GetResource(resourceId);
            if (r != null)
            {
                txtResourceTitle.Text = r.Title;
                txtResourceType.Text = r.ResourceType.ToString();
                txtResourceStatus.Text = r.ResourceStatus.ToString();
                chkIsReserved.Checked = r.IsReserved;

                if (chkIsReserved.Checked == true)
                {
                    txtReservedStudend.Text = r.StudentId;
                }
                else
                {
                    txtReservedStudend.Text = "";
                }
            }
            else
            {
                string msg = "";

                foreach (ValidationError error in resourceBL.Errors)
                {
                    msg += error.Description + Environment.NewLine;
                }

                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
