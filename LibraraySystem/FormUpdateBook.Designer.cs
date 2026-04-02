namespace LibraraySystem
{
    partial class FormUpdateBook
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
            TBoxSearchB = new TextBox();
            label1 = new Label();
            SearchBt = new Button();
            grdBooks = new DataGridView();
            grpBookDetails = new GroupBox();
            UpdateBookBT = new Button();
            CBgenre = new ComboBox();
            TboxBookTitle = new TextBox();
            TBoxAuthor = new TextBox();
            TBoxDescription = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdBooks).BeginInit();
            grpBookDetails.SuspendLayout();
            SuspendLayout();
            // 
            // TBoxSearchB
            // 
            TBoxSearchB.Location = new Point(197, 39);
            TBoxSearchB.Name = "TBoxSearchB";
            TBoxSearchB.Size = new Size(371, 23);
            TBoxSearchB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(159, 15);
            label1.TabIndex = 1;
            label1.Text = "Enter Book Name (or part of)";
            // 
            // SearchBt
            // 
            SearchBt.BackColor = Color.Green;
            SearchBt.ForeColor = SystemColors.ControlLight;
            SearchBt.Location = new Point(582, 38);
            SearchBt.Name = "SearchBt";
            SearchBt.Size = new Size(119, 24);
            SearchBt.TabIndex = 2;
            SearchBt.Text = "Search Book";
            SearchBt.UseVisualStyleBackColor = false;
            SearchBt.Click += SearchBt_Click;
            // 
            // grdBooks
            // 
            grdBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdBooks.Location = new Point(110, 104);
            grdBooks.Name = "grdBooks";
            grdBooks.Size = new Size(566, 176);
            grdBooks.TabIndex = 3;
            grdBooks.CellClick += grdBooks_CellClick;
            grdBooks.CellContentClick += grdBooks_CellContentClick;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(UpdateBookBT);
            grpBookDetails.Controls.Add(CBgenre);
            grpBookDetails.Controls.Add(TboxBookTitle);
            grpBookDetails.Controls.Add(TBoxAuthor);
            grpBookDetails.Controls.Add(TBoxDescription);
            grpBookDetails.Controls.Add(label5);
            grpBookDetails.Controls.Add(label4);
            grpBookDetails.Controls.Add(label3);
            grpBookDetails.Controls.Add(label2);
            grpBookDetails.Location = new Point(110, 304);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Size = new Size(567, 267);
            grpBookDetails.TabIndex = 4;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Update Book Details";
            // 
            // UpdateBookBT
            // 
            UpdateBookBT.Location = new Point(214, 212);
            UpdateBookBT.Name = "UpdateBookBT";
            UpdateBookBT.Size = new Size(129, 23);
            UpdateBookBT.TabIndex = 11;
            UpdateBookBT.Text = "Update Book";
            UpdateBookBT.UseVisualStyleBackColor = true;
            UpdateBookBT.Click += UpdateBookBT_Click;
            // 
            // CBgenre
            // 
            CBgenre.FormattingEnabled = true;
            CBgenre.Location = new Point(180, 172);
            CBgenre.Name = "CBgenre";
            CBgenre.Size = new Size(210, 23);
            CBgenre.TabIndex = 18;
            // 
            // TboxBookTitle
            // 
            TboxBookTitle.Location = new Point(180, 73);
            TboxBookTitle.Name = "TboxBookTitle";
            TboxBookTitle.Size = new Size(210, 23);
            TboxBookTitle.TabIndex = 17;
            // 
            // TBoxAuthor
            // 
            TBoxAuthor.Location = new Point(180, 108);
            TBoxAuthor.Name = "TBoxAuthor";
            TBoxAuthor.Size = new Size(210, 23);
            TBoxAuthor.TabIndex = 16;
            // 
            // TBoxDescription
            // 
            TBoxDescription.Location = new Point(180, 143);
            TBoxDescription.Name = "TBoxDescription";
            TBoxDescription.Size = new Size(210, 23);
            TBoxDescription.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 146);
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
            label2.Location = new Point(107, 180);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Genre";
            // 
            // FormUpdateBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 593);
            Controls.Add(grpBookDetails);
            Controls.Add(grdBooks);
            Controls.Add(SearchBt);
            Controls.Add(label1);
            Controls.Add(TBoxSearchB);
            Name = "FormUpdateBook";
            Text = "FormUpdateBook";
            Load += FormUpdateBook_Load;
            ((System.ComponentModel.ISupportInitialize)grdBooks).EndInit();
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBoxSearchB;
        private Label label1;
        private Button SearchBt;
        private DataGridView grdBooks;
        private GroupBox grpBookDetails;
        private Button UpdateBookBT;
        private ComboBox CBgenre;
        private TextBox TboxBookTitle;
        private TextBox TBoxAuthor;
        private TextBox TBoxDescription;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}