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
    public partial class formAdd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public formAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Title, Author;
            int  AvailableCopy;
            double Price;
            Title = txtTitle.Text;
            Author = txtAuthor.Text;
            Price = Convert.ToDouble(txtPrice.Text);
            AvailableCopy = Int32.Parse(txtAvailableCopy.Text);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into BookTable values('" + Title + "','" + Author + "','" + Price + "','" + AvailableCopy + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book Added!");
            Form adminForm = new adminForm();
            adminForm.Show();
            this.Close();
        }

        private void txtAvailableCopy_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form adminForm = new adminForm();
            adminForm.Show();
        }

        private void formAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
