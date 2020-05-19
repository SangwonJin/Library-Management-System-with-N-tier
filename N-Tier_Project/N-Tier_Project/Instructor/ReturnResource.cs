using Model;
using BLL;
using Type;
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
    public partial class ReturnResource : Form
    {
        private int resourcrId;
        private List<LoanLookUp> loans = new List<LoanLookUp>();
        private Loan loan = new Loan();
        private Student s;
        private Resource r;
        private LoanStatus loanStatus;
        Main main;

        public ReturnResource(Main m)
        {
            main = m;
            InitializeComponent();
        }
        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResourceIdEntry.Text == string.Empty)
                {
                    MessageBox.Show("ResourceID is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ResourceBL resourceBL = new ResourceBL();
                    r = resourceBL.GetResourceOnLoan(Convert.ToInt32(txtResourceIdEntry.Text));
                    txtResourceId.Text = r.ResourceId.ToString();

                    txtStudentId.Text = r.StudentId.ToString();
                    txtResourceTitle.Text = r.Title;
                    txtResourceType.Text = r.ResourceType.ToString();
                    txtResourceStatus.Text = r.ResourceStatus.ToString();
                    chkIsReserved.Checked = r.IsReserved;
                    StudentBL studentBl = new StudentBL();

                    s = studentBl.GetStudent(txtStudentId.Text);
                    txtFirstName.Text = s.FirstName;
                    txtLastName.Text = s.lastName;
                    txtBalanceDue.Text = s.BalanceDue.ToString();
                    txtEndDate.Text = s.EndDate.ToString();
                    txtStartDate.Text = s.StartDate.ToString();
                    txtProgramOption.Text = s.Program.ToString();
                    chkIsActive.Checked = s.IsActive;
                    ListsBL listsBL = new ListsBL();
                    dgvCurrentLoans.DataSource = listsBL.GetLoans(txtStudentId.Text);
                    cmbLoanStatus.DataSource = listsBL.GetLoans(txtStudentId.Text);
                    cmbLoanStatus.DisplayMember = "LoanStatus";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form_Validation() != string.Empty)
                {
                    MessageBox.Show(Form_Validation(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ReturnBL ReturnBL = new ReturnBL(s, r);
                    loan.StudentId = txtStudentId.Text;
                    loan.DateReturned = DateTime.Now;
                    if (ReturnBL.ReturnTransaction(txtStudentId.Text, resourcrId, DateTime.Now, (int)loanStatus))
                    {
                        MessageBox.Show("Return worked!");
                        //loans.Remove(loanss);
                    }
                    else
                    {
                        MessageBox.Show("Return failed");
                    }
                    ListsBL listsBL = new ListsBL();
                    dgvCurrentLoans.DataSource = listsBL.GetLoans(s.StudentId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Form_Validation()
        {
            string msg = "";
            if (txtResourceIdEntry.Text == string.Empty)
            {
                msg += "ResourceId is empty\n";
            }
            return msg;
        }
        private void dgvCurrentLoans_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            loan.ResourceId = Convert.ToInt32(dgvCurrentLoans.CurrentRow.Cells[0].Value);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvCurrentLoans_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCurrentLoans.Rows[e.RowIndex].Cells["chkDamage"].Selected == true)
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dgvCurrentLoans.Rows[index];
                    loanStatus = (LoanStatus)2;
                    resourcrId = Convert.ToInt32(selectedRow.Cells[4].Value);
                }

                if (dgvCurrentLoans.Rows[e.RowIndex].Cells["chkLost"].Selected == true)
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dgvCurrentLoans.Rows[index];
                    loanStatus = (LoanStatus)3;
                    resourcrId = Convert.ToInt32(selectedRow.Cells[4].Value);
                }

                if (dgvCurrentLoans.Rows[e.RowIndex].Cells["chkReturn"].Selected == true)
                {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dgvCurrentLoans.Rows[index];
                    loanStatus = (LoanStatus)1;
                    resourcrId = Convert.ToInt32(selectedRow.Cells[4].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
