namespace onlineBookStore
{
    partial class adminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBookBtn = new System.Windows.Forms.Button();
            this.orderListBtn = new System.Windows.Forms.Button();
            this.userRequestBtn = new System.Windows.Forms.Button();
            this.deliveryBtn = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.bookListBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(31, 33);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(70, 50);
            this.addBookBtn.TabIndex = 0;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // orderListBtn
            // 
            this.orderListBtn.Location = new System.Drawing.Point(31, 129);
            this.orderListBtn.Name = "orderListBtn";
            this.orderListBtn.Size = new System.Drawing.Size(70, 50);
            this.orderListBtn.TabIndex = 1;
            this.orderListBtn.Text = "Order List";
            this.orderListBtn.UseVisualStyleBackColor = true;
            // 
            // userRequestBtn
            // 
            this.userRequestBtn.Location = new System.Drawing.Point(328, 222);
            this.userRequestBtn.Name = "userRequestBtn";
            this.userRequestBtn.Size = new System.Drawing.Size(70, 50);
            this.userRequestBtn.TabIndex = 2;
            this.userRequestBtn.Text = "User Request";
            this.userRequestBtn.UseVisualStyleBackColor = true;
            this.userRequestBtn.Click += new System.EventHandler(this.userRequestBtn_Click);
            // 
            // deliveryBtn
            // 
            this.deliveryBtn.Location = new System.Drawing.Point(31, 222);
            this.deliveryBtn.Name = "deliveryBtn";
            this.deliveryBtn.Size = new System.Drawing.Size(70, 50);
            this.deliveryBtn.TabIndex = 3;
            this.deliveryBtn.Text = "Delivery";
            this.deliveryBtn.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(176, 129);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(70, 50);
            this.btnRemoveUser.TabIndex = 4;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // bookListBtn
            // 
            this.bookListBtn.Location = new System.Drawing.Point(328, 129);
            this.bookListBtn.Name = "bookListBtn";
            this.bookListBtn.Size = new System.Drawing.Size(70, 50);
            this.bookListBtn.TabIndex = 5;
            this.bookListBtn.Text = "Book List";
            this.bookListBtn.UseVisualStyleBackColor = true;
            this.bookListBtn.Click += new System.EventHandler(this.bookListBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(176, 222);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(70, 50);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(651, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 62);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(176, 33);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 50);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Book";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(328, 33);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(70, 50);
            this.btnUpdateBook.TabIndex = 10;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(328, 315);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(70, 22);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 438);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.bookListBtn);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.deliveryBtn);
            this.Controls.Add(this.userRequestBtn);
            this.Controls.Add(this.orderListBtn);
            this.Controls.Add(this.addBookBtn);
            this.Name = "adminForm";
            this.Text = "adminForm";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button orderListBtn;
        private System.Windows.Forms.Button userRequestBtn;
        private System.Windows.Forms.Button deliveryBtn;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button bookListBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnHome;
    }
}