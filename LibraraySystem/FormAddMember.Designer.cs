namespace LibraraySystem
{
    partial class FormAddMember
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
            TBoxMemID = new TextBox();
            grbAddBook = new GroupBox();
            TBoxEmail = new TextBox();
            AddMemberBt = new Button();
            TboxFirstName = new TextBox();
            TBoxSurname = new TextBox();
            TBoxPhone = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbAddBook.SuspendLayout();
            SuspendLayout();
            // 
            // TBoxMemID
            // 
            TBoxMemID.Location = new Point(151, 50);
            TBoxMemID.Name = "TBoxMemID";
            TBoxMemID.ReadOnly = true;
            TBoxMemID.Size = new Size(59, 23);
            TBoxMemID.TabIndex = 5;
            // 
            // grbAddBook
            // 
            grbAddBook.Controls.Add(TBoxEmail);
            grbAddBook.Controls.Add(AddMemberBt);
            grbAddBook.Controls.Add(TboxFirstName);
            grbAddBook.Controls.Add(TBoxSurname);
            grbAddBook.Controls.Add(TBoxPhone);
            grbAddBook.Controls.Add(label5);
            grbAddBook.Controls.Add(label4);
            grbAddBook.Controls.Add(label3);
            grbAddBook.Controls.Add(label2);
            grbAddBook.Location = new Point(100, 83);
            grbAddBook.Name = "grbAddBook";
            grbAddBook.Size = new Size(501, 214);
            grbAddBook.TabIndex = 4;
            grbAddBook.TabStop = false;
            grbAddBook.Text = "Enter Member Details";
            // 
            // TBoxEmail
            // 
            TBoxEmail.Location = new Point(94, 137);
            TBoxEmail.Name = "TBoxEmail";
            TBoxEmail.Size = new Size(210, 23);
            TBoxEmail.TabIndex = 8;
            // 
            // AddMemberBt
            // 
            AddMemberBt.Location = new Point(129, 176);
            AddMemberBt.Name = "AddMemberBt";
            AddMemberBt.Size = new Size(112, 23);
            AddMemberBt.TabIndex = 2;
            AddMemberBt.Text = "Add Member";
            AddMemberBt.UseVisualStyleBackColor = true;
            AddMemberBt.Click += AddMemberBt_Click;
            // 
            // TboxFirstName
            // 
            TboxFirstName.Location = new Point(94, 33);
            TboxFirstName.Name = "TboxFirstName";
            TboxFirstName.Size = new Size(210, 23);
            TboxFirstName.TabIndex = 7;
            // 
            // TBoxSurname
            // 
            TBoxSurname.Location = new Point(94, 68);
            TBoxSurname.Name = "TBoxSurname";
            TBoxSurname.Size = new Size(210, 23);
            TBoxSurname.TabIndex = 6;
            // 
            // TBoxPhone
            // 
            TBoxPhone.Location = new Point(94, 103);
            TBoxPhone.Name = "TBoxPhone";
            TBoxPhone.Size = new Size(210, 23);
            TBoxPhone.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 106);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 71);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 36);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 140);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 53);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "MemID";
            label1.Click += label1_Click;
            // 
            // FormAddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 346);
            Controls.Add(TBoxMemID);
            Controls.Add(grbAddBook);
            Controls.Add(label1);
            Name = "FormAddMember";
            Text = "FormAddMember";
            Load += FormAddMember_Load;
            grbAddBook.ResumeLayout(false);
            grbAddBook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBoxMemID;
        private GroupBox grbAddBook;
        private Button AddMemberBt;
        private TextBox TboxFirstName;
        private TextBox TBoxSurname;
        private TextBox TBoxPhone;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TBoxEmail;
    }
}