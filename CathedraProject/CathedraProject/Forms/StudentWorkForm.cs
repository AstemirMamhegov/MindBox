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
    public partial class StudentWorkForm : Form
    {
        private Student student;

        public StudentWorkForm(Student student)
        {
            InitializeComponent();
            this.student = student;

            comboBox1.SelectedIndex = 0;
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;

            int course = int.Parse(comboBox1.Text);
            dataGridView1.DataSource = student.StudentWorks.Where(t=>t.Course == course).ToList();
        }

        private void OpenStudentWork()
        {
            int course = int.Parse(comboBox1.Text);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                StudentWork studentWork = dataGridView1.SelectedRows[0].DataBoundItem as StudentWork;

                NewStudentWorkForm form = new NewStudentWorkForm(student, course, studentWork);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateGrid();
                }
            }
        }
        private void StudentWorkForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int course = int.Parse(comboBox1.Text);

            NewStudentWorkForm form = new NewStudentWorkForm(student, course);
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStudentWork();
        }


        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                StudentWork studentWork = dataGridView1.SelectedRows[0].DataBoundItem as StudentWork;
                student.StudentWorks.Remove(studentWork);
                DBController.Instance.Remove(studentWork);
                UpdateGrid();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
