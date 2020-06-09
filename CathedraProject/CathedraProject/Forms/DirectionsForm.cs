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
    public partial class DirectionsForm : Form
    {
        public DirectionsForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Directions;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDirectionForm form = new NewDirectionForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void DirectionsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Direction directy = dataGridView1.SelectedRows[0].DataBoundItem as Direction;

                NewDirectionForm form = new NewDirectionForm(directy);
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
                Direction direct = dataGridView1.SelectedRows[0].DataBoundItem as Direction;

                DBController.Instance.Remove(direct);
                UpdateGrid();
            }
        }
    }
}
