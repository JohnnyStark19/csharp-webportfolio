namespace HOTS6_1
{
    partial class Form1
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
            this.lblMD5Hash = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCrack = new System.Windows.Forms.Button();
            this.lstPassword = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMD5Hash
            // 
            this.lblMD5Hash.AutoSize = true;
            this.lblMD5Hash.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMD5Hash.Location = new System.Drawing.Point(62, 25);
            this.lblMD5Hash.Name = "lblMD5Hash";
            this.lblMD5Hash.Size = new System.Drawing.Size(156, 34);
            this.lblMD5Hash.TabIndex = 3;
            this.lblMD5Hash.Text = "MD5 Hash";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(68, 88);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(447, 29);
            this.txtInput.TabIndex = 0;
            // 
            // btnCrack
            // 
            this.btnCrack.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrack.Location = new System.Drawing.Point(575, 81);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(131, 43);
            this.btnCrack.TabIndex = 1;
            this.btnCrack.Text = "Crack";
            this.btnCrack.UseVisualStyleBackColor = true;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // lstPassword
            // 
            this.lstPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPassword.FormattingEnabled = true;
            this.lstPassword.ItemHeight = 22;
            this.lstPassword.Location = new System.Drawing.Point(68, 157);
            this.lstPassword.Name = "lstPassword";
            this.lstPassword.Size = new System.Drawing.Size(571, 224);
            this.lstPassword.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCrack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPassword);
            this.Controls.Add(this.btnCrack);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblMD5Hash);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Cracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMD5Hash;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.ListBox lstPassword;
    }
}

