using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace FrontEnd
{
   
    public partial class ResourceTransaction : Form
    {
        private Loan loan = new Loan();
        private Student s;
        private Resource r;
        private Main main;

        public ResourceTransaction(Main m)
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

                    StudentBL studentBL = new StudentBL();
                    s = studentBL.GetStudent(lstMatchingStudents.SelectedValue.ToString());
                    txtStudentId.Text = s.StudentId;
                    txtProgramOption.Text = s.Program.ToString();
                    txtFirstName.Text = s.FirstName;
                    txtLastName.Text = s.lastName;
                    txtStartDate.Text = s.StartDate.ToString();
                    txtEndDate.Text = s.EndDate.ToString();
                    txtBalanceDue.Text = s.BalanceDue.ToString("c");
                    chkIsActive.Checked = s.IsActive;

                    ListsBL listsBL = new ListsBL();
                    dgvCurrentLoans.DataSource = listsBL.GetLoans(s.StudentId);
                
               
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
                else 
                {
                    ResourceBL resourceBL = new ResourceBL();
                    r = resourceBL.GetResource(Convert.ToInt32(txtResourceIdEntry.Text));
                    txtResourceTitle.Text = r.Title;
                    txtResourceType.Text = r.ResourceType.ToString();
                    txtResourceStatus.Text = r.ResourceStatus.ToString();
                    chkIsReserved.Checked = r.IsReserved;
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
                loan.StudentId = txtStudentId.Text;
                loan.ResourceId = Convert.ToInt32(txtResourceIdEntry.Text);
                loan.CheckOutDate = DateTime.Now;
                LoanBL loanBL = new LoanBL();

                if(r.IsReserved!=true && r.ResourceStatus.ToString() == "Available")
                {
                    MessageBox.Show($"StudendID: {txtStudentId.Text}\n" +
                   $"ResourceID: {txtResourceIdEntry.Text}\n" +
                   $"CheckOut Date: {loan.CheckOutDate}\n" +
                   $"Due Date: {loan.DueDate}");
                    if (loanBL.ResourceTransaction(loan.StudentId, loan.ResourceId, loan.CheckOutDate, loan.DueDate))
                    {
                        MessageBox.Show("Transaction worked!");
                    }
                    else
                    {
                        MessageBox.Show("Transaction Falied!");

                    }
                    ListsBL listsBL = new ListsBL();
                    dgvCurrentLoans.DataSource = listsBL.GetLoans(s.StudentId);
                }
                else
                {
                    MessageBox.Show("Resource is not available!");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
