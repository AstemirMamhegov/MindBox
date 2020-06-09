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
    public partial class SubjectsForm : Form
    {
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Subjects;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSubjectForm form = new NewSubjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Subject subject = dataGridView1.SelectedRows[0].DataBoundItem as Subject;

                NewSubjectForm form = new NewSubjectForm(subject);
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

               Subject subject = dataGridView1.SelectedRows[0].DataBoundItem as Subject;

                DBController.Instance.Remove(subject);
                UpdateGrid();
            }
        }
    }
}
