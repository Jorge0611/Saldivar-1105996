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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Homework\\1105996_Saldivar\\1105996.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(txtIdentifier.Text);
            SqlCommand c = new SqlCommand("delete Food where Id='"+id+"' ", con);
            c.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
