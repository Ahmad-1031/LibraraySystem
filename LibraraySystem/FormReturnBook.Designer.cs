namespace LibraraySystem
{
    partial class FormReturnBook
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
            grdLoans = new DataGridView();
            grbLoanDetails = new GroupBox();
            ReturnLoanBt = new Button();
            DTPReturnDate = new DateTimePicker();
            label11 = new Label();
            LabelDueDate = new Label();
            label9 = new Label();
            LabelStartDate = new Label();
            label6 = new Label();
            LabelBookID = new Label();
            label7 = new Label();
            LabelMemberID = new Label();
            label5 = new Label();
            LabelLoanID = new Label();
            label1 = new Label();
            grbSelectLoan = new GroupBox();
            grbSelectMember = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grdMembers).BeginInit();
            grpMemberName.SuspendLayout();
            grpMemberID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLoans).BeginInit();
            grbLoanDetails.SuspendLayout();
            grbSelectLoan.SuspendLayout();
            grbSelectMember.SuspendLayout();
            SuspendLayout();
            // 
            // grdMembers
            // 
            grdMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMembers.Location = new Point(16, 22);
            grdMembers.Name = "grdMembers";
            grdMembers.Size = new Size(534, 209);
            grdMembers.TabIndex = 22;
            grdMembers.CellClick += grdMembers_CellClick;
            // 
            // grpMemberName
            // 
            grpMemberName.Controls.Add(SearchNameBt);
            grpMemberName.Controls.Add(TboxNameS);
            grpMemberName.Controls.Add(label3);
            grpMemberName.Location = new Point(14, 206);
            grpMemberName.Name = "grpMemberName";
            grpMemberName.Size = new Size(431, 74);
            grpMemberName.TabIndex = 21;
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
            grpMemberID.Location = new Point(14, 126);
            grpMemberID.Name = "grpMemberID";
            grpMemberID.Size = new Size(431, 74);
            grpMemberID.TabIndex = 20;
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
            OPName.Location = new Point(223, 92);
            OPName.Name = "OPName";
            OPName.Size = new Size(93, 28);
            OPName.TabIndex = 19;
            OPName.Text = "Name";
            OPName.UseVisualStyleBackColor = true;
            OPName.Click += OPName_Click;
            // 
            // OPMemID
            // 
            OPMemID.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OPMemID.Location = new Point(124, 92);
            OPMemID.Name = "OPMemID";
            OPMemID.Size = new Size(93, 28);
            OPMemID.TabIndex = 18;
            OPMemID.Text = "Member ID";
            OPMemID.UseVisualStyleBackColor = true;
            OPMemID.Click += OPMemID_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(140, 55);
            label4.Name = "label4";
            label4.Size = new Size(177, 24);
            label4.TabIndex = 17;
            label4.Text = "Search Member By:";
            // 
            // grdLoans
            // 
            grdLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLoans.Location = new Point(16, 22);
            grdLoans.Name = "grdLoans";
            grdLoans.Size = new Size(534, 212);
            grdLoans.TabIndex = 23;
            grdLoans.CellClick += grdLoans_CellClick;
            // 
            // grbLoanDetails
            // 
            grbLoanDetails.Controls.Add(ReturnLoanBt);
            grbLoanDetails.Controls.Add(DTPReturnDate);
            grbLoanDetails.Controls.Add(label11);
            grbLoanDetails.Controls.Add(LabelDueDate);
            grbLoanDetails.Controls.Add(label9);
            grbLoanDetails.Controls.Add(LabelStartDate);
            grbLoanDetails.Controls.Add(label6);
            grbLoanDetails.Controls.Add(LabelBookID);
            grbLoanDetails.Controls.Add(label7);
            grbLoanDetails.Controls.Add(LabelMemberID);
            grbLoanDetails.Controls.Add(label5);
            grbLoanDetails.Controls.Add(LabelLoanID);
            grbLoanDetails.Controls.Add(label1);
            grbLoanDetails.Location = new Point(12, 299);
            grbLoanDetails.Name = "grbLoanDetails";
            grbLoanDetails.Size = new Size(431, 249);
            grbLoanDetails.TabIndex = 24;
            grbLoanDetails.TabStop = false;
            grbLoanDetails.Text = " Loan Details";
            // 
            // ReturnLoanBt
            // 
            ReturnLoanBt.Location = new Point(140, 203);
            ReturnLoanBt.Name = "ReturnLoanBt";
            ReturnLoanBt.Size = new Size(134, 22);
            ReturnLoanBt.TabIndex = 12;
            ReturnLoanBt.Text = "Return Loan";
            ReturnLoanBt.UseVisualStyleBackColor = true;
            ReturnLoanBt.Click += ReturnLoanBt_Click;
            // 
            // DTPReturnDate
            // 
            DTPReturnDate.Location = new Point(128, 164);
            DTPReturnDate.Name = "DTPReturnDate";
            DTPReturnDate.Size = new Size(205, 23);
            DTPReturnDate.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 164);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 10;
            label11.Text = "Return Date : ";
            // 
            // LabelDueDate
            // 
            LabelDueDate.AutoSize = true;
            LabelDueDate.Location = new Point(128, 138);
            LabelDueDate.Name = "LabelDueDate";
            LabelDueDate.Size = new Size(74, 15);
            LabelDueDate.TabIndex = 9;
            LabelDueDate.Text = "No Due Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 138);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 8;
            label9.Text = "Due Date : ";
            // 
            // LabelStartDate
            // 
            LabelStartDate.AutoSize = true;
            LabelStartDate.Location = new Point(128, 114);
            LabelStartDate.Name = "LabelStartDate";
            LabelStartDate.Size = new Size(77, 15);
            LabelStartDate.TabIndex = 7;
            LabelStartDate.Text = "No Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 114);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 6;
            label6.Text = "Start Date : ";
            // 
            // LabelBookID
            // 
            LabelBookID.AutoSize = true;
            LabelBookID.Location = new Point(128, 90);
            LabelBookID.Name = "LabelBookID";
            LabelBookID.Size = new Size(67, 15);
            LabelBookID.TabIndex = 5;
            LabelBookID.Text = "No Book ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 90);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 4;
            label7.Text = "Book ID :";
            // 
            // LabelMemberID
            // 
            LabelMemberID.AutoSize = true;
            LabelMemberID.Location = new Point(128, 65);
            LabelMemberID.Name = "LabelMemberID";
            LabelMemberID.Size = new Size(85, 15);
            LabelMemberID.TabIndex = 3;
            LabelMemberID.Text = "No Member ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 65);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 2;
            label5.Text = "Member ID : ";
            // 
            // LabelLoanID
            // 
            LabelLoanID.AutoSize = true;
            LabelLoanID.Location = new Point(128, 41);
            LabelLoanID.Name = "LabelLoanID";
            LabelLoanID.Size = new Size(99, 15);
            LabelLoanID.TabIndex = 1;
            LabelLoanID.Text = "No Loan Selected";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 41);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Loan ID :";
            // 
            // grbSelectLoan
            // 
            grbSelectLoan.Controls.Add(grdLoans);
            grbSelectLoan.Location = new Point(451, 299);
            grbSelectLoan.Name = "grbSelectLoan";
            grbSelectLoan.Size = new Size(563, 249);
            grbSelectLoan.TabIndex = 25;
            grbSelectLoan.TabStop = false;
            grbSelectLoan.Text = "Select Loan";
            // 
            // grbSelectMember
            // 
            grbSelectMember.Controls.Add(grdMembers);
            grbSelectMember.Location = new Point(451, 46);
            grbSelectMember.Name = "grbSelectMember";
            grbSelectMember.Size = new Size(563, 247);
            grbSelectMember.TabIndex = 26;
            grbSelectMember.TabStop = false;
            grbSelectMember.Text = "Select Member";
            // 
            // FormReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 567);
            Controls.Add(grbSelectMember);
            Controls.Add(grbSelectLoan);
            Controls.Add(grbLoanDetails);
            Controls.Add(grpMemberName);
            Controls.Add(grpMemberID);
            Controls.Add(OPName);
            Controls.Add(OPMemID);
            Controls.Add(label4);
            Name = "FormReturnBook";
            Text = "FormReturnBook";
            Load += FormReturnBook_Load;
            ((System.ComponentModel.ISupportInitialize)grdMembers).EndInit();
            grpMemberName.ResumeLayout(false);
            grpMemberName.PerformLayout();
            grpMemberID.ResumeLayout(false);
            grpMemberID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLoans).EndInit();
            grbLoanDetails.ResumeLayout(false);
            grbLoanDetails.PerformLayout();
            grbSelectLoan.ResumeLayout(false);
            grbSelectMember.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private DataGridView grdLoans;
        private GroupBox grbLoanDetails;
        private Label LabelMemberID;
        private Label label5;
        private Label LabelLoanID;
        private Label label1;
        private Label label7;
        private Label LabelBookID;
        private Label label11;
        private Label LabelDueDate;
        private Label label9;
        private Label LabelStartDate;
        private Label label6;
        private Button ReturnLoanBt;
        private DateTimePicker DTPReturnDate;
        private GroupBox grbSelectLoan;
        private GroupBox grbSelectMember;
    }
}