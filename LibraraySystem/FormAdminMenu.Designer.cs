namespace LibraraySystem
{
    partial class FormAdminMenu
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
            MonthlyFinesBt = new Button();
            PopularGenresBt = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // MonthlyFinesBt
            // 
            MonthlyFinesBt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MonthlyFinesBt.Location = new Point(223, 103);
            MonthlyFinesBt.Name = "MonthlyFinesBt";
            MonthlyFinesBt.Size = new Size(93, 28);
            MonthlyFinesBt.TabIndex = 10;
            MonthlyFinesBt.Text = "Monthly Fines";
            MonthlyFinesBt.UseVisualStyleBackColor = true;
            // 
            // PopularGenresBt
            // 
            PopularGenresBt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PopularGenresBt.Location = new Point(124, 103);
            PopularGenresBt.Name = "PopularGenresBt";
            PopularGenresBt.Size = new Size(93, 28);
            PopularGenresBt.TabIndex = 9;
            PopularGenresBt.Text = "Popular Genres";
            PopularGenresBt.UseVisualStyleBackColor = true;
            PopularGenresBt.Click += PopularGenresBt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 54);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 8;
            label1.Text = "Pick An Option";
            // 
            // FormAdminMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 185);
            Controls.Add(MonthlyFinesBt);
            Controls.Add(PopularGenresBt);
            Controls.Add(label1);
            Name = "FormAdminMenu";
            Text = "Admin Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MonthlyFinesBt;
        private Button PopularGenresBt;
        private Label label1;
    }
}