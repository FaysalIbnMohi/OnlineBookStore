using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace onlineBookStore
{
    public partial class adminForm : Form
    {

        public adminForm()
        {
            InitializeComponent();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            Form formAdd = new formAdd();
            formAdd.Show();
            this.Close();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            Form formRemoveUser = new formRemoveUser();
            formRemoveUser.Show();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form formRemoveBook = new formRemoveBook();
            formRemoveBook.Show();
           
                
           
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            Form formUpdateBook = new formUpdateBook();
            formUpdateBook.Show();
            this.Close();

        }

        private void bookListBtn_Click(object sender, EventArgs e)
        {
            Form formBookList = new formBookList();
            formBookList.Show();
            this.Close();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void userRequestBtn_Click(object sender, EventArgs e)
        {
            Form formShowRequest = new formShowRequest();
            formShowRequest.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
