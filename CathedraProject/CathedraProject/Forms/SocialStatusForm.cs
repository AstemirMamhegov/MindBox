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
    public partial class SocialStatusForm : Form
    {
        public SocialStatusForm()
        {
            InitializeComponent();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Statuses;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSocialStatusForm form = new NewSocialStatusForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSocialStatus();
        }
        private void OpenSocialStatus()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Status status = dataGridView1.SelectedRows[0].DataBoundItem as Status;

                NewSocialStatusForm form = new NewSocialStatusForm(status);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateGrid();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Status status = dataGridView1.SelectedRows[0].DataBoundItem as Status;

                DBController.Instance.Remove(status);
                UpdateGrid();
            }
        }
    }
}
