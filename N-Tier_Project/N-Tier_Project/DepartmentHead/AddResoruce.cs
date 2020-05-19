using BLL;
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
using Model;
using System.IO;

namespace FrontEnd
{
    public partial class AddResoruce : Form
    {
        Main main;
        public AddResoruce(Main m)
        {
            main = m;
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picImageOfItem.Image = new Bitmap(dlg.FileName);
                    picImageOfItem.Name = dlg.FileName;
                }
            }
        }
        private void btnAddResource_Click(object sender, EventArgs e)
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
                    ResourceBL resourceBL = new ResourceBL();
                    if (resourceBL.InsertResource(PopulateResourceObject()))
                    {
                        MessageBox.Show("Resource Added!");
                        txtResourceId.Text = string.Empty;
                        txtResourceTitle.Text = string.Empty;
                        txtPublisher.Text = string.Empty;
                        txtPubRefNumber.Text = string.Empty;
                        txtPurchasePrice.Text = string.Empty;
                        dtpDateOfPurchase.Value = DateTime.Now;
                        cmbResourceStatus.SelectedIndex = -1;
                        cmbResourceType.SelectedIndex = -1;
                        picImageOfItem.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Adding Resource Falied!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Resource PopulateResourceObject()
        {
            string image = "";
            if (Path.GetFileNameWithoutExtension(picImageOfItem.Name) != "picImageOfItem")
            {
                image = Path.GetFileNameWithoutExtension(picImageOfItem.Name);
            }
            Resource r = new Resource()
            {
                ResourceId = Convert.ToInt32(txtResourceId.Text),
                Title = txtResourceTitle.Text,
                Publisher = txtPublisher.Text,
                PubRefNumber = txtPubRefNumber.Text,
                DateOfPurchase = dtpDateOfPurchase.Value,
                PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text),
                ResourceStatus = (ResourceStatus)cmbResourceStatus.SelectedIndex,
                ImageOfItem = image,
                ResourceType = (ResourceType)cmbResourceType.SelectedIndex
            };
            return r;
        }
        private void AddResoruce_Load(object sender, EventArgs e)
        {
            cmbResourceStatus.DataSource = Enum.GetValues(typeof(ResourceStatus));
            cmbResourceType.DataSource = Enum.GetValues(typeof(ResourceType));
            cmbResourceStatus.SelectedIndex = -1;
            cmbResourceType.SelectedIndex = -1;
        }
        private String ValidateForm()
        {
            string errMsg = "";
            if (txtResourceId.Text == string.Empty || !ValidLength(txtResourceId.Text, 8) || !int.TryParse(txtResourceId.Text, out int a))
            {
                errMsg = errMsg + Environment.NewLine + "ResourceId cannot be string, blank or more than 8 digits.";
            }

            if (txtResourceTitle.Text == string.Empty || !ValidLength(txtResourceTitle.Text, 50))
            {
                errMsg = errMsg + Environment.NewLine + "ResourceTitle cannot be blank or more than 50 characters.";
            }
            if (txtPubRefNumber.Text == string.Empty || !int.TryParse(txtPubRefNumber.Text, out int b))
            {
                errMsg = errMsg + Environment.NewLine + "RefNumber cannot be blank or character. it should be number";
            }

            if (txtPublisher.Text == string.Empty || !ValidLength(txtPublisher.Text, 30))
            {
                errMsg = errMsg + Environment.NewLine + "Publisher cannot be blank or more than 30 characters.";
            }

            if (dtpDateOfPurchase.Value > DateTime.Now)
            {
                errMsg = errMsg + Environment.NewLine + "Purchase Date cannot be more than today";
            }

            if (txtPurchasePrice.Text == string.Empty || !decimal.TryParse(txtPurchasePrice.Text, out decimal c))
            {
                errMsg = errMsg + Environment.NewLine + "PurchasePrice cannot be empty and should be number";
            }
            if (cmbResourceStatus.SelectedIndex == -1)
            {
                errMsg = errMsg + Environment.NewLine + "ResourceStatus should be selected";
            }
            if (cmbResourceType.SelectedIndex == -1)
            {
                errMsg = errMsg + Environment.NewLine + "ResourceType should be selected";
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
    }
}
