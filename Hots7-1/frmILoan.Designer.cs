namespace Hots7_1
{
    partial class frmILoan
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
            this.gnCreateloan = new System.Windows.Forms.GroupBox();
            this.btnCreateLoan = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.rbShortTerm = new System.Windows.Forms.RadioButton();
            this.rbLongTerm = new System.Windows.Forms.RadioButton();
            this.gbManageLoan = new System.Windows.Forms.GroupBox();
            this.lblNameOutput = new System.Windows.Forms.Label();
            this.lblTypeAndAmount = new System.Windows.Forms.Label();
            this.lblPaymentOutput = new System.Windows.Forms.Label();
            this.lblInterestOutput = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.gnCreateloan.SuspendLayout();
            this.gbManageLoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnCreateloan
            // 
            this.gnCreateloan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gnCreateloan.Controls.Add(this.rbLongTerm);
            this.gnCreateloan.Controls.Add(this.rbShortTerm);
            this.gnCreateloan.Controls.Add(this.txtAmount);
            this.gnCreateloan.Controls.Add(this.txtName);
            this.gnCreateloan.Controls.Add(this.lblType);
            this.gnCreateloan.Controls.Add(this.Amount);
            this.gnCreateloan.Controls.Add(this.lblName);
            this.gnCreateloan.Controls.Add(this.btnCreateLoan);
            this.gnCreateloan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gnCreateloan.Location = new System.Drawing.Point(55, 31);
            this.gnCreateloan.Name = "gnCreateloan";
            this.gnCreateloan.Size = new System.Drawing.Size(868, 209);
            this.gnCreateloan.TabIndex = 0;
            this.gnCreateloan.TabStop = false;
            this.gnCreateloan.Text = "Create Loan";
            // 
            // btnCreateLoan
            // 
            this.btnCreateLoan.Location = new System.Drawing.Point(30, 157);
            this.btnCreateLoan.Name = "btnCreateLoan";
            this.btnCreateLoan.Size = new System.Drawing.Size(114, 39);
            this.btnCreateLoan.TabIndex = 4;
            this.btnCreateLoan.Text = "Create Loan";
            this.btnCreateLoan.UseVisualStyleBackColor = true;
            this.btnCreateLoan.Click += new System.EventHandler(this.btnCreateLoan_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 19);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(63, 78);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(69, 19);
            this.Amount.TabIndex = 6;
            this.Amount.Text = "Amount";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(64, 120);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(46, 19);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Type";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(182, 78);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(272, 26);
            this.txtAmount.TabIndex = 1;
            // 
            // rbShortTerm
            // 
            this.rbShortTerm.AutoSize = true;
            this.rbShortTerm.Location = new System.Drawing.Point(214, 120);
            this.rbShortTerm.Name = "rbShortTerm";
            this.rbShortTerm.Size = new System.Drawing.Size(155, 23);
            this.rbShortTerm.TabIndex = 2;
            this.rbShortTerm.TabStop = true;
            this.rbShortTerm.Text = "Short-Term Loan";
            this.rbShortTerm.UseVisualStyleBackColor = true;
            // 
            // rbLongTerm
            // 
            this.rbLongTerm.AutoSize = true;
            this.rbLongTerm.Location = new System.Drawing.Point(214, 159);
            this.rbLongTerm.Name = "rbLongTerm";
            this.rbLongTerm.Size = new System.Drawing.Size(153, 23);
            this.rbLongTerm.TabIndex = 3;
            this.rbLongTerm.TabStop = true;
            this.rbLongTerm.Text = "Long-Term Loan";
            this.rbLongTerm.UseVisualStyleBackColor = true;
            // 
            // gbManageLoan
            // 
            this.gbManageLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gbManageLoan.Controls.Add(this.btnMakePayment);
            this.gbManageLoan.Controls.Add(this.lblInterestOutput);
            this.gbManageLoan.Controls.Add(this.lblPaymentOutput);
            this.gbManageLoan.Controls.Add(this.lblTypeAndAmount);
            this.gbManageLoan.Controls.Add(this.lblNameOutput);
            this.gbManageLoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageLoan.Location = new System.Drawing.Point(55, 264);
            this.gbManageLoan.Name = "gbManageLoan";
            this.gbManageLoan.Size = new System.Drawing.Size(868, 334);
            this.gbManageLoan.TabIndex = 1;
            this.gbManageLoan.TabStop = false;
            this.gbManageLoan.Text = "Manage Loan";
            // 
            // lblNameOutput
            // 
            this.lblNameOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNameOutput.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOutput.Location = new System.Drawing.Point(32, 22);
            this.lblNameOutput.Name = "lblNameOutput";
            this.lblNameOutput.Size = new System.Drawing.Size(295, 34);
            this.lblNameOutput.TabIndex = 0;
            this.lblNameOutput.Click += new System.EventHandler(this.lblNameOutput_Click);
            // 
            // lblTypeAndAmount
            // 
            this.lblTypeAndAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTypeAndAmount.Location = new System.Drawing.Point(32, 74);
            this.lblTypeAndAmount.Name = "lblTypeAndAmount";
            this.lblTypeAndAmount.Size = new System.Drawing.Size(295, 41);
            this.lblTypeAndAmount.TabIndex = 1;
            this.lblTypeAndAmount.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblPaymentOutput
            // 
            this.lblPaymentOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPaymentOutput.Location = new System.Drawing.Point(32, 173);
            this.lblPaymentOutput.Name = "lblPaymentOutput";
            this.lblPaymentOutput.Size = new System.Drawing.Size(379, 38);
            this.lblPaymentOutput.TabIndex = 3;
            // 
            // lblInterestOutput
            // 
            this.lblInterestOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblInterestOutput.Location = new System.Drawing.Point(32, 238);
            this.lblInterestOutput.Name = "lblInterestOutput";
            this.lblInterestOutput.Size = new System.Drawing.Size(379, 38);
            this.lblInterestOutput.TabIndex = 4;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(35, 129);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(141, 28);
            this.btnMakePayment.TabIndex = 2;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // frmILoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(973, 629);
            this.Controls.Add(this.gbManageLoan);
            this.Controls.Add(this.gnCreateloan);
            this.Name = "frmILoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Loan";
            this.gnCreateloan.ResumeLayout(false);
            this.gnCreateloan.PerformLayout();
            this.gbManageLoan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gnCreateloan;
        private System.Windows.Forms.RadioButton rbLongTerm;
        private System.Windows.Forms.RadioButton rbShortTerm;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCreateLoan;
        private System.Windows.Forms.GroupBox gbManageLoan;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblInterestOutput;
        private System.Windows.Forms.Label lblPaymentOutput;
        private System.Windows.Forms.Label lblTypeAndAmount;
        private System.Windows.Forms.Label lblNameOutput;
    }
}

