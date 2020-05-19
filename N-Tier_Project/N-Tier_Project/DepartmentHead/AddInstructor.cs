using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type;
using BLL;

namespace FrontEnd
{
    public partial class AddInstructor : Form
    {
        Main main;
        public AddInstructor(Main m)
        {
            main = m;
            InitializeComponent();
        }

        private void AddInstructor_Load(object sender, EventArgs e)
        {
            cmbInstructorType.DataSource = Enum.GetValues(typeof(InstructorType));
            cmbInstructorType.SelectedIndex = -1;
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

                    InstructorBL instructorBL = new InstructorBL();
                    if(instructorBL.InsertInstructor(txtInstructorId.Text, txtPassword.Text, (InstructorType)cmbInstructorType.SelectedIndex))
                    {
                        MessageBox.Show("Instructor added!");
                        txtInstructorId.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        cmbInstructorType.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Adding Instructor failed");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private String ValidateForm()
        {
            string errMsg = "";
            if (txtInstructorId.Text == string.Empty || !ValidLength(txtInstructorId.Text, 20))
            {
                errMsg = errMsg + Environment.NewLine + "InstructorId cannot be  blank or more than 20 characters.";
            }

            if (txtPassword.Text == string.Empty || !ValidLength(txtPassword.Text, 10))
            {
                errMsg = errMsg + Environment.NewLine + "Instructor Password cannot be blank or more than 10 characters.";
            }

            if (cmbInstructorType.SelectedIndex==-1)
            {
                errMsg = errMsg + Environment.NewLine + "Instructor type should be selected";
            }

            return errMsg;
        }
        public bool ValidLength(string value, int length)
        {
            if (value.Length > length)
            {
                return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
