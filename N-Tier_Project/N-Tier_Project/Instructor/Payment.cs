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
    public partial class Payment : Form
    {
        private Main main;
        private Student s;
        public Payment(Main m)
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
                    PopulateStudent(lstMatchingStudents.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            try
            {
                string errMsg = ValidateForm();
                if (errMsg != string.Empty)
                {
                    MessageBox.Show(errMsg, "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PaymentBL paymentBL = new PaymentBL();

                    Payment_Entity p = new Payment_Entity() 
                    { 
                        StudentId = s.StudentId,
                        AmountOfPayment = Convert.ToDecimal(txtAmountOfPayment.Text),
                        Date = DateTime.Now
                    };
                    if (paymentBL.MakePayment(p))
                    {
                        PopulateStudent(s.StudentId);
                        MessageBox.Show("Payment made!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PopulateStudent(string studentid)
        {
            StudentBL studentBL = new StudentBL();
            s = studentBL.GetStudent(studentid);
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
        }
        private string ValidateForm()
        {
            string errMsg = "";
            if (lstMatchingStudents.SelectedIndex == -1)
            {
                errMsg += "Please select student first in the list box";
            }
            if (txtAmountOfPayment.Text == string.Empty || !decimal.TryParse(txtAmountOfPayment.Text,out decimal a))
            {
                errMsg += "Amount of payment cannot be blank or characters";
            }

            return errMsg;
        }
    }
}
