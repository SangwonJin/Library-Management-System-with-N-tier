using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace FrontEnd
{
    public partial class ResourceCheckOut : Form
    {
        private List<LoanLookUp> loans = new List<LoanLookUp>();
        private Student s;
        private Resource r;
        private Main main;
        private int resourceId;

        public ResourceCheckOut(Main m)
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
                    if (msg!=string.Empty)
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
                    txtEndDate.Text = s.EndDate.ToString();
                    txtStartDate.Text = s.StartDate.ToString();
                    txtBalanceDue.Text = s.BalanceDue.ToString("c");
                    chkIsActive.Checked = s.IsActive;

                    ListsBL listsBL = new ListsBL();
                    showDGV(listsBL.GetLoans(s.StudentId));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showDGV(List<LoanLookUp> loanLooks)
        {
            dgvCurrentLoans.DataSource = null;
            dgvCurrentLoans.DataSource = loanLooks;
        }
        private void GetResource(int resourceId)
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
                    StudentBL studentBL = new StudentBL();
                    Student s = studentBL.GetStudent(r.StudentId);
                    txtReservedStudend.Text = s.FirstName + " " + s.lastName;
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
        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResourceIdEntry.Text == string.Empty)
                {
                    MessageBox.Show("ResourceID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if (!int.TryParse(txtResourceIdEntry.Text,out int a))
                {
                    MessageBox.Show("ResourceID should be number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    GetResource(Convert.ToInt32(txtResourceIdEntry.Text));
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
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if(Form_Validation()!=string.Empty)
                {
                    MessageBox.Show(Form_Validation(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (loans.Count != 0)
                    {
                        foreach (LoanLookUp loan in loans.ToList())
                        {
                            GetResource(loan.ResourceId);
                            LoanBL loanBL = new LoanBL(s, r);
                            if (loanBL.Errors.Count == 0)
                            {
                                loan.StudendId = s.StudentId;
                                loan.ResourceId = r.ResourceId;
                                loan.CheckOutDate = DateTime.Now;

                                //Check Studend Status and overdueBalance

                                if (loanBL.ResourceTransaction(loan.CheckOutDate, loan.DueDate))
                                {
                                    DeleteLoans(loan.ResourceId);
                                    if (loans.Count == 0)
                                    {
                                        dgvList.DataSource = null;
                                        MessageBox.Show("Checkout worked!");
                                    }
                                    txtResourceStatus.Text = r.ResourceStatus.ToString();
                                }
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
                        ListsBL listsBL = new ListsBL();

                        showDGV(listsBL.GetLoans(s.StudentId));
                    }
                    else
                    {
                        MessageBox.Show("please add resources first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            LoanBL loanBL = new LoanBL(s,r);
            loanBL.Validation();

            if (loanBL.Errors.Count == 0)
            {
                loans.Add(new LoanLookUp()
                {
                    StudendId = txtStudentId.Text,
                    ResourceId = Convert.ToInt32(txtResourceIdEntry.Text),
                    CheckOutDate = DateTime.Now,
                });
                dgvList.DataSource = null;
                dgvList.DataSource = loans;
                DatagridViewSetting();
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

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && e.RowIndex >=0 && e.ColumnIndex>=0)
                {
                    if(int.TryParse(dgvList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(),out int a)){
                        resourceId = a;

                        ResourceBL resourceBL = new ResourceBL();
                        r = resourceBL.GetResource(a);
                        txtResourceIdEntry.Text = r.ResourceId.ToString();
                        txtResourceTitle.Text = r.Title;
                        txtResourceType.Text = r.ResourceType.ToString();
                        txtResourceStatus.Text = r.ResourceStatus.ToString();
                        chkIsReserved.Checked = r.IsReserved;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteLoans(resourceId);
        }
        private void DeleteLoans(int resourceId)
        {
            for (int i = 0; i < loans.Count; i++)
            {
                if (loans[i].ResourceId == resourceId)
                {
                    loans.RemoveAt(i);
                }
            }
            dgvList.DataSource = null;
            dgvList.DataSource = loans;
            DatagridViewSetting();
        }
        private void DatagridViewSetting()
        {
            //dgvList.Visible = false;
            dgvList.Columns[0].Visible = false;
            dgvList.Columns[1].Visible = true;
            dgvList.Columns[2].Visible = false;
            dgvList.Columns[3].Visible = false;
            dgvList.Columns[4].Visible = false;
            dgvList.Columns[5].Visible = false;
            dgvList.Columns[6].Visible = true;
            dgvList.Columns[7].Visible = false;
            dgvList.Columns[8].Visible = false;
        }
        private string Form_Validation()
        {
            string msg = "";
            if (txtSearchKeyword.Text == string.Empty)
            {
                msg = "StudendId is empty\n";
            }
            if (lstMatchingStudents.SelectedIndex == -1)
            {
                msg += "Please search studend first then select\n";
            }
            if (txtResourceIdEntry.Text == string.Empty)
            {
                msg += "ResourceId is empty\n";
            }
            return msg;
        }
    }
}
