using CathedraProject.Model;
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
    public partial class NewTeacherSubjectForm : Form
    {
        public TeacherSubject Subject { get; private set; }

        public NewTeacherSubjectForm(TeacherSubject subject = null)
        {
            InitializeComponent();

            comboBox1.DataSource = DBController.Instance.Subjects;

            if (subject != null)
            {
                Subject = subject;
                comboBox1.SelectedItem = subject.Subject;
                numericUpDown1.Value = subject.Hours;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Subject == null)
                Subject = new TeacherSubject();

            Subject.Subject = comboBox1.SelectedItem as Subject;
            Subject.Hours = (int)numericUpDown1.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
