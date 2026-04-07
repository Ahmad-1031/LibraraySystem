namespace LibraraySystem
{
    partial class FormRemoveMember
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
            grbMemberDetails = new GroupBox();
            LabelEmail = new Label();
            LabelPhone = new Label();
            LabelSurname = new Label();
            LabelFirstName = new Label();
            RemoveMemberBt = new Button();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdMembers).BeginInit();
            grbMemberDetails.SuspendLayout();
            grpMemberName.SuspendLayout();
            grpMemberID.SuspendLayout();
            SuspendLayout();
            // 
            // grdMembers
            // 
            grdMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMembers.Location = new Point(37, 254);
            grdMembers.Name = "grdMembers";
            grdMembers.Size = new Size(593, 196);
            grdMembers.TabIndex = 17;
            grdMembers.CellClick += grdMembers_CellClick;
            // 
            // grbMemberDetails
            // 
            grbMemberDetails.Controls.Add(LabelEmail);
            grbMemberDetails.Controls.Add(LabelPhone);
            grbMemberDetails.Controls.Add(LabelSurname);
            grbMemberDetails.Controls.Add(LabelFirstName);
            grbMemberDetails.Controls.Add(RemoveMemberBt);
            grbMemberDetails.Controls.Add(label5);
            grbMemberDetails.Controls.Add(label4);
            grbMemberDetails.Controls.Add(label6);
            grbMemberDetails.Controls.Add(label7);
            grbMemberDetails.Location = new Point(88, 456);
            grbMemberDetails.Name = "grbMemberDetails";
            grbMemberDetails.Size = new Size(501, 214);
            grbMemberDetails.TabIndex = 16;
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
            // RemoveMemberBt
            // 
            RemoveMemberBt.Location = new Point(129, 176);
            RemoveMemberBt.Name = "RemoveMemberBt";
            RemoveMemberBt.Size = new Size(112, 23);
            RemoveMemberBt.TabIndex = 2;
            RemoveMemberBt.Text = "Remove Member";
            RemoveMemberBt.UseVisualStyleBackColor = true;
            RemoveMemberBt.Click += RemoveMemberBt_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 36);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 2;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 140);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 1;
            label7.Text = "Email";
            // 
            // grpMemberName
            // 
            grpMemberName.Controls.Add(SearchNameBt);
            grpMemberName.Controls.Add(TboxNameS);
            grpMemberName.Controls.Add(label3);
            grpMemberName.Location = new Point(125, 174);
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
            grpMemberID.Location = new Point(125, 94);
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
            OPName.Location = new Point(334, 60);
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
            OPMemID.Location = new Point(235, 60);
            OPMemID.Name = "OPMemID";
            OPMemID.Size = new Size(93, 28);
            OPMemID.TabIndex = 12;
            OPMemID.Text = "Member ID";
            OPMemID.UseVisualStyleBackColor = true;
            OPMemID.Click += OPMemID_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 10);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 11;
            label1.Text = "Search By:";
            // 
            // FormRemoveMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 681);
            Controls.Add(grdMembers);
            Controls.Add(grbMemberDetails);
            Controls.Add(grpMemberName);
            Controls.Add(grpMemberID);
            Controls.Add(OPName);
            Controls.Add(OPMemID);
            Controls.Add(label1);
            Name = "FormRemoveMember";
            Text = "Remove Member";
            Load += FormRemoveMember_Load;
            ((System.ComponentModel.ISupportInitialize)grdMembers).EndInit();
            grbMemberDetails.ResumeLayout(false);
            grbMemberDetails.PerformLayout();
            grpMemberName.ResumeLayout(false);
            grpMemberName.PerformLayout();
            grpMemberID.ResumeLayout(false);
            grpMemberID.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdMembers;
        private GroupBox grbMemberDetails;
        private Label LabelSurname;
        private Label LabelFirstName;
        private Button RemoveMemberBt;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
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
        private Label label1;
        private Label LabelEmail;
        private Label LabelPhone;
    }
}