using BLL;
using Model;
using System;
using System.Windows.Forms;
using Type;
namespace FrontEnd
{
    public partial class StudentForm : Form
    {
        private Student s = new Student();
        private Main Main;
        public StudentForm(Main m)
        {
            Main = m;
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
                    getStudent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getStudent()
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
            txtStudentId.Enabled = false;
            txtBalanceDue.Enabled = false;
            txtTelephone.Text = s.Telephon;
            txtCity.Text = s.City;
            txtPostalCode.Text = s.PostalCode;
            txtAddress.Text = s.Address;
            txtStudentId.Text = s.StudentId;
            txtFirstName.Text = s.FirstName;
            txtLastName.Text = s.lastName;
            cmbProgramOption.SelectedIndex = Convert.ToInt32(s.Program);
            dtpEndDate.Value = s.EndDate;
            dtpStartDate.Value = s.StartDate;
            txtBalanceDue.Text = s.BalanceDue.ToString("c");
            chkIsActive.Checked = s.IsActive;
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            loadProgramOption();
            ResetForm();
        }
        private void loadProgramOption()
        {
            cmbProgramOption.DataSource = Enum.GetValues(typeof(ProgramOption));
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string errMsg = ValidateForm();

                if (errMsg != string.Empty)
                {
                    MessageBox.Show(errMsg, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    StudentBL studentBL = new StudentBL();
                    PopulateStudentObject();
                    if (studentBL.InsetStudent(s))
                    {
                        MessageBox.Show("Student Added");
                        ResetForm();
                     
                    }

                    if (studentBL.Errors.Count != 0)
                    {
                        string msg = "";
                        foreach (ValidationError error in studentBL.Errors)
                        {
                            msg += error.Description + Environment.NewLine;
                        }

                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {            
                if (lstMatchingStudents.SelectedIndex > -1)
                {
                   
                    if (MessageBox.Show("Are you wure you want to delete the current record?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }

                    StudentBL studentBL = new StudentBL();
                    if (studentBL.Delete_Student(lstMatchingStudents.SelectedValue.ToString()))
                    {
                        MessageBox.Show("Student Deleted!");
                        ResetForm();
                    }

                    if(studentBL.Errors.Count != 0)
                    {
                        string msg = "";
                        foreach (ValidationError error in studentBL.Errors)
                        {
                            msg += error.Description + Environment.NewLine;
                        }

                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Student in the list box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string errMsg = ValidateForm();

                if (errMsg != string.Empty)
                {
                    MessageBox.Show(errMsg, "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StudentBL studentBL = new StudentBL();
                    PopulateStudentObject();
                    if (studentBL.UpdateStudent(s))
                    {
                        MessageBox.Show("Student Updated");
                        getStudent();
                    }

                    if (studentBL.Errors.Count != 0)
                    {
                        string msg = "";
                        foreach (ValidationError error in studentBL.Errors)
                        {
                            msg += error.Description + Environment.NewLine;
                        }

                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ValidateForm()
        {
            string errMsg = "";

            if (txtStudentId.Text == string.Empty || !ValidLength(txtStudentId.Text, 8) || !int.TryParse(txtStudentId.Text, out int a))
            {
                errMsg = errMsg + Environment.NewLine + "Student Id should be number and cannot be blank or more than 8 characters.";
            }

            if (txtFirstName.Text == string.Empty || !ValidLength(txtFirstName.Text, 30))
            {
                errMsg = errMsg + Environment.NewLine + "Firstname cannot be blank or more than 30 characters.";
            }

            if (txtLastName.Text == string.Empty || !ValidLength(txtLastName.Text, 20))
            {
                errMsg = errMsg + Environment.NewLine + "Lastname cannot be blank or more than 20 characters.";
            }

            if (txtAddress.Text == string.Empty || !ValidLength(txtAddress.Text, 30))
            {
                errMsg = errMsg + Environment.NewLine + "Address cannot be blank or more than 30 characters.";
            }
            if (txtCity.Text == string.Empty || !ValidLength(txtCity.Text, 20))
            {
                errMsg = errMsg + Environment.NewLine + "City cannot be blank or more than 20 characters.";
            }
            if (txtPostalCode.Text == string.Empty || !ValidLength(txtPostalCode.Text, 7))
            {
                errMsg = errMsg + Environment.NewLine + "Postalcode cannot be blank or more than 7 characters.";
            }
            if (dtpStartDate.Value >= dtpEndDate.Value)
            {
                errMsg = errMsg + Environment.NewLine + "Enddate should be more than startdate";
            }
            if (cmbProgramOption.SelectedIndex == -1)
            {
                errMsg = errMsg + Environment.NewLine + "ProgramOption should be selected";
            }

            return errMsg;
        }
        private void PopulateStudentObject()
        {
            s.StudentId = txtStudentId.Text;
            s.Program = (ProgramOption)cmbProgramOption.SelectedIndex;
            s.FirstName = txtFirstName.Text;
            s.lastName = txtLastName.Text;
            s.Address = txtAddress.Text;
            s.City = txtCity.Text;
            s.PostalCode = txtPostalCode.Text;
            s.Telephon = txtTelephone.Text;
            s.EndDate = dtpEndDate.Value;
            s.StartDate = dtpStartDate.Value;
            s.IsActive = chkIsActive.Checked;
        }
        public bool ValidLength(string value, int length)
        {
            if (value.Length > length)
            {
                return false;
            }

            return true;
        }
        private void ResetForm()
        {
            foreach (Control ctl in grpStudentInfo.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                    ctl.Enabled = true;
                }
                if (ctl is CheckBox)
                {
                    ((CheckBox)ctl).Checked = false;
                }
                if (ctl is DateTimePicker)
                {
                    ((DateTimePicker)ctl).Value = DateTime.Now;
                }
            }

            cmbProgramOption.SelectedIndex = -1;
            lstMatchingStudents.DataSource = null;
            txtSearchKeyword.Text = "";
        }

    }
}
