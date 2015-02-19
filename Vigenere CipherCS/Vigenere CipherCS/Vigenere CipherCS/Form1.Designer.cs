namespace Vigenere_CipherCS
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
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.PassPhrzTextBox = new System.Windows.Forms.TextBox();
            this.PassPhraseLabel = new System.Windows.Forms.Label();
            this.PlainTxtLabel = new System.Windows.Forms.Label();
            this.PlainTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.VignereEncryptedTxtLabel = new System.Windows.Forms.Label();
            this.VignereDecryptedTxtLbl = new System.Windows.Forms.Label();
            this.DecryptedTextBox = new System.Windows.Forms.TextBox();
            this.CopyRightLbl = new System.Windows.Forms.Label();
            this.DoubleTRB = new System.Windows.Forms.RadioButton();
            this.VingnereRB = new System.Windows.Forms.RadioButton();
            this.DTCColumnOrderLabel = new System.Windows.Forms.Label();
            this.DTCEncryptedLabel = new System.Windows.Forms.Label();
            this.ColumnPermuationTextBox = new System.Windows.Forms.TextBox();
            this.TranspositionEncryptedTextBox = new System.Windows.Forms.TextBox();
            this.DTCDecryptedTxtLabel = new System.Windows.Forms.Label();
            this.TranspositionDecryptedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Location = new System.Drawing.Point(369, 48);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptBtn.TabIndex = 0;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.Location = new System.Drawing.Point(369, 103);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(75, 23);
            this.DecryptBtn.TabIndex = 1;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = true;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // PassPhrzTextBox
            // 
            this.PassPhrzTextBox.Location = new System.Drawing.Point(145, 55);
            this.PassPhrzTextBox.Name = "PassPhrzTextBox";
            this.PassPhrzTextBox.Size = new System.Drawing.Size(194, 20);
            this.PassPhrzTextBox.TabIndex = 3;
            this.PassPhrzTextBox.TextChanged += new System.EventHandler(this.PassPhrzTextBox_TextChanged);
            // 
            // PassPhraseLabel
            // 
            this.PassPhraseLabel.AutoSize = true;
            this.PassPhraseLabel.Location = new System.Drawing.Point(57, 58);
            this.PassPhraseLabel.Name = "PassPhraseLabel";
            this.PassPhraseLabel.Size = new System.Drawing.Size(69, 13);
            this.PassPhraseLabel.TabIndex = 4;
            this.PassPhraseLabel.Text = "Pass Phrase:";
            // 
            // PlainTxtLabel
            // 
            this.PlainTxtLabel.AutoSize = true;
            this.PlainTxtLabel.Location = new System.Drawing.Point(57, 103);
            this.PlainTxtLabel.Name = "PlainTxtLabel";
            this.PlainTxtLabel.Size = new System.Drawing.Size(57, 13);
            this.PlainTxtLabel.TabIndex = 5;
            this.PlainTxtLabel.Text = "Plain Text:";
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Location = new System.Drawing.Point(145, 100);
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.Size = new System.Drawing.Size(194, 20);
            this.PlainTextBox.TabIndex = 6;
            this.PlainTextBox.TextChanged += new System.EventHandler(this.PlainTextBox_TextChanged);
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Enabled = false;
            this.EncryptedTextBox.Location = new System.Drawing.Point(145, 144);
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(194, 20);
            this.EncryptedTextBox.TabIndex = 7;
            this.EncryptedTextBox.TextChanged += new System.EventHandler(this.EncryptedTextBox_TextChanged);
            // 
            // VignereEncryptedTxtLabel
            // 
            this.VignereEncryptedTxtLabel.AutoSize = true;
            this.VignereEncryptedTxtLabel.Location = new System.Drawing.Point(57, 144);
            this.VignereEncryptedTxtLabel.Name = "VignereEncryptedTxtLabel";
            this.VignereEncryptedTxtLabel.Size = new System.Drawing.Size(82, 13);
            this.VignereEncryptedTxtLabel.TabIndex = 8;
            this.VignereEncryptedTxtLabel.Text = "Encrypted Text:";
            // 
            // VignereDecryptedTxtLbl
            // 
            this.VignereDecryptedTxtLbl.AutoSize = true;
            this.VignereDecryptedTxtLbl.Location = new System.Drawing.Point(57, 193);
            this.VignereDecryptedTxtLbl.Name = "VignereDecryptedTxtLbl";
            this.VignereDecryptedTxtLbl.Size = new System.Drawing.Size(83, 13);
            this.VignereDecryptedTxtLbl.TabIndex = 10;
            this.VignereDecryptedTxtLbl.Text = "Decrypted Text:";
            // 
            // DecryptedTextBox
            // 
            this.DecryptedTextBox.Enabled = false;
            this.DecryptedTextBox.Location = new System.Drawing.Point(145, 193);
            this.DecryptedTextBox.Name = "DecryptedTextBox";
            this.DecryptedTextBox.Size = new System.Drawing.Size(194, 20);
            this.DecryptedTextBox.TabIndex = 11;
            // 
            // CopyRightLbl
            // 
            this.CopyRightLbl.AutoSize = true;
            this.CopyRightLbl.Location = new System.Drawing.Point(12, 415);
            this.CopyRightLbl.Name = "CopyRightLbl";
            this.CopyRightLbl.Size = new System.Drawing.Size(203, 13);
            this.CopyRightLbl.TabIndex = 12;
            this.CopyRightLbl.Text = "Cipher-DeCipher by: Kquane Ingram 2013";
            // 
            // DoubleTRB
            // 
            this.DoubleTRB.AutoSize = true;
            this.DoubleTRB.Location = new System.Drawing.Point(181, 7);
            this.DoubleTRB.Name = "DoubleTRB";
            this.DoubleTRB.Size = new System.Drawing.Size(158, 17);
            this.DoubleTRB.TabIndex = 14;
            this.DoubleTRB.Text = "Double Transposition Cipher";
            this.DoubleTRB.UseVisualStyleBackColor = true;
            this.DoubleTRB.CheckedChanged += new System.EventHandler(this.DoubleTRB_CheckedChanged);
            // 
            // VingnereRB
            // 
            this.VingnereRB.AutoSize = true;
            this.VingnereRB.Checked = true;
            this.VingnereRB.Location = new System.Drawing.Point(46, 7);
            this.VingnereRB.Name = "VingnereRB";
            this.VingnereRB.Size = new System.Drawing.Size(94, 17);
            this.VingnereRB.TabIndex = 15;
            this.VingnereRB.TabStop = true;
            this.VingnereRB.Text = "Vignere Cipher";
            this.VingnereRB.UseVisualStyleBackColor = true;
            this.VingnereRB.CheckedChanged += new System.EventHandler(this.VingnereRB_CheckedChanged);
            // 
            // DTCColumnOrderLabel
            // 
            this.DTCColumnOrderLabel.AutoSize = true;
            this.DTCColumnOrderLabel.Location = new System.Drawing.Point(57, 239);
            this.DTCColumnOrderLabel.Name = "DTCColumnOrderLabel";
            this.DTCColumnOrderLabel.Size = new System.Drawing.Size(133, 13);
            this.DTCColumnOrderLabel.TabIndex = 16;
            this.DTCColumnOrderLabel.Text = "Column Permutation Order:";
            this.DTCColumnOrderLabel.Visible = false;
            // 
            // DTCEncryptedLabel
            // 
            this.DTCEncryptedLabel.AutoSize = true;
            this.DTCEncryptedLabel.Location = new System.Drawing.Point(60, 280);
            this.DTCEncryptedLabel.Name = "DTCEncryptedLabel";
            this.DTCEncryptedLabel.Size = new System.Drawing.Size(82, 13);
            this.DTCEncryptedLabel.TabIndex = 17;
            this.DTCEncryptedLabel.Text = "Encrypted Text:";
            this.DTCEncryptedLabel.Visible = false;
            // 
            // ColumnPermuationTextBox
            // 
            this.ColumnPermuationTextBox.Location = new System.Drawing.Point(196, 236);
            this.ColumnPermuationTextBox.Name = "ColumnPermuationTextBox";
            this.ColumnPermuationTextBox.Size = new System.Drawing.Size(194, 20);
            this.ColumnPermuationTextBox.TabIndex = 18;
            this.ColumnPermuationTextBox.Visible = false;
            this.ColumnPermuationTextBox.TextChanged += new System.EventHandler(this.CPOTextBox_TextChanged);
            // 
            // TranspositionEncryptedTextBox
            // 
            this.TranspositionEncryptedTextBox.Enabled = false;
            this.TranspositionEncryptedTextBox.Location = new System.Drawing.Point(145, 277);
            this.TranspositionEncryptedTextBox.Name = "TranspositionEncryptedTextBox";
            this.TranspositionEncryptedTextBox.Size = new System.Drawing.Size(194, 20);
            this.TranspositionEncryptedTextBox.TabIndex = 19;
            this.TranspositionEncryptedTextBox.Visible = false;
            this.TranspositionEncryptedTextBox.TextChanged += new System.EventHandler(this.TranspositionEncryptedTextBox_TextChanged);
            // 
            // DTCDecryptedTxtLabel
            // 
            this.DTCDecryptedTxtLabel.AutoSize = true;
            this.DTCDecryptedTxtLabel.Location = new System.Drawing.Point(57, 320);
            this.DTCDecryptedTxtLabel.Name = "DTCDecryptedTxtLabel";
            this.DTCDecryptedTxtLabel.Size = new System.Drawing.Size(83, 13);
            this.DTCDecryptedTxtLabel.TabIndex = 20;
            this.DTCDecryptedTxtLabel.Text = "Decrypted Text:";
            this.DTCDecryptedTxtLabel.Visible = false;
            // 
            // TranspositionDecryptedTextBox
            // 
            this.TranspositionDecryptedTextBox.Enabled = false;
            this.TranspositionDecryptedTextBox.Location = new System.Drawing.Point(145, 320);
            this.TranspositionDecryptedTextBox.Name = "TranspositionDecryptedTextBox";
            this.TranspositionDecryptedTextBox.Size = new System.Drawing.Size(194, 20);
            this.TranspositionDecryptedTextBox.TabIndex = 21;
            this.TranspositionDecryptedTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 437);
            this.Controls.Add(this.TranspositionDecryptedTextBox);
            this.Controls.Add(this.DTCDecryptedTxtLabel);
            this.Controls.Add(this.TranspositionEncryptedTextBox);
            this.Controls.Add(this.ColumnPermuationTextBox);
            this.Controls.Add(this.DTCEncryptedLabel);
            this.Controls.Add(this.DTCColumnOrderLabel);
            this.Controls.Add(this.VingnereRB);
            this.Controls.Add(this.DoubleTRB);
            this.Controls.Add(this.CopyRightLbl);
            this.Controls.Add(this.DecryptedTextBox);
            this.Controls.Add(this.VignereDecryptedTxtLbl);
            this.Controls.Add(this.VignereEncryptedTxtLabel);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.PlainTextBox);
            this.Controls.Add(this.PlainTxtLabel);
            this.Controls.Add(this.PassPhraseLabel);
            this.Controls.Add(this.PassPhrzTextBox);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.TextBox PassPhrzTextBox;
        private System.Windows.Forms.Label PassPhraseLabel;
        private System.Windows.Forms.Label PlainTxtLabel;
        private System.Windows.Forms.TextBox PlainTextBox;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.Label VignereEncryptedTxtLabel;
        private System.Windows.Forms.Label VignereDecryptedTxtLbl;
        private System.Windows.Forms.TextBox DecryptedTextBox;
        private System.Windows.Forms.Label CopyRightLbl;
        private System.Windows.Forms.RadioButton DoubleTRB;
        private System.Windows.Forms.RadioButton VingnereRB;
        private System.Windows.Forms.Label DTCColumnOrderLabel;
        private System.Windows.Forms.Label DTCEncryptedLabel;
        private System.Windows.Forms.TextBox ColumnPermuationTextBox;
        private System.Windows.Forms.TextBox TranspositionEncryptedTextBox;
        private System.Windows.Forms.Label DTCDecryptedTxtLabel;
        private System.Windows.Forms.TextBox TranspositionDecryptedTextBox;
    }
}

