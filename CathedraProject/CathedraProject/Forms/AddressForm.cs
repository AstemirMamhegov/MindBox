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
    public partial class AddressForm : Form
    {
        private Address address;

        public Address Address
        {
            get
            {
                return address;
            }
        }

        public AddressForm(Address address = null)
        {
            InitializeComponent();

            comboBox1.DataSource = DBController.Instance.Countries;

            if (address != null)
            {
                this.address = address;

                comboBox1.SelectedItem = address.Country;
                txtBxCity.Text = address.City;
                txtBxHome.Text = address.NumberHouse;
                txtBxStreet.Text = address.Street;
                numericUpDown2.Value = address.NumberFlat;
            }
            else
            {
                comboBox1.SelectedItem = DBController.Instance.Countries.FirstOrDefault(t => t.IsDefault);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (address == null)
                address = new Address();

            address.Country = comboBox1.SelectedItem as Country;
            address.City = txtBxCity.Text;
            address.NumberHouse = txtBxHome.Text;
            address.Street = txtBxStreet.Text;
            address.NumberFlat = (int)numericUpDown2.Value;

            DialogResult = DialogResult.OK;
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBxStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBxHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
