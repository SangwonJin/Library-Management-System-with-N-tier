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
using Type;

namespace FrontEnd
{
    public partial class Login : Form
    {
        Main main;
        public Login(Main m)
        {
            main = m;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName + "- Login";
            txtUserName.Text = Environment.UserName;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                InstructorBL instructorBL = new InstructorBL();
                InstructorType type = instructorBL.getType(txtUserName.Text, txtPassword.Text);
         
                if (InstructorType.DepartmentHead == type || InstructorType.Instructor == type)
                {   main.instructorType = type;
                    MessageBox.Show(txtUserName.Text + " is "+ type.ToString());
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                int times = 0;
                times++;
                //if more than 4 times of login errors, system shut down
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (times == 4)
                {
                    DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Login failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
