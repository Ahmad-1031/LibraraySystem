namespace LibraraySystem
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelCardAdmin = new Panel();
            label4 = new Label();
            panelCardLoans = new Panel();
            label3 = new Label();
            panelCardMembers = new Panel();
            label2 = new Label();
            panelCardBooks = new Panel();
            label1 = new Label();
            label5 = new Label();
            panelDashboard = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panelCardAdmin.SuspendLayout();
            panelCardLoans.SuspendLayout();
            panelCardMembers.SuspendLayout();
            panelCardBooks.SuspendLayout();
            panelDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(162, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 171);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelCardAdmin, 1, 1);
            tableLayoutPanel1.Controls.Add(panelCardLoans, 0, 1);
            tableLayoutPanel1.Controls.Add(panelCardMembers, 1, 0);
            tableLayoutPanel1.Controls.Add(panelCardBooks, 0, 0);
            tableLayoutPanel1.Location = new Point(185, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(436, 140);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panelCardAdmin
            // 
            panelCardAdmin.Anchor = AnchorStyles.None;
            panelCardAdmin.BackColor = Color.Silver;
            panelCardAdmin.Controls.Add(label4);
            panelCardAdmin.ForeColor = Color.Transparent;
            panelCardAdmin.Location = new Point(235, 82);
            panelCardAdmin.Name = "panelCardAdmin";
            panelCardAdmin.Size = new Size(183, 46);
            panelCardAdmin.TabIndex = 3;
            panelCardAdmin.MouseClick += panelCardAdmin_MouseClick;
            panelCardAdmin.MouseLeave += panelCardAdmin_MouseLeave;
            panelCardAdmin.MouseHover += panelCardAdmin_MouseHover;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 9);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 0;
            label4.Text = "Admin";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCardLoans
            // 
            panelCardLoans.Anchor = AnchorStyles.None;
            panelCardLoans.BackColor = Color.Silver;
            panelCardLoans.Controls.Add(label3);
            panelCardLoans.ForeColor = Color.Transparent;
            panelCardLoans.Location = new Point(17, 82);
            panelCardLoans.Name = "panelCardLoans";
            panelCardLoans.Size = new Size(184, 46);
            panelCardLoans.TabIndex = 2;
            panelCardLoans.MouseClick += panelCardLoans_MouseClick;
            panelCardLoans.MouseLeave += panelCardLoans_MouseLeave;
            panelCardLoans.MouseHover += panelCardLoans_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 9);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 0;
            label3.Text = "Manage Loans";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCardMembers
            // 
            panelCardMembers.Anchor = AnchorStyles.None;
            panelCardMembers.BackColor = Color.Silver;
            panelCardMembers.Controls.Add(label2);
            panelCardMembers.ForeColor = Color.Transparent;
            panelCardMembers.Location = new Point(229, 12);
            panelCardMembers.Name = "panelCardMembers";
            panelCardMembers.Size = new Size(195, 46);
            panelCardMembers.TabIndex = 1;
            panelCardMembers.MouseClick += panelCardMembers_MouseClick;
            panelCardMembers.MouseLeave += panelCardMembers_MouseLeave;
            panelCardMembers.MouseHover += panelCardMembers_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 1;
            label2.Text = "Manage Members";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCardBooks
            // 
            panelCardBooks.Anchor = AnchorStyles.None;
            panelCardBooks.BackColor = Color.Silver;
            panelCardBooks.Controls.Add(label1);
            panelCardBooks.ForeColor = Color.Transparent;
            panelCardBooks.Location = new Point(15, 12);
            panelCardBooks.Name = "panelCardBooks";
            panelCardBooks.Size = new Size(188, 46);
            panelCardBooks.TabIndex = 0;
            panelCardBooks.MouseClick += panelCardBooks_MouseClick;
            panelCardBooks.MouseLeave += panelCardBooks_MouseLeave;
            panelCardBooks.MouseHover += panelCardBooks_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 17);
            label5.Name = "label5";
            label5.Size = new Size(278, 45);
            label5.TabIndex = 1;
            label5.Text = "Library Dashboard";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDashboard
            // 
            panelDashboard.Anchor = AnchorStyles.None;
            panelDashboard.BackColor = Color.Silver;
            panelDashboard.Controls.Add(label5);
            panelDashboard.ForeColor = Color.Transparent;
            panelDashboard.Location = new Point(244, 78);
            panelDashboard.Name = "panelDashboard";
            panelDashboard.Size = new Size(309, 80);
            panelDashboard.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelDashboard);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelCardAdmin.ResumeLayout(false);
            panelCardAdmin.PerformLayout();
            panelCardLoans.ResumeLayout(false);
            panelCardLoans.PerformLayout();
            panelCardMembers.ResumeLayout(false);
            panelCardMembers.PerformLayout();
            panelCardBooks.ResumeLayout(false);
            panelCardBooks.PerformLayout();
            panelDashboard.ResumeLayout(false);
            panelDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelCardBooks;
        private Label label1;
        private Panel panelCardMembers;
        private Label label2;
        private Panel panelCardAdmin;
        private Label label4;
        private Panel panelCardLoans;
        private Label label3;
        private Label label5;
        private Panel panelDashboard;
    }
}
