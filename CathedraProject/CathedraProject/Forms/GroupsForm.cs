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
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Groups;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGroupForm form = new NewGroupForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void GroupsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Group group = dataGridView1.SelectedRows[0].DataBoundItem as Group;

                NewGroupForm form = new NewGroupForm(group);
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
                Group group = dataGridView1.SelectedRows[0].DataBoundItem as Group;

                if (!DBController.Instance.Students.Any(t => t.Group == group))
                {
                    DBController.Instance.Remove(group);
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("Данный объект используется в связанных данных");
                }
            }
        }
    }
}
