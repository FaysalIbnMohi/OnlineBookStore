using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace onlineBookStore
{
    public partial class formRemoveBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public formRemoveBook()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                   
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from BookTable where Title='" + txtTitle.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Book Removed!");
                this.Close();
            }
            if (res == DialogResult.Cancel)
            {
                Form adminForm = new adminForm();
                adminForm.Show();
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void formRemoveBook_Load(object sender, EventArgs e)
        {

        }
    }
}
