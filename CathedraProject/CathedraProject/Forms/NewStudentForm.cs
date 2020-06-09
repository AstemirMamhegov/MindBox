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
    public partial class NewStudentForm : Form
    {
        private Address address;
        private Address addressFact;
        private Student student;
        private Parent mother, father;

        public NewStudentForm(Student student = null)
        {
            InitializeComponent();

            comboBox1.DataSource = DBController.Instance.Directions;
            comboBox2.DataSource = DBController.Instance.Groups;
            comboBoxStatuses.DataSource = DBController.Instance.Statuses;

            if (student != null)
            {
                this.student = student;
                address = student.Address;
                addressFact = student.FactAddress;

                txtBxAddress.Text = address?.ToString();
                txtBxAddressFact.Text = addressFact?.ToString();
                txtBxEmail.Text = student.Email;
                txtBxFirstName.Text = student.FirstName;
                txtBxLastName.Text = student.LastName;
                txtBxMiddleName.Text = student.MiddleName;
                dateTimePicker1.Value = student.Birthday;
                maskedTextBox1.Text = student.Phone;
                numericUpDown1.Value = student.Course;
                comboBox1.SelectedItem = student.Direction;
                comboBox2.SelectedItem = student.Group;
                comboBoxSex.SelectedIndex = (int)student.Sex;
                txtBxActivity.Text = student.Activity;
                txtBxEducation.Text = student.Education;
                comboBox3.Text = student.StatusFamily;
                comboBoxStatuses.SelectedItem = student.Status;
                txtBxPlaceWork.Text = student.PlaceWork;

                mother = student.Mother;
                father = student.Father;

                txtBxFather.Text = father?.FIO;
                txtBxMother.Text = mother?.FIO;
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
            if (student == null)
            {
                student = new Student();
                student.CreateDate = DateTime.Now;
            }

            student.LastName = txtBxLastName.Text;
            student.MiddleName = txtBxMiddleName.Text;
            student.FirstName = txtBxFirstName.Text;
            student.Address = address;
            student.FactAddress = addressFact;
            student.Birthday = dateTimePicker1.Value;
            student.Email = txtBxEmail.Text;
            student.Phone = maskedTextBox1.Text;
            student.Group = comboBox2.SelectedItem as Group;
            student.Direction = comboBox1.SelectedItem as Direction;
            student.Course = (int)numericUpDown1.Value;
            student.Mother = mother;
            student.Father = father;
            student.Sex = (Sex)comboBoxSex.SelectedIndex;
            student.Activity = txtBxActivity.Text;
            student.Education = txtBxEducation.Text;
            student.StatusFamily = comboBox3.Text;
            student.Status = comboBoxStatuses.SelectedItem as Status;
            student.PlaceWork = txtBxPlaceWork.Text;

            DBController.Instance.Update(student);
            DialogResult = DialogResult.OK;
        }

        private void btnOpenMarks_Click(object sender, EventArgs e)
        {
            if (student == null)
                MessageBox.Show("Сохраните объект");
            else
            {
                MarksForm form = new MarksForm(student);
                form.Show();
            }
        }

        private void NewStudentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentParentForm form = new StudentParentForm(father);
            if (form.ShowDialog() == DialogResult.OK)
            {
                father = form.StudentParent;
                txtBxFather.Text = form.StudentParent.FIO;
            }
        }

        private void btnOpWork_Click(object sender, EventArgs e)
        {
            if (student == null)
                MessageBox.Show("Сохраните объект");
            else
            {
                StudentWorkForm form = new StudentWorkForm(student);
                form.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddressForm form = new AddressForm(addressFact);
            if (form.ShowDialog() == DialogResult.OK)
            {
                addressFact = form.Address;

                txtBxAddressFact.Text = addressFact.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentParentForm form = new StudentParentForm(mother);
            if (form.ShowDialog() == DialogResult.OK)
            {
                mother = form.StudentParent;
                txtBxMother.Text = form.StudentParent.FIO;
            }
        }
    }
}
