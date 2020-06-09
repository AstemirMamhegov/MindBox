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
    public partial class NewStudentWorkForm : Form
    {
        private StudentWork studentWork;
        private Student student;
        private int course;

        public NewStudentWorkForm(Student student, int course, StudentWork studentWork = null)
        {
            InitializeComponent();

            comboBox1.DataSource = DBController.Instance.Subjects;
            comboBox2.DataSource = DBController.Instance.Teachers;

            this.student = student;
            this.course = course;

            if (studentWork != null)
            {
                txtBxTheme.Text = studentWork.Name;
                comboBox1.SelectedItem = studentWork.Subject;
                numericUpDown1.Value = studentWork.Mark;
                comboBox2.SelectedItem = studentWork.Teacher;
                comboBox3.SelectedIndex = (int)studentWork.TypeWork;

                this.studentWork = studentWork;
            }
        }

        private void NewStudentWorkForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (studentWork == null)
                studentWork = new StudentWork();

            studentWork.Name = txtBxTheme.Text;
            studentWork.Subject = comboBox1.SelectedItem as Subject;
            studentWork.Teacher = comboBox2.SelectedItem as Teacher;
            studentWork.Mark = (int)numericUpDown1.Value;
            studentWork.Student = student;
            studentWork.Course = course;
            studentWork.TypeWork = (TypeWork)comboBox3.SelectedIndex;

            DBController.Instance.Update(studentWork);

            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = comboBox3.SelectedIndex != 2;
        }
    }
}
