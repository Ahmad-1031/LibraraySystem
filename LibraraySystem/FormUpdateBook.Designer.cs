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
            ((System.ComponentModel.ISupportInitialize)grdBooks).BeginInit();
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
            grdBooks.CellContentClick += grdBooks_CellContentClick;
            // 
            // grpBookDetails
            // 
            grpBookDetails.Location = new Point(110, 304);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Size = new Size(567, 267);
            grpBookDetails.TabIndex = 4;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Update Book Details";
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBoxSearchB;
        private Label label1;
        private Button SearchBt;
        private DataGridView grdBooks;
        private GroupBox grpBookDetails;
    }
}