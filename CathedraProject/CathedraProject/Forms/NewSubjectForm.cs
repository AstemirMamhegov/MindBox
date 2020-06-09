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
    public partial class NewSubjectForm : Form
    {
        private Subject subject;

        public NewSubjectForm(Subject subject = null)
        {
            InitializeComponent();

            if (subject != null)
            {
                this.subject = subject;
                txtBxName.Text = subject.Name;
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxName.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (subject == null)
                subject = new Subject();

            subject.Name = txtBxName.Text;
            DBController.Instance.Update(subject);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void NewSubjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
