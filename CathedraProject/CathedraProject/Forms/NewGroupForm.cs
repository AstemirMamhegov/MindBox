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
    public partial class NewGroupForm : Form
    {
        private Group group;

        public NewGroupForm(Group group = null)
        {
            InitializeComponent();

            if (group != null)
            {
                this.group = group;
                txtBxName.Text = group.Name;
            }
        }


        private void NewGroupForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxName.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (group == null)
                group = new Group();

            group.Name = txtBxName.Text;
            DBController.Instance.Update(group);

            DialogResult = DialogResult.OK;
        }
    }
}
