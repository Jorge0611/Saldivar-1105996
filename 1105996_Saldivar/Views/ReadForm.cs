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
    public partial class ReadForm : Form
    {
        public ReadForm()
        {
            InitializeComponent();
            BindData();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Homework\\1105996_Saldivar\\1105996.mdf;Integrated Security=True;Connect Timeout=30");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReadForm_Load(object sender, EventArgs e)
        {

        }

        void BindData()
        {
            SqlCommand cmd = new SqlCommand("select * from Food", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
