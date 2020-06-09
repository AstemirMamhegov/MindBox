using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CathedraProject
{
    public partial class StudentParentForm : Form
    {
        public Parent StudentParent { get; private set; }
        private Address address;

        public StudentParentForm(Parent parent = null)
        {
            InitializeComponent();

            if (parent != null)
            {
                StudentParent = parent;

                txtBxAddress.Text = parent.Address?.ToString();
                txtBxEmail.Text = parent.Email;
                txtBxFirstName.Text = parent.FirstName;
                txtBxHomePhone.Text = parent.HomeNumb;
                txtBxLastName.Text = parent.LastName;
                txtBxMiddleName.Text = parent.MiddleName;
                txtBxPost.Text = parent.Position;
                txtBxWork.Text = parent.Work;
                dateTimePicker.Value = parent.Birthday;
                maskedTextBoxPhone.Text = parent.Phone;

                address = parent.Address;
            }
        }

        private void StudentMotherForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (StudentParent == null)
                StudentParent = new Parent();

            StudentParent.Address = address;
            StudentParent.Email = txtBxEmail.Text;
            StudentParent.FirstName = txtBxFirstName.Text;
            StudentParent.HomeNumb = txtBxHomePhone.Text;
            StudentParent.LastName = txtBxLastName.Text;
            StudentParent.MiddleName = txtBxMiddleName.Text;
            StudentParent.Position = txtBxPost.Text;
            StudentParent.Work = txtBxWork.Text;
            StudentParent.Birthday = dateTimePicker.Value;
            StudentParent.Phone = maskedTextBoxPhone.Text;

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddressForm form = new AddressForm(address);
            if (form.ShowDialog() == DialogResult.OK)
            {
                address = form.Address;

                txtBxAddress.Text = address.ToString();
            }
        }
    }
}
