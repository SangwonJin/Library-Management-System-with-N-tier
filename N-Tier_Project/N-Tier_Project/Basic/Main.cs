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
namespace FrontEnd
{
    //test
    public partial class Main : Form
    {
        private ResourceCheckOut frmResourceCheckOut;
        private ReturnResource frmReturn;
        private Reservation frmrevervation;
        private Payment frmPayment;
        private StudentForm frmStudent;
        private AddResoruce frmAddResource;
        private AddInstructor frmInstructor;

        public InstructorType instructorType;
        public Main()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            //Splash splash = new Splash();
            ////Login login = new Login();
            ////splash.ShowDialog();
            ////if (splash.DialogResult != DialogResult.OK)
            ////{
            ////    this.Close();
            ////}
            ////else
            ////{
            ////    login.ShowDialog();
            ////}
            //mnuDeptHead.Enabled = false;
            //picAddInstructor.Visible = false;
            //picAddResource.Visible = false;
            //Login login = new Login(this);
            //login.ShowDialog();
            //if (login.DialogResult != DialogResult.OK)
            //{
            //    this.Close();
            //}
            //if (InstructorType.DepartmentHead == instructorType)
            //{
            //    mnuDeptHead.Enabled = true;
            //    picAddInstructor.Visible = true;
            //    picAddResource.Visible = true;
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            CheckOut();
        }

        private void picReturn_Click(object sender, EventArgs e)
        {

            ReturnResource();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            Reservation();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MakePayment();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            StudentForm();
        }

        private void picAddResource_Click(object sender, EventArgs e)
        {
            AddResource();
        }

        private void picAddInstructor_Click(object sender, EventArgs e)
        {
            AddInstructor();
        }

        private void mnuDeptHeadAddResource_Click(object sender, EventArgs e)
        {
            AddResource();
        }

        private void mnuDeptHeadAddInstructor_Click(object sender, EventArgs e)
        {
            AddInstructor();
        }
        private void mnuInstLoan_Click(object sender, EventArgs e)
        {
            CheckOut();
        }

        private void mnuInstReturn_Click(object sender, EventArgs e)
        {
            ReturnResource();
        }

        private void mnuInstPayment_Click(object sender, EventArgs e)
        {
            MakePayment();
        }

        private void mnuInstReservation_Click(object sender, EventArgs e)
        {
            Reservation();
        }

        private void mnuInstStudent_Click(object sender, EventArgs e)
        {
            StudentForm();
        }

        private void CheckOut()
        {
            if (frmResourceCheckOut == null || frmResourceCheckOut.IsDisposed)
            {
                frmResourceCheckOut = new ResourceCheckOut(this);

            }
            if (tabControl1.Contains(frmResourceCheckOut))
            {
                tabControl1.TabPages[frmResourceCheckOut].Select();
            }
            else
            {
                tabControl1.TabPages.Add(frmResourceCheckOut);
            }
        }
        private void ReturnResource()
        {
            if (frmReturn == null || frmReturn.IsDisposed)
            {
                frmReturn = new ReturnResource(this);
                tabControl1.TabPages.Add(frmReturn);
            }
            if (tabControl1.Contains(frmReturn))
            {
                tabControl1.TabPages[frmReturn].Select();
            }
            else
            {
                tabControl1.TabPages.Add(frmReturn);
            }
        }
        private void Reservation()
        {

            if (frmrevervation == null || frmrevervation.IsDisposed)
            {
                frmrevervation = new Reservation(this);
                tabControl1.TabPages.Add(frmrevervation);
            }
            if (tabControl1.Contains(frmrevervation))
            {
                tabControl1.TabPages[frmrevervation].Select();
            }
            else
            {
                tabControl1.TabPages.Add(frmrevervation);
            }
        }
        private void MakePayment()
        {
            if (frmPayment == null || frmPayment.IsDisposed)
            {
                frmPayment = new Payment(this);
                tabControl1.TabPages.Add(frmPayment);
            }
            if (tabControl1.Contains(frmPayment))
            {
                tabControl1.TabPages[frmPayment].Select();
            }
            else
            {
                tabControl1.TabPages.Add(frmPayment);
            }
        }
        private void StudentForm()
        {
            if (frmStudent == null || frmStudent.IsDisposed)
            {
                frmStudent = new StudentForm(this);
                tabControl1.TabPages.Add(frmStudent);
            }
            if (tabControl1.Contains(frmStudent))
            {
                tabControl1.TabPages[frmStudent].Select();
            }
            else
            {
                tabControl1.TabPages.Add(frmStudent);
            }
        }
        private void AddResource()
        {
            if (frmAddResource == null || frmAddResource.IsDisposed)
            {
                frmAddResource = new AddResoruce(this);
                tabControl1.TabPages.Add(frmAddResource);
            }
            if (tabControl1.Contains(frmAddResource))
            {
                tabControl1.TabPages[frmAddResource].Select();
            }
            else
            {
                tabControl1.TabPages.Add(frmAddResource);
            }
        }
        private void AddInstructor()
        {
            if (frmInstructor == null || frmInstructor.IsDisposed)
            {
                frmInstructor = new AddInstructor(this);
                tabControl1.TabPages.Add(frmInstructor);
            }
            if (tabControl1.Contains(frmInstructor))
            {
                tabControl1.TabPages[frmInstructor].Select();
            }
            else
            {
                tabControl1.TabPages.Add(frmAddResource);
            }
        }


    }
}
