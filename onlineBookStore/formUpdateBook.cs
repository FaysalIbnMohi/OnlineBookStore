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
    public partial class formUpdateBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public formUpdateBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BookName;
            BookName = txtTitle.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from BookTable where Title='"+BookName+"'";
            cmd.ExecuteNonQuery();
   
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            updateDataGridView.DataSource = dt;
            con.Close();
            MessageBox.Show("Book Found!");

        }

        private void formUpdateBook_Load(object sender, EventArgs e)
        {
            string BookName;
            BookName = txtTitle.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from BookTable where Title='" + BookName + "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            updateDataGridView.DataSource = dt;
            con.Close();
            // displayData();

        }

        private void updateDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string BookName;
            int NewAvailableCopy;
            double NewPrice;
            BookName = txtTitle.Text;
            NewPrice = Convert.ToDouble(txtPrice.Text);
            NewAvailableCopy = Int32.Parse(txtAvailableCopy.Text);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update BookTable Set Price='"+NewPrice+ "',AvailableCopy='" + NewAvailableCopy + "'Where Title='" + BookName + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book Updated!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form adminForm = new adminForm();
            adminForm.Show();
            this.Close();
        }
    }
}
