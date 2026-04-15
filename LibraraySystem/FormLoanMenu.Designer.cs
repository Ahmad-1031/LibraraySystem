namespace LibraraySystem
{
    partial class FormLoanMenu
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
            ReturnLoanBt = new Button();
            LoanBookBT = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ReturnLoanBt
            // 
            ReturnLoanBt.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnLoanBt.Location = new Point(228, 104);
            ReturnLoanBt.Name = "ReturnLoanBt";
            ReturnLoanBt.Size = new Size(93, 28);
            ReturnLoanBt.TabIndex = 10;
            ReturnLoanBt.Text = "Return Loan";
            ReturnLoanBt.UseVisualStyleBackColor = true;
            ReturnLoanBt.Click += ReturnLoanBt_Click;
            // 
            // LoanBookBT
            // 
            LoanBookBT.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoanBookBT.Location = new Point(129, 104);
            LoanBookBT.Name = "LoanBookBT";
            LoanBookBT.Size = new Size(93, 28);
            LoanBookBT.TabIndex = 9;
            LoanBookBT.Text = "Loan Book";
            LoanBookBT.UseVisualStyleBackColor = true;
            LoanBookBT.Click += LoanBookBT_Click;
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
            // FormLoanMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 185);
            Controls.Add(ReturnLoanBt);
            Controls.Add(LoanBookBT);
            Controls.Add(label1);
            Name = "FormLoanMenu";
            Text = "Loans Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnLoanBt;
        private Button LoanBookBT;
        private Label label1;
    }
}