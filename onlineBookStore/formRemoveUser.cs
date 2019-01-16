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
    public partial class formRemoveUser : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");

        public formRemoveUser()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Email = txtEmail.Text;
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from UserTable where Name='" + UserName + "' and Email='" + Email + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Deleted!");
                Form adminForm = new adminForm();
                adminForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(string.Format("Invalid User"), ex);
            }
        }

        private void formRemoveUser_Load(object sender, EventArgs e)
        {

        }
    }
}
