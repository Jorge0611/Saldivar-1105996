using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1105996_Saldivar.Views
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Homework\\1105996_Saldivar\\1105996.mdf;Integrated Security=True;Connect Timeout=30");

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(txtIdentifier.Text);
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            string description = txtDescription.Text;
            SqlCommand c = new SqlCommand("update Food set name = '" + name + "', description = '" + description + "', price = '" + price + "' where Id = '" + id + "' ", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Updated");
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
