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
            label1 = new Label();
            LabelLoanID = new Label();
            label5 = new Label();
            LabelMemberID = new Label();
            label7 = new Label();
            LabelBookID = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ReturnLoanBt = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grdMembers).BeginInit();
            grpMemberName.SuspendLayout();
            grpMemberID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLoans).BeginInit();
            grbLoanDetails.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grdMembers
            // 
            grdMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMembers.Location = new Point(451, 71);
            grdMembers.Name = "grdMembers";
            grdMembers.Size = new Size(558, 209);
            grdMembers.TabIndex = 22;
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
            // 
            // grbLoanDetails
            // 
            grbLoanDetails.Controls.Add(ReturnLoanBt);
            grbLoanDetails.Controls.Add(dateTimePicker1);
            grbLoanDetails.Controls.Add(label11);
            grbLoanDetails.Controls.Add(label10);
            grbLoanDetails.Controls.Add(label9);
            grbLoanDetails.Controls.Add(label8);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 41);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Loan ID :";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 65);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 2;
            label5.Text = "Member ID : ";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 90);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 4;
            label7.Text = "Book ID :";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 114);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 6;
            label6.Text = "Start Date : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(128, 114);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 7;
            label8.Text = "No Start Date";
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
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(128, 138);
            label10.Name = "label10";
            label10.Size = new Size(74, 15);
            label10.TabIndex = 9;
            label10.Text = "No Due Date";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(128, 164);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(205, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // ReturnLoanBt
            // 
            ReturnLoanBt.Location = new Point(140, 203);
            ReturnLoanBt.Name = "ReturnLoanBt";
            ReturnLoanBt.Size = new Size(134, 22);
            ReturnLoanBt.TabIndex = 12;
            ReturnLoanBt.Text = "Return Loan";
            ReturnLoanBt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grdLoans);
            groupBox1.Location = new Point(451, 299);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 249);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Loan";
            // 
            // FormReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 567);
            Controls.Add(groupBox1);
            Controls.Add(grbLoanDetails);
            Controls.Add(grdMembers);
            Controls.Add(grpMemberName);
            Controls.Add(grpMemberID);
            Controls.Add(OPName);
            Controls.Add(OPMemID);
            Controls.Add(label4);
            Name = "FormReturnBook";
            Text = "FormReturnBook";
            ((System.ComponentModel.ISupportInitialize)grdMembers).EndInit();
            grpMemberName.ResumeLayout(false);
            grpMemberName.PerformLayout();
            grpMemberID.ResumeLayout(false);
            grpMemberID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLoans).EndInit();
            grbLoanDetails.ResumeLayout(false);
            grbLoanDetails.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Button ReturnLoanBt;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
    }
}