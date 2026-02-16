namespace LibraraySystem
{
    partial class FormAddBook
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
            grbAddBook = new GroupBox();
            AddBookBT = new Button();
            CBgenre = new ComboBox();
            TboxBookTitle = new TextBox();
            TBoxAuthor = new TextBox();
            TBoxDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grbAddBook.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 41);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "BookID";
            // 
            // grbAddBook
            // 
            grbAddBook.Controls.Add(AddBookBT);
            grbAddBook.Controls.Add(CBgenre);
            grbAddBook.Controls.Add(TboxBookTitle);
            grbAddBook.Controls.Add(TBoxAuthor);
            grbAddBook.Controls.Add(TBoxDescription);
            grbAddBook.Controls.Add(label5);
            grbAddBook.Controls.Add(label4);
            grbAddBook.Controls.Add(label3);
            grbAddBook.Controls.Add(label2);
            grbAddBook.Location = new Point(79, 71);
            grbAddBook.Name = "grbAddBook";
            grbAddBook.Size = new Size(501, 214);
            grbAddBook.TabIndex = 1;
            grbAddBook.TabStop = false;
            grbAddBook.Text = "Enter Book Details";
            // 
            // AddBookBT
            // 
            AddBookBT.Location = new Point(94, 175);
            AddBookBT.Name = "AddBookBT";
            AddBookBT.Size = new Size(75, 23);
            AddBookBT.TabIndex = 2;
            AddBookBT.Text = "Add Book";
            AddBookBT.UseVisualStyleBackColor = true;
            AddBookBT.Click += AddBookBT_Click;
            // 
            // CBgenre
            // 
            CBgenre.FormattingEnabled = true;
            CBgenre.Location = new Point(94, 132);
            CBgenre.Name = "CBgenre";
            CBgenre.Size = new Size(210, 23);
            CBgenre.TabIndex = 9;
            // 
            // TboxBookTitle
            // 
            TboxBookTitle.Location = new Point(94, 33);
            TboxBookTitle.Name = "TboxBookTitle";
            TboxBookTitle.Size = new Size(210, 23);
            TboxBookTitle.TabIndex = 7;
            // 
            // TBoxAuthor
            // 
            TBoxAuthor.Location = new Point(94, 68);
            TBoxAuthor.Name = "TBoxAuthor";
            TBoxAuthor.Size = new Size(210, 23);
            TBoxAuthor.TabIndex = 6;
            // 
            // TBoxDescription
            // 
            TBoxDescription.Location = new Point(94, 103);
            TBoxDescription.Name = "TBoxDescription";
            TBoxDescription.Size = new Size(210, 23);
            TBoxDescription.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 106);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 71);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 36);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Book Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 140);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Genre";
            // 
            // FormAddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 346);
            Controls.Add(grbAddBook);
            Controls.Add(label1);
            Name = "FormAddBook";
            Text = "FormAddBook";
            Load += FormAddBook_Load;
            grbAddBook.ResumeLayout(false);
            grbAddBook.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox grbAddBook;
        private ComboBox CBgenre;
        private TextBox TboxBookTitle;
        private TextBox TBoxAuthor;
        private TextBox TBoxDescription;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button AddBookBT;
    }
}