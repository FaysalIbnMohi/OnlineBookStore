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
    public partial class userForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public userForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string search = searchTxt.Text;
           // string title = searchCombo.Text;
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from BookTable where Title Like '%"+search+"%'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            Form order = new Order();
            order.Show();
            this.Close();

        }

        private void offerBtn_Click(object sender, EventArgs e)
        {
            Form formRequest = new formRequest();
            formRequest.Show();
            this.Close();
        }
    }
}
