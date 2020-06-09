using CathedraProject.Forms;
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

namespace CathedraProject
{
    public partial class NewTeacherForm : Form
    {
        private Address address;
        private Teacher teacher;
        private List<TeacherSubject> subjects = new List<TeacherSubject>();

        public NewTeacherForm(Teacher teacher = null)
        {
            InitializeComponent();

            comboBox1.DataSource = DBController.Instance.Posts;

            if (teacher != null)
            {
                this.teacher = teacher;
                address = teacher.Address;

                txtBxAddress.Text = address?.ToString();
                txtBxEmail.Text = teacher.Email;
                txtBxFirstName.Text = teacher.FirstName;
                txtBxLastName.Text = teacher.LastName;
                txtBxMiddleName.Text = teacher.MiddleName;
                dateTimePicker1.Value = teacher.Birthday;
                maskedTextBox1.Text = teacher.Phone;
                numericUpDown1.Value = (decimal)teacher.Rate;
                comboBox1.SelectedItem = teacher.Post;
                numericUpDown2.Value = teacher.Experience;
                subjects = teacher.TeacherSubjects;

                UpdateSubjects();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressForm form = new AddressForm(address);
            if (form.ShowDialog() == DialogResult.OK)
            {
                address = form.Address;

                txtBxAddress.Text = address.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (teacher == null)
                teacher = new Teacher();

            teacher.LastName = txtBxLastName.Text;
            teacher.MiddleName = txtBxMiddleName.Text;
            teacher.FirstName = txtBxFirstName.Text;
            teacher.Address = address;
            teacher.Birthday = dateTimePicker1.Value;
            teacher.Email = txtBxEmail.Text;
            teacher.Phone = maskedTextBox1.Text;
            teacher.Post = comboBox1.SelectedItem as Post;
            teacher.Rate = (double)numericUpDown1.Value;
            teacher.Experience = (int)numericUpDown2.Value;
            teacher.TeacherSubjects = subjects;

            DBController.Instance.Update(teacher);
            DialogResult = DialogResult.OK;
        }

        private void NewTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateSubjects()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = subjects;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            NewTeacherSubjectForm form = new NewTeacherSubjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                subjects.Add(form.Subject);

                UpdateSubjects();
            }
        }
    }
}
