namespace LibraraySystem
{
    partial class FormMemberMenu
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
            FormRemoveBook = new Button();
            FormUpdateBook = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // FormRemoveBook
            // 
            FormRemoveBook.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormRemoveBook.Location = new Point(279, 103);
            FormRemoveBook.Name = "FormRemoveBook";
            FormRemoveBook.Size = new Size(98, 28);
            FormRemoveBook.TabIndex = 7;
            FormRemoveBook.Text = "Remove Member";
            FormRemoveBook.UseVisualStyleBackColor = true;
            FormRemoveBook.Click += FormRemoveBook_Click;
            // 
            // FormUpdateBook
            // 
            FormUpdateBook.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormUpdateBook.Location = new Point(180, 103);
            FormUpdateBook.Name = "FormUpdateBook";
            FormUpdateBook.Size = new Size(93, 28);
            FormUpdateBook.TabIndex = 6;
            FormUpdateBook.Text = "Update Member";
            FormUpdateBook.UseVisualStyleBackColor = true;
            FormUpdateBook.Click += FormUpdateBook_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(81, 103);
            button1.Name = "button1";
            button1.Size = new Size(93, 28);
            button1.TabIndex = 5;
            button1.Text = "Add Member";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 54);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 4;
            label1.Text = "Pick An Option";
            // 
            // FormMemberMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 185);
            Controls.Add(FormRemoveBook);
            Controls.Add(FormUpdateBook);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormMemberMenu";
            Text = "Member Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FormRemoveBook;
        private Button FormUpdateBook;
        private Button button1;
        private Label label1;
    }
}