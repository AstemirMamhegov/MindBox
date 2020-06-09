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
    public partial class NewMarkForm : Form
    {
        StudentMark studentMark;
        Student student;
        int course;
        int semestr;

        public NewMarkForm(Student student, int course, int semestr, StudentMark studentMark = null)
        {
            InitializeComponent();

            comboBox1.DataSource = DBController.Instance.Subjects;

            this.student = student;
            this.semestr = semestr;
            this.course = course;

            if (studentMark != null)
            {
                comboBox1.SelectedItem = studentMark.Subject;
                numericUpDown1.Value = studentMark.Mark;
                this.studentMark = studentMark;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Subject subject = comboBox1.SelectedItem as Subject;

            if (studentMark == null)
            {
                if (student.Marks.Any(t => t.Subject == subject && t.Semestr == semestr && t.Course == course))
                {
                    MessageBox.Show("Такой предмет уже создан!");
                    return;
                }
                studentMark = new StudentMark();
            }

            studentMark.Subject = subject;
            studentMark.Mark = (int)numericUpDown1.Value;
            studentMark.Student = student;
            studentMark.Semestr = semestr;
            studentMark.Course = course;

            DBController.Instance.Update(studentMark);

            DialogResult = DialogResult.OK;
        }

        private void NewMarkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
