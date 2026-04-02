namespace LibraraySystem
{
    partial class FormRemoveBook
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
            SearchBt = new Button();
            label1 = new Label();
            TBoxSearchB = new TextBox();
            grdBooks = new DataGridView();
            grpBookDetails = new GroupBox();
            RemoveBookBt = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            LabelBookTitle = new Label();
            LabelAuthor = new Label();
            LabelGenre = new Label();
            TboxDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdBooks).BeginInit();
            grpBookDetails.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBt
            // 
            SearchBt.BackColor = Color.Green;
            SearchBt.ForeColor = SystemColors.ControlLight;
            SearchBt.Location = new Point(598, 42);
            SearchBt.Name = "SearchBt";
            SearchBt.Size = new Size(119, 24);
            SearchBt.TabIndex = 5;
            SearchBt.Text = "Search Book";
            SearchBt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 4;
            label1.Text = "Enter Book Name (or part of)";
            // 
            // TBoxSearchB
            // 
            TBoxSearchB.Location = new Point(213, 43);
            TBoxSearchB.Name = "TBoxSearchB";
            TBoxSearchB.Size = new Size(371, 23);
            TBoxSearchB.TabIndex = 3;
            // 
            // grdBooks
            // 
            grdBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBooks.Location = new Point(61, 95);
            grdBooks.Name = "grdBooks";
            grdBooks.Size = new Size(645, 176);
            grdBooks.TabIndex = 6;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(TboxDescription);
            grpBookDetails.Controls.Add(LabelGenre);
            grpBookDetails.Controls.Add(LabelAuthor);
            grpBookDetails.Controls.Add(LabelBookTitle);
            grpBookDetails.Controls.Add(RemoveBookBt);
            grpBookDetails.Controls.Add(label5);
            grpBookDetails.Controls.Add(label4);
            grpBookDetails.Controls.Add(label3);
            grpBookDetails.Controls.Add(label2);
            grpBookDetails.Location = new Point(111, 299);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Size = new Size(567, 342);
            grpBookDetails.TabIndex = 7;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Update Book Details";
            // 
            // RemoveBookBt
            // 
            RemoveBookBt.Location = new Point(206, 296);
            RemoveBookBt.Name = "RemoveBookBt";
            RemoveBookBt.Size = new Size(129, 23);
            RemoveBookBt.TabIndex = 11;
            RemoveBookBt.Text = "Remove Book";
            RemoveBookBt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 176);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 14;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 111);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 13;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 76);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 12;
            label3.Text = "Book Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 146);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Genre";
            // 
            // LabelBookTitle
            // 
            LabelBookTitle.AutoSize = true;
            LabelBookTitle.Location = new Point(225, 76);
            LabelBookTitle.Name = "LabelBookTitle";
            LabelBookTitle.Size = new Size(38, 15);
            LabelBookTitle.TabIndex = 15;
            LabelBookTitle.Text = "label6";
            // 
            // LabelAuthor
            // 
            LabelAuthor.AutoSize = true;
            LabelAuthor.Location = new Point(225, 111);
            LabelAuthor.Name = "LabelAuthor";
            LabelAuthor.Size = new Size(38, 15);
            LabelAuthor.TabIndex = 16;
            LabelAuthor.Text = "label7";
            // 
            // LabelGenre
            // 
            LabelGenre.AutoSize = true;
            LabelGenre.Location = new Point(225, 146);
            LabelGenre.Name = "LabelGenre";
            LabelGenre.Size = new Size(38, 15);
            LabelGenre.TabIndex = 17;
            LabelGenre.Text = "label8";
            // 
            // TboxDescription
            // 
            TboxDescription.Location = new Point(180, 176);
            TboxDescription.Multiline = true;
            TboxDescription.Name = "TboxDescription";
            TboxDescription.ReadOnly = true;
            TboxDescription.ScrollBars = ScrollBars.Vertical;
            TboxDescription.Size = new Size(293, 98);
            TboxDescription.TabIndex = 18;
            // 
            // FormRemoveBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 653);
            Controls.Add(grpBookDetails);
            Controls.Add(grdBooks);
            Controls.Add(SearchBt);
            Controls.Add(label1);
            Controls.Add(TBoxSearchB);
            Name = "FormRemoveBook";
            Text = "FormRemoveBook";
            ((System.ComponentModel.ISupportInitialize)grdBooks).EndInit();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBt;
        private Label label1;
        private TextBox TBoxSearchB;
        private DataGridView grdBooks;
        private GroupBox grpBookDetails;
        private Label LabelGenre;
        private Label LabelAuthor;
        private Label LabelBookTitle;
        private Button RemoveBookBt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TboxDescription;
    }
}