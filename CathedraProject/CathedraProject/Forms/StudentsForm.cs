using CathedraProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CathedraProject
{
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Students;
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            comboBoxDirection.Items.Add("Все");
            comboBoxDirection.Items.AddRange(DBController.Instance.Directions.ToArray());

            comboBoxGroup.Items.Add("Все");
            comboBoxGroup.Items.AddRange(DBController.Instance.Groups.ToArray());

            comboBoxCourse.SelectedIndex = 0;
            comboBoxDirection.SelectedIndex = 0;
            comboBoxGroup.SelectedIndex = 0;
            comboBoxMark.SelectedIndex = 0;

            WindowState = FormWindowState.Maximized;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewStudentForm form = new NewStudentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStudent();
        }

        private void OpenStudent()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Student student = dataGridView1.SelectedRows[0].DataBoundItem as Student;

                NewStudentForm form = new NewStudentForm(student);
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
                Student student = dataGridView1.SelectedRows[0].DataBoundItem as Student;

                DBController.Instance.Remove(student);
                UpdateGrid();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var students = DBController.Instance.Students;

            if (comboBoxCourse.Text != "Все")
            {
                int course = int.Parse(comboBoxCourse.Text);
                students = students.Where(t => t.Course == course).ToList();
            }

            if (comboBoxDirection.Text != "Все")
            {
                Direction direction = comboBoxDirection.SelectedItem as Direction;
                students = students.Where(t => t.Direction == direction).ToList();
            }

            if (comboBoxGroup.Text != "Все")
            {
                Group group = comboBoxGroup.SelectedItem as Group;
                students = students.Where(t => t.Group == group).ToList();
            }

            if (comboBoxMark.Text != "Все")
            {
                if (comboBoxMark.SelectedIndex == 1)
                    students = students.Where(t => t.Marks.Count(p=>p.Mark == 5) >= 0.75 * t.Marks.Count && t.Marks.Count(p=>p.Mark < 4) == 0).ToList();
                else if (comboBoxMark.SelectedIndex == 2)
                    students = students.Where(t => t.Marks.Count(p => p.Mark == 5) < 0.75 * t.Marks.Count && t.Marks.Count(p => p.Mark < 4) == 0).ToList();
                else if (comboBoxMark.SelectedIndex == 3)
                    students = students.Where(t => t.Marks.Count(p => p.Mark == 3) > 0 && t.Marks.Count(p => p.Mark == 2) == 0).ToList();
                else
                    students = students.Where(t => t.Marks.Count(p => p.Mark == 2) > 0).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenStudent();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<Student> students = (List<Student>)dataGridView1.DataSource;

                ExcelManager.ExportStudents(saveFileDialog1.FileName, students);
            }
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Student student = dataGridView1.SelectedRows[0].DataBoundItem as Student;

                saveFileDialog2.FileName = student.FIO;
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog2.FileName;

                    if (File.Exists(filename))
                        File.Delete(filename);

                    File.Copy("Личная карта студента.docx", filename);

                    WordManager.Export(student, filename);
                }
            }

            
        }
    }
}
