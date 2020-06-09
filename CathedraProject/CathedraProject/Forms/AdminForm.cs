using CathedraProject.Forms;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCountries_Click(object sender, EventArgs e)
        {
            CountriesForm form = new CountriesForm();
            form.ShowDialog();
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            PostsForm form = new PostsForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectionsForm form = new DirectionsForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupsForm form = new GroupsForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubjectsForm form = new SubjectsForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeachersForm form = new TeachersForm();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StudentsForm form = new StudentsForm();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SocialStatusForm form = new SocialStatusForm();
            form.ShowDialog();
        }
    }
}
