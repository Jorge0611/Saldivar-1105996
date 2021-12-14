using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1105996_Saldivar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var createForm = new Views.CreateForm();
            createForm.Show();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var readForm = new Views.ReadForm();
            readForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateForm = new Views.UpdateForm();
            updateForm.Show();  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteForm = new Views.DeleteForm();
            deleteForm.Show();
        }
    }
}
