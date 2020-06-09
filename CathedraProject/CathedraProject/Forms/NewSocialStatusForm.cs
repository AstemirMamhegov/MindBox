using CathedraProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CathedraProject.Forms
{
    public partial class NewSocialStatusForm : Form
    {
        private Status status;
        public NewSocialStatusForm(Status status = null)
        {
            InitializeComponent();

            if (status != null)
            {
                this.status = status;
                txtBxName.Text = status.Name;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxName.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }
            if (status == null)
                status = new Status();
            status.Name = txtBxName.Text;
            DBController.Instance.Update(status);

            DialogResult = DialogResult.OK;
        }

        private void NewSocialStatusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
