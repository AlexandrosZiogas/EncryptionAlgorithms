namespace Encryption
{
    partial class frmMain
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnmd5 = new System.Windows.Forms.Button();
            this.txt1sha = new System.Windows.Forms.TextBox();
            this.txt2sha = new System.Windows.Forms.TextBox();
            this.btnSha = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.lblAES = new System.Windows.Forms.Label();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.lblSHA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(12, 49);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(192, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(291, 48);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(538, 20);
            this.txt2.TabIndex = 1;
            // 
            // btnmd5
            // 
            this.btnmd5.Location = new System.Drawing.Point(210, 46);
            this.btnmd5.Name = "btnmd5";
            this.btnmd5.Size = new System.Drawing.Size(75, 23);
            this.btnmd5.TabIndex = 2;
            this.btnmd5.Text = "Encrypt";
            this.btnmd5.UseVisualStyleBackColor = true;
            this.btnmd5.Click += new System.EventHandler(this.btnmd5_Click);
            // 
            // txt1sha
            // 
            this.txt1sha.Location = new System.Drawing.Point(13, 102);
            this.txt1sha.Name = "txt1sha";
            this.txt1sha.Size = new System.Drawing.Size(191, 20);
            this.txt1sha.TabIndex = 3;
            // 
            // txt2sha
            // 
            this.txt2sha.Location = new System.Drawing.Point(291, 102);
            this.txt2sha.Name = "txt2sha";
            this.txt2sha.Size = new System.Drawing.Size(538, 20);
            this.txt2sha.TabIndex = 4;
            // 
            // btnSha
            // 
            this.btnSha.Location = new System.Drawing.Point(210, 102);
            this.btnSha.Name = "btnSha";
            this.btnSha.Size = new System.Drawing.Size(75, 23);
            this.btnSha.TabIndex = 5;
            this.btnSha.Text = "Encrypt";
            this.btnSha.UseVisualStyleBackColor = true;
            this.btnSha.Click += new System.EventHandler(this.btnSha_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(210, 156);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(210, 191);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(13, 156);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(191, 20);
            this.txtEncrypt.TabIndex = 8;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(291, 194);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(538, 20);
            this.txtDecrypt.TabIndex = 9;
            // 
            // lblAES
            // 
            this.lblAES.AutoSize = true;
            this.lblAES.Location = new System.Drawing.Point(12, 140);
            this.lblAES.Name = "lblAES";
            this.lblAES.Size = new System.Drawing.Size(28, 13);
            this.lblAES.TabIndex = 10;
            this.lblAES.Text = "AES";
            // 
            // lblDecryptedText
            // 
            this.lblDecryptedText.AutoSize = true;
            this.lblDecryptedText.Location = new System.Drawing.Point(12, 177);
            this.lblDecryptedText.Name = "lblDecryptedText";
            this.lblDecryptedText.Size = new System.Drawing.Size(0, 13);
            this.lblDecryptedText.TabIndex = 12;
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(291, 156);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(538, 20);
            this.txtEncrypted.TabIndex = 13;
            // 
            // lblMD5
            // 
            this.lblMD5.AutoSize = true;
            this.lblMD5.Location = new System.Drawing.Point(12, 30);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(30, 13);
            this.lblMD5.TabIndex = 14;
            this.lblMD5.Text = "MD5";
            // 
            // lblSHA
            // 
            this.lblSHA.AutoSize = true;
            this.lblSHA.Location = new System.Drawing.Point(12, 86);
            this.lblSHA.Name = "lblSHA";
            this.lblSHA.Size = new System.Drawing.Size(29, 13);
            this.lblSHA.TabIndex = 15;
            this.lblSHA.Text = "SHA";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 295);
            this.Controls.Add(this.lblSHA);
            this.Controls.Add(this.lblMD5);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.lblDecryptedText);
            this.Controls.Add(this.lblAES);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSha);
            this.Controls.Add(this.txt2sha);
            this.Controls.Add(this.txt1sha);
            this.Controls.Add(this.btnmd5);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "frmMain";
            this.Text = "Encryption ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnmd5;
        private System.Windows.Forms.TextBox txt1sha;
        private System.Windows.Forms.TextBox txt2sha;
        private System.Windows.Forms.Button btnSha;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtEncrypt;
        private System.Windows.Forms.TextBox txtDecrypt;
        private System.Windows.Forms.Label lblAES;
        private System.Windows.Forms.Label lblDecryptedText;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label lblMD5;
        private System.Windows.Forms.Label lblSHA;
    }
}

