using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace onlineBookStore
{
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Order()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
           // txtTitle.Text = "Hello";  
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form userForm = new userForm();
            userForm.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
           

            DialogResult res = MessageBox.Show("Are you sure you want to Order?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                string Title, Email, Address;
                int mobileNumber, Quantity,Id;
                Title = txtTitle.Text;
                Email = txtTitle.Text;
                Address = txtAddress.Text;
                Id=Int32.Parse(txtId.Text);
                mobileNumber = Int32.Parse(txtMobileNumber.Text);
                Quantity= Int32.Parse(txtQuantity.Text);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = cmd.CommandText = "Insert into OrderTable(Id,Title,Email,MobileNumber,UserAddress,Quantity) values('"+Id+"','" + Title + "','" + Email + "','" + mobileNumber + "','" + Address + "','" + Quantity + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Order Has Been Confirmed!");
            }
            if (res == DialogResult.Cancel)
            {
                Form userForm = new userForm();
                userForm.Show();

            }
        
    }
    }
}
