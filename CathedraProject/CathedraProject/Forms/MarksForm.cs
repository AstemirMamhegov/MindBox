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
    public partial class MarksForm : Form
    {
        Student student;

        public MarksForm(Student student)
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            this.student = student;
            UpdateMarks();
        }

        public void UpdateMarks()
        {
            if (student != null)
            {
                dataGridView1.DataSource = null;
                int course = int.Parse(comboBox2.Text);
                int semestr = int.Parse(comboBox1.Text);

                dataGridView1.DataSource = student.Marks.Where(t => t.Course == course && t.Semestr == semestr).ToList();
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int course = int.Parse(comboBox2.Text);
            int semestr = int.Parse(comboBox1.Text);

            NewMarkForm form = new NewMarkForm(student, course, semestr);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateMarks();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int course = int.Parse(comboBox2.Text);
            int semestr = int.Parse(comboBox1.Text);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                StudentMark studentMark = dataGridView1.SelectedRows[0].DataBoundItem as StudentMark;

                NewMarkForm form = new NewMarkForm(student, course, semestr, studentMark);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateMarks();
                }
            }
        }

        private void MarksForm_Load(object sender, EventArgs e)
        {
            
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                StudentMark studentMark = dataGridView1.SelectedRows[0].DataBoundItem as StudentMark;
                DBController.Instance.Remove(studentMark);
                UpdateMarks();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMarks();
        }
    }
}
