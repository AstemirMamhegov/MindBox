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
    public partial class NewDirectionForm : Form
    {
        private Direction directy;

        public NewDirectionForm(Direction directy = null)
        {
            InitializeComponent();

            if (directy != null)
            {
                this.directy = directy;
                txtBxName.Text = directy.Name;
                txtBxCode.Text = directy.Code;
            }
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBxName.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (directy == null)
                directy = new Direction();

            directy.Name = txtBxName.Text;
            directy.Code = txtBxCode.Text;

            DBController.Instance.Update(directy);

            DialogResult = DialogResult.OK;
        }
    }
}
