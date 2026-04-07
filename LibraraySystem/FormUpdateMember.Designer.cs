namespace LibraraySystem
{
    partial class FormUpdateMember
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
            OPName = new Button();
            OPMemID = new Button();
            label1 = new Label();
            grpMemberID = new GroupBox();
            SearchMemberIDBt = new Button();
            TboxMemberIDS = new TextBox();
            label2 = new Label();
            grpMemberName = new GroupBox();
            SearchNameBt = new Button();
            TboxNameS = new TextBox();
            label3 = new Label();
            grbUpdateMember = new GroupBox();
            TBoxEmail = new TextBox();
            AddMemberBt = new Button();
            TboxFirstName = new TextBox();
            TBoxSurname = new TextBox();
            TBoxPhone = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            grdMembers = new DataGridView();
            grpMemberID.SuspendLayout();
            grpMemberName.SuspendLayout();
            grbUpdateMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdMembers).BeginInit();
            SuspendLayout();
            // 
            // OPName
            // 
            OPName.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OPName.Location = new Point(334, 59);
            OPName.Name = "OPName";
            OPName.Size = new Size(93, 28);
            OPName.TabIndex = 6;
            OPName.Text = "Name";
            OPName.UseVisualStyleBackColor = true;
            OPName.Click += OPName_Click;
            // 
            // OPMemID
            // 
            OPMemID.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OPMemID.Location = new Point(235, 59);
            OPMemID.Name = "OPMemID";
            OPMemID.Size = new Size(93, 28);
            OPMemID.TabIndex = 5;
            OPMemID.Text = "Member ID";
            OPMemID.UseVisualStyleBackColor = true;
            OPMemID.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 4;
            label1.Text = "Search By:";
            // 
            // grpMemberID
            // 
            grpMemberID.Controls.Add(SearchMemberIDBt);
            grpMemberID.Controls.Add(TboxMemberIDS);
            grpMemberID.Controls.Add(label2);
            grpMemberID.Location = new Point(125, 93);
            grpMemberID.Name = "grpMemberID";
            grpMemberID.Size = new Size(431, 74);
            grpMemberID.TabIndex = 7;
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
            // grpMemberName
            // 
            grpMemberName.Controls.Add(SearchNameBt);
            grpMemberName.Controls.Add(TboxNameS);
            grpMemberName.Controls.Add(label3);
            grpMemberName.Location = new Point(125, 173);
            grpMemberName.Name = "grpMemberName";
            grpMemberName.Size = new Size(431, 74);
            grpMemberName.TabIndex = 8;
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
            // grbUpdateMember
            // 
            grbUpdateMember.Controls.Add(TBoxEmail);
            grbUpdateMember.Controls.Add(AddMemberBt);
            grbUpdateMember.Controls.Add(TboxFirstName);
            grbUpdateMember.Controls.Add(TBoxSurname);
            grbUpdateMember.Controls.Add(TBoxPhone);
            grbUpdateMember.Controls.Add(label5);
            grbUpdateMember.Controls.Add(label4);
            grbUpdateMember.Controls.Add(label6);
            grbUpdateMember.Controls.Add(label7);
            grbUpdateMember.Location = new Point(88, 455);
            grbUpdateMember.Name = "grbUpdateMember";
            grbUpdateMember.Size = new Size(501, 214);
            grbUpdateMember.TabIndex = 9;
            grbUpdateMember.TabStop = false;
            grbUpdateMember.Text = "Update Member Details";
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
            AddMemberBt.Text = "Update Member";
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
            // grdMembers
            // 
            grdMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMembers.Location = new Point(37, 253);
            grdMembers.Name = "grdMembers";
            grdMembers.Size = new Size(593, 196);
            grdMembers.TabIndex = 10;
            grdMembers.CellClick += grdMembers_CellClick;
            // 
            // FormUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 681);
            Controls.Add(grdMembers);
            Controls.Add(grbUpdateMember);
            Controls.Add(grpMemberName);
            Controls.Add(grpMemberID);
            Controls.Add(OPName);
            Controls.Add(OPMemID);
            Controls.Add(label1);
            Name = "FormUpdateMember";
            Text = "FormUpdateMember";
            Load += FormUpdateMember_Load;
            grpMemberID.ResumeLayout(false);
            grpMemberID.PerformLayout();
            grpMemberName.ResumeLayout(false);
            grpMemberName.PerformLayout();
            grbUpdateMember.ResumeLayout(false);
            grbUpdateMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OPName;
        private Button OPMemID;
        private Label label1;
        private GroupBox grpMemberID;
        private Button SearchMemberIDBt;
        private TextBox TboxMemberIDS;
        private Label label2;
        private GroupBox grpMemberName;
        private Button SearchNameBt;
        private TextBox TboxNameS;
        private Label label3;
        private GroupBox grbUpdateMember;
        private TextBox TBoxEmail;
        private Button AddMemberBt;
        private TextBox TboxFirstName;
        private TextBox TBoxSurname;
        private TextBox TBoxPhone;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private DataGridView grdMembers;
    }
}