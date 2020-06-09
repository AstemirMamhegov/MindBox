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
    public partial class NewCountryForm : Form
    {
        private Country country;

        public NewCountryForm(Country country = null)
        {
            InitializeComponent();

            if (country != null)
            {
                this.country = country;
                txtBxName.Text = country.Name;
                checkBox1.Checked = country.IsDefault;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBxName.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (country == null)
                country = new Country();
            country.Name = txtBxName.Text;
            country.IsDefault = checkBox1.Checked;

            DBController.Instance.Update(country);
            DialogResult = DialogResult.OK;
        }
    }
}
