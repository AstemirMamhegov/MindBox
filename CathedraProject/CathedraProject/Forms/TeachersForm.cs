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
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
        }
        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Teachers;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTeacherForm form = new NewTeacherForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Teacher teacher = dataGridView1.SelectedRows[0].DataBoundItem as Teacher;

                NewTeacherForm form = new NewTeacherForm(teacher);
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

                Teacher teacher = dataGridView1.SelectedRows[0].DataBoundItem as Teacher;

                DBController.Instance.Remove(teacher);
                UpdateGrid();
            }
        }
    }
}

