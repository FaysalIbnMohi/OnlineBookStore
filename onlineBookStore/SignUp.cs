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
    public partial class SignUpLbl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\ProjectDB.mdf;Integrated Security=True;Connect Timeout=30");
        public SignUpLbl()
        {
            InitializeComponent();
        }


        private void SignUp_Load(object sender, EventArgs e)
        {


        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string Name, Email, Password, MobileNumber;
            Name = nameTxt.Text;
            Email = emailTxt.Text;
            Password = passTxt.Text;
            MobileNumber = mobileTxt.Text;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into UserTable values('" + Name + "','" + Email + "','" + Password + "','" + MobileNumber + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sign Up Success!");
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form logInForm = new logInForm();
            logInForm.Show();
            //this.Close();
        }
    }
    }

    
