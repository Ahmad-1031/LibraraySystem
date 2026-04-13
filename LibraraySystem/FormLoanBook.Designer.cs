namespace LibraraySystem
{
    partial class FormLoanBook
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
            grdBooks = new DataGridView();
            SearchBt = new Button();
            TBoxSearchB = new TextBox();
            grdMembers = new DataGridView();
            grpMemberName = new GroupBox();
            SearchNameBt = new Button();
            TboxNameS = new TextBox();
            label3 = new Label();
            grpMemberID = new GroupBox();
            SearchMemberIDBt = new Button();
            TboxMemberIDS = new TextBox();
            label2 = new Label();
            OPName = new Button();
            OPMemID = new Button();
            label4 = new Label();
            label1 = new Label();
            grbMemberDetails = new GroupBox();
            LabelEmail = new Label();
            LabelPhone = new Label();
            LabelSurname = new Label();
            LabelFirstName = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            grpBookDetails = new GroupBox();
            TboxDescription = new TextBox();
            LabelGenre = new Label();
            LabelAuthor = new Label();
            LabelBookTitle = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            grpLoanDetails = new GroupBox();
            LoanBookBT = new Button();
            DTPdueDate = new DateTimePicker();
            label18 = new Label();
            label19 = new Label();
            DTPstartDate = new DateTimePicker();
            label17 = new Label();
            LabelMemberID = new Label();
            label15 = new Label();
            label16 = new Label();
            LabelBookID = new Label();
            label14 = new Label();
            LabelLoanID = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdMembers).BeginInit();
            grpMemberName.SuspendLayout();
            grpMemberID.SuspendLayout();
            grbMemberDetails.SuspendLayout();
            grpBookDetails.SuspendLayout();
            grpLoanDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grdBooks
            // 
            grdBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBooks.Location = new Point(12, 240);
            grdBooks.Name = "grdBooks";
            grdBooks.Size = new Size(613, 196);
            grdBooks.TabIndex = 7;
            grdBooks.CellClick += grdBooks_CellClick;
            // 
            // SearchBt
            // 
            SearchBt.BackColor = Color.Green;
            SearchBt.ForeColor = SystemColors.ControlLight;
            SearchBt.Location = new Point(420, 185);
            SearchBt.Name = "SearchBt";
            SearchBt.Size = new Size(119, 24);
            SearchBt.TabIndex = 6;
            SearchBt.Text = "Search Book";
            SearchBt.UseVisualStyleBackColor = false;
            SearchBt.Click += SearchBt_Click;
            // 
            // TBoxSearchB
            // 
            TBoxSearchB.Location = new Point(66, 187);
            TBoxSearchB.Name = "TBoxSearchB";
            TBoxSearchB.Size = new Size(348, 23);
            TBoxSearchB.TabIndex = 4;
            // 
            // grdMembers
            // 
            grdMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMembers.Location = new Point(664, 240);
            grdMembers.Name = "grdMembers";
            grdMembers.Size = new Size(558, 196);
            grdMembers.TabIndex = 16;
            grdMembers.CellClick += grdMembers_CellClick;
            // 
            // grpMemberName
            // 
            grpMemberName.Controls.Add(SearchNameBt);
            grpMemberName.Controls.Add(TboxNameS);
            grpMemberName.Controls.Add(label3);
            grpMemberName.Location = new Point(735, 160);
            grpMemberName.Name = "grpMemberName";
            grpMemberName.Size = new Size(431, 74);
            grpMemberName.TabIndex = 15;
            grpMemberName.TabStop = false;
            grpMemberName.Text = "Enter Member Name";
            // 
            // SearchNameBt
            // 
            SearchNameBt.Location = new Point(326, 31);
            SearchNameBt.Name = "SearchNameBt";
            SearchNameBt.Size = new Size(64, 23);
            SearchNameBt.TabIndex = 2;
            SearchNameBt.Text = "Search";
            SearchNameBt.UseVisualStyleBackColor = true;
            SearchNameBt.Click += SearchNameBt_Click;
            // 
            // TboxNameS
            // 
            TboxNameS.Location = new Point(123, 31);
            TboxNameS.Name = "TboxNameS";
            TboxNameS.Size = new Size(180, 23);
            TboxNameS.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 35);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // grpMemberID
            // 
            grpMemberID.Controls.Add(SearchMemberIDBt);
            grpMemberID.Controls.Add(TboxMemberIDS);
            grpMemberID.Controls.Add(label2);
            grpMemberID.Location = new Point(735, 80);
            grpMemberID.Name = "grpMemberID";
            grpMemberID.Size = new Size(431, 74);
            grpMemberID.TabIndex = 14;
            grpMemberID.TabStop = false;
            grpMemberID.Text = "Enter Member ID";
            // 
            // SearchMemberIDBt
            // 
            SearchMemberIDBt.Location = new Point(326, 31);
            SearchMemberIDBt.Name = "SearchMemberIDBt";
            SearchMemberIDBt.Size = new Size(64, 23);
            SearchMemberIDBt.TabIndex = 2;
            SearchMemberIDBt.Text = "Search";
            SearchMemberIDBt.UseVisualStyleBackColor = true;
            SearchMemberIDBt.Click += SearchMemberIDBt_Click;
            // 
            // TboxMemberIDS
            // 
            TboxMemberIDS.Location = new Point(123, 31);
            TboxMemberIDS.Name = "TboxMemberIDS";
            TboxMemberIDS.Size = new Size(180, 23);
            TboxMemberIDS.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 35);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Member ID";
            // 
            // OPName
            // 
            OPName.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OPName.Location = new Point(944, 46);
            OPName.Name = "OPName";
            OPName.Size = new Size(93, 28);
            OPName.TabIndex = 13;
            OPName.Text = "Name";
            OPName.UseVisualStyleBackColor = true;
            OPName.Click += OPName_Click;
            // 
            // OPMemID
            // 
            OPMemID.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OPMemID.Location = new Point(845, 46);
            OPMemID.Name = "OPMemID";
            OPMemID.Size = new Size(93, 28);
            OPMemID.TabIndex = 12;
            OPMemID.Text = "Member ID";
            OPMemID.UseVisualStyleBackColor = true;
            OPMemID.Click += OPMemID_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(861, 9);
            label4.Name = "label4";
            label4.Size = new Size(177, 24);
            label4.TabIndex = 11;
            label4.Text = "Search Member By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 108);
            label1.Name = "label1";
            label1.Size = new Size(205, 24);
            label1.TabIndex = 17;
            label1.Text = "Search Book By Name:";
            // 
            // grbMemberDetails
            // 
            grbMemberDetails.Controls.Add(LabelEmail);
            grbMemberDetails.Controls.Add(LabelPhone);
            grbMemberDetails.Controls.Add(LabelSurname);
            grbMemberDetails.Controls.Add(LabelFirstName);
            grbMemberDetails.Controls.Add(label5);
            grbMemberDetails.Controls.Add(label6);
            grbMemberDetails.Controls.Add(label7);
            grbMemberDetails.Controls.Add(label8);
            grbMemberDetails.Location = new Point(746, 453);
            grbMemberDetails.Name = "grbMemberDetails";
            grbMemberDetails.Size = new Size(392, 175);
            grbMemberDetails.TabIndex = 18;
            grbMemberDetails.TabStop = false;
            grbMemberDetails.Text = "Member Details";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(129, 140);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(44, 15);
            LabelEmail.TabIndex = 8;
            LabelEmail.Text = "label11";
            // 
            // LabelPhone
            // 
            LabelPhone.AutoSize = true;
            LabelPhone.Location = new Point(129, 106);
            LabelPhone.Name = "LabelPhone";
            LabelPhone.Size = new Size(44, 15);
            LabelPhone.TabIndex = 7;
            LabelPhone.Text = "label10";
            // 
            // LabelSurname
            // 
            LabelSurname.AutoSize = true;
            LabelSurname.Location = new Point(129, 71);
            LabelSurname.Name = "LabelSurname";
            LabelSurname.Size = new Size(38, 15);
            LabelSurname.TabIndex = 6;
            LabelSurname.Text = "label9";
            // 
            // LabelFirstName
            // 
            LabelFirstName.AutoSize = true;
            LabelFirstName.Location = new Point(129, 36);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(38, 15);
            LabelFirstName.TabIndex = 5;
            LabelFirstName.Text = "label8";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 71);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 3;
            label6.Text = "Surname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 36);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 2;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 140);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 1;
            label8.Text = "Email";
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(TboxDescription);
            grpBookDetails.Controls.Add(LabelGenre);
            grpBookDetails.Controls.Add(LabelAuthor);
            grpBookDetails.Controls.Add(LabelBookTitle);
            grpBookDetails.Controls.Add(label9);
            grpBookDetails.Controls.Add(label10);
            grpBookDetails.Controls.Add(label11);
            grpBookDetails.Controls.Add(label12);
            grpBookDetails.Location = new Point(122, 453);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Size = new Size(417, 254);
            grpBookDetails.TabIndex = 19;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Book Details";
            // 
            // TboxDescription
            // 
            TboxDescription.Location = new Point(88, 136);
            TboxDescription.Multiline = true;
            TboxDescription.Name = "TboxDescription";
            TboxDescription.ReadOnly = true;
            TboxDescription.ScrollBars = ScrollBars.Vertical;
            TboxDescription.Size = new Size(293, 98);
            TboxDescription.TabIndex = 18;
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new Point(133, 106);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new Size(38, 15);
            LabelGenre.TabIndex = 17;
            LabelGenre.Text = "label8";
            // 
            // LabelAuthor
            // 
            LabelAuthor.AutoSize = true;
            LabelAuthor.Location = new Point(133, 71);
            LabelAuthor.Name = "LabelAuthor";
            LabelAuthor.Size = new Size(38, 15);
            LabelAuthor.TabIndex = 16;
            LabelAuthor.Text = "label7";
            // 
            // LabelBookTitle
            // 
            LabelBookTitle.AutoSize = true;
            LabelBookTitle.Location = new Point(133, 36);
            LabelBookTitle.Name = "LabelBookTitle";
            LabelBookTitle.Size = new Size(38, 15);
            LabelBookTitle.TabIndex = 15;
            LabelBookTitle.Text = "label6";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 136);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 14;
            label9.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 71);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 13;
            label10.Text = "Author";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 36);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 12;
            label11.Text = "Book Title";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 106);
            label12.Name = "label12";
            label12.Size = new Size(38, 15);
            label12.TabIndex = 10;
            label12.Text = "Genre";
            // 
            // grpLoanDetails
            // 
            grpLoanDetails.Controls.Add(LoanBookBT);
            grpLoanDetails.Controls.Add(DTPdueDate);
            grpLoanDetails.Controls.Add(label18);
            grpLoanDetails.Controls.Add(label19);
            grpLoanDetails.Controls.Add(DTPstartDate);
            grpLoanDetails.Controls.Add(label17);
            grpLoanDetails.Controls.Add(LabelMemberID);
            grpLoanDetails.Controls.Add(label15);
            grpLoanDetails.Controls.Add(label16);
            grpLoanDetails.Controls.Add(LabelBookID);
            grpLoanDetails.Controls.Add(label14);
            grpLoanDetails.Controls.Add(LabelLoanID);
            grpLoanDetails.Controls.Add(label13);
            grpLoanDetails.Location = new Point(420, 713);
            grpLoanDetails.Name = "grpLoanDetails";
            grpLoanDetails.Size = new Size(432, 254);
            grpLoanDetails.TabIndex = 20;
            grpLoanDetails.TabStop = false;
            grpLoanDetails.Text = "Loan Details";
            // 
            // LoanBookBT
            // 
            LoanBookBT.Location = new Point(162, 208);
            LoanBookBT.Name = "LoanBookBT";
            LoanBookBT.Size = new Size(110, 23);
            LoanBookBT.TabIndex = 12;
            LoanBookBT.Text = "Loan Book";
            LoanBookBT.UseVisualStyleBackColor = true;
            LoanBookBT.Click += LoanBookBT_Click;
            // 
            // DTPdueDate
            // 
            DTPdueDate.Location = new Point(149, 165);
            DTPdueDate.Name = "DTPdueDate";
            DTPdueDate.Size = new Size(201, 23);
            DTPdueDate.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(65, 165);
            label18.Name = "label18";
            label18.Size = new Size(67, 15);
            label18.TabIndex = 10;
            label18.Text = "Due Date :  ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(65, 150);
            label19.Name = "label19";
            label19.Size = new Size(0, 15);
            label19.TabIndex = 9;
            // 
            // DTPstartDate
            // 
            DTPstartDate.Location = new Point(149, 130);
            DTPstartDate.Name = "DTPstartDate";
            DTPstartDate.Size = new Size(201, 23);
            DTPstartDate.TabIndex = 8;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(65, 136);
            label17.Name = "label17";
            label17.Size = new Size(70, 15);
            label17.TabIndex = 7;
            label17.Text = "Start Date :  ";
            // 
            // LabelMemberID
            // 
            LabelMemberID.AutoSize = true;
            LabelMemberID.Location = new Point(149, 80);
            LabelMemberID.Name = "LabelMemberID";
            LabelMemberID.Size = new Size(85, 15);
            LabelMemberID.TabIndex = 6;
            LabelMemberID.Text = "No Member ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(65, 80);
            label15.Name = "label15";
            label15.Size = new Size(78, 15);
            label15.TabIndex = 5;
            label15.Text = "Member ID :  ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(65, 121);
            label16.Name = "label16";
            label16.Size = new Size(0, 15);
            label16.TabIndex = 4;
            // 
            // LabelBookID
            // 
            LabelBookID.AutoSize = true;
            LabelBookID.Location = new Point(149, 106);
            LabelBookID.Name = "LabelBookID";
            LabelBookID.Size = new Size(67, 15);
            LabelBookID.TabIndex = 3;
            LabelBookID.Text = "No Book ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(65, 106);
            label14.Name = "label14";
            label14.Size = new Size(60, 15);
            label14.TabIndex = 2;
            label14.Text = "Book ID :  ";
            // 
            // LabelLoanID
            // 
            LabelLoanID.AutoSize = true;
            LabelLoanID.Location = new Point(149, 52);
            LabelLoanID.Name = "LabelLoanID";
            LabelLoanID.Size = new Size(44, 15);
            LabelLoanID.TabIndex = 1;
            LabelLoanID.Text = "label14";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(65, 52);
            label13.Name = "label13";
            label13.Size = new Size(53, 15);
            label13.TabIndex = 0;
            label13.Text = "Loan ID :";
            // 
            // FormLoanBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 974);
            Controls.Add(grpLoanDetails);
            Controls.Add(grpBookDetails);
            Controls.Add(grbMemberDetails);
            Controls.Add(label1);
            Controls.Add(grdMembers);
            Controls.Add(grpMemberName);
            Controls.Add(grpMemberID);
            Controls.Add(OPName);
            Controls.Add(OPMemID);
            Controls.Add(label4);
            Controls.Add(grdBooks);
            Controls.Add(SearchBt);
            Controls.Add(TBoxSearchB);
            Name = "FormLoanBook";
            Text = "Loan Book";
            Load += FormLoanBook_Load;
            ((System.ComponentModel.ISupportInitialize)grdBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdMembers).EndInit();
            grpMemberName.ResumeLayout(false);
            grpMemberName.PerformLayout();
            grpMemberID.ResumeLayout(false);
            grpMemberID.PerformLayout();
            grbMemberDetails.ResumeLayout(false);
            grbMemberDetails.PerformLayout();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            grpLoanDetails.ResumeLayout(false);
            grpLoanDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdBooks;
        private Button SearchBt;
        private TextBox TBoxSearchB;
        private DataGridView grdMembers;
        private GroupBox grpMemberName;
        private Button SearchNameBt;
        private TextBox TboxNameS;
        private Label label3;
        private GroupBox grpMemberID;
        private Button SearchMemberIDBt;
        private TextBox TboxMemberIDS;
        private Label label2;
        private Button OPName;
        private Button OPMemID;
        private Label label4;
        private Label label1;
        private GroupBox grbMemberDetails;
        private Label LabelEmail;
        private Label LabelPhone;
        private Label LabelSurname;
        private Label LabelFirstName;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox grpBookDetails;
        private TextBox TboxDescription;
        private Label LabelGenre;
        private Label LabelAuthor;
        private Label LabelBookTitle;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox grpLoanDetails;
        private Label label13;
        private Label LabelLoanID;
        private Label label14;
        private Label label16;
        private Label LabelBookID;
        private DateTimePicker DTPdueDate;
        private Label label18;
        private Label label19;
        private DateTimePicker DTPstartDate;
        private Label label17;
        private Label LabelMemberID;
        private Label label15;
        private Button LoanBookBT;
    }
}