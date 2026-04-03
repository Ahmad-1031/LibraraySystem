namespace LibraraySystem
{
    partial class BookMenu
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
            label1 = new Label();
            button1 = new Button();
            FormUpdateBook = new Button();
            FormRemoveBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 60);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 0;
            label1.Text = "Pick An Option";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(74, 109);
            button1.Name = "button1";
            button1.Size = new Size(93, 28);
            button1.TabIndex = 1;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormUpdateBook
            // 
            FormUpdateBook.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormUpdateBook.Location = new Point(173, 109);
            FormUpdateBook.Name = "FormUpdateBook";
            FormUpdateBook.Size = new Size(93, 28);
            FormUpdateBook.TabIndex = 2;
            FormUpdateBook.Text = "Update Book";
            FormUpdateBook.UseVisualStyleBackColor = true;
            FormUpdateBook.Click += FormUpdateBook_Click;
            // 
            // FormRemoveBook
            // 
            FormRemoveBook.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormRemoveBook.Location = new Point(272, 109);
            FormRemoveBook.Name = "FormRemoveBook";
            FormRemoveBook.Size = new Size(93, 28);
            FormRemoveBook.TabIndex = 3;
            FormRemoveBook.Text = "Remove Book";
            FormRemoveBook.UseVisualStyleBackColor = true;
            FormRemoveBook.Click += FormRemoveBook_Click;
            // 
            // BookMenu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 185);
            Controls.Add(FormRemoveBook);
            Controls.Add(FormUpdateBook);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "BookMenu";
            Text = "Book Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button FormUpdateBook;
        private Button FormRemoveBook;
    }
}