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
    public partial class NewPostForm : Form
    {
        private Post post;

        public NewPostForm(Post post = null)
        {
            InitializeComponent();

            if (post != null)
            {
                this.post = post;
                txtBxName.Text = post.Name;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxName.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (post == null)
                post = new Post();

            post.Name = txtBxName.Text;
            DBController.Instance.Update(post);

            DialogResult = DialogResult.OK;
        }
    }
}
