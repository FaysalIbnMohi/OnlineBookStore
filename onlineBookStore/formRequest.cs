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
    public partial class formRequest : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public formRequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Quantity = Int32.Parse(txtQuntity.Text);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into RequestTable values('" + txtTitle.Text + "','" + txtAuthor.Text + "','" + Quantity +  "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Request Confirmed!");
            Form userForm = new userForm();
            userForm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form userForm = new userForm();
            userForm.Show();
            this.Close();
        }
    }
}
