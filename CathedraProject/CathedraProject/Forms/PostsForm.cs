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
    public partial class PostsForm : Form
    {
        public PostsForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Posts;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPostForm form = new NewPostForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Post post = dataGridView1.SelectedRows[0].DataBoundItem as Post;

                NewPostForm form = new NewPostForm(post);
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
                Post post = dataGridView1.SelectedRows[0].DataBoundItem as Post;

                if (DBController.Instance.Teachers.Any(t=>t.Post == post))
                {
                    MessageBox.Show("Данная должность уже используется");
                    return;
                }

                DBController.Instance.Remove(post);
                UpdateGrid();
            }
        }
    }
}
