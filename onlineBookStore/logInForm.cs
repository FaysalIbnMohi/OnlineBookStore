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
    public partial class logInForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public logInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = "faisal";
            string pass = "faisal123";
            string email = userNameTxt.Text;
            string Pass = PasswordTxt.Text;


            con.Open();
            SqlCommand comm = new SqlCommand("SELECT count(*) FROM UserTable where Email='" + email + "' and Password='" + Pass + "'", con);
            Int32 count = (Int32)comm.ExecuteScalar();

            if (email == name && Pass == pass)
            {
                //MessageBox.Show("valid user!");
                Form adminForm = new adminForm();
                adminForm.Show();
               // this.Hide();
            }
            else if (count>0)
            {
                //MessageBox.Show("valid user!");
                Form userForm = new userForm();
                userForm.Show();
                // this.Hide();
                //this.Close();
            }
            else MessageBox.Show("Invalid User!");
            con.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form SignUpLbl = new SignUpLbl();
            SignUpLbl.Show();
           // this.Close();


            // this.Hide();
        }
       /* public class SignUpLbl : Form
        {
            public SignUpLbl()
            {
                Text = "SignUp";
            }

        }*/
    }

}
