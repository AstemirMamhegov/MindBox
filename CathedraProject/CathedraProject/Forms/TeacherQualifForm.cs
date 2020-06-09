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
    public partial class TeacherQualifForm : Form
    {
        private Qualification qualification;
        public Qualification Qualification
        {
            get
            {
                return qualification;
            }
        }

        public TeacherQualifForm(Qualification qualification = null)
        {
            InitializeComponent();

            if (qualification != null)
            {
                this.qualification = qualification;

                txtBxName.Text = qualification.Name;
                numUpDownVolume.Value = qualification.Hours;
                dateTimePicker1.Value = qualification.Date;
                textBox1.Text = qualification.IDReg;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (qualification == null)
                qualification = new Qualification();

            qualification.Name = txtBxName.Text;
            qualification.Hours = (int)numUpDownVolume.Value;
            qualification.IDReg = textBox1.Text;
            qualification.Date = dateTimePicker1.Value;

            DialogResult = DialogResult.OK;
        }
    }
}
