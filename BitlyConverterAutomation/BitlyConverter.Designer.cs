namespace BitlyConverterAutomation
{
    partial class BitlyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitlyConverter));
            this.LongURLsTextbox = new System.Windows.Forms.TextBox();
            this.ConvertToBitly = new System.Windows.Forms.Button();
            this.ResponseProgress = new System.Windows.Forms.ProgressBar();
            this.ShortenedURLsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QRCodesTextbox = new System.Windows.Forms.TextBox();
            this.QRCodeFilePathTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondHalfNamesTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LongURLsTextbox
            // 
            this.LongURLsTextbox.Location = new System.Drawing.Point(12, 47);
            this.LongURLsTextbox.MaxLength = 0;
            this.LongURLsTextbox.Multiline = true;
            this.LongURLsTextbox.Name = "LongURLsTextbox";
            this.LongURLsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LongURLsTextbox.Size = new System.Drawing.Size(334, 629);
            this.LongURLsTextbox.TabIndex = 0;
            // 
            // ConvertToBitly
            // 
            this.ConvertToBitly.Location = new System.Drawing.Point(639, 306);
            this.ConvertToBitly.Name = "ConvertToBitly";
            this.ConvertToBitly.Size = new System.Drawing.Size(163, 34);
            this.ConvertToBitly.TabIndex = 2;
            this.ConvertToBitly.Text = "Convert";
            this.ConvertToBitly.UseVisualStyleBackColor = true;
            this.ConvertToBitly.Click += new System.EventHandler(this.ConvertToBitly_Click);
            // 
            // ResponseProgress
            // 
            this.ResponseProgress.Location = new System.Drawing.Point(12, 699);
            this.ResponseProgress.Name = "ResponseProgress";
            this.ResponseProgress.Size = new System.Drawing.Size(1323, 22);
            this.ResponseProgress.TabIndex = 3;
            this.ResponseProgress.Visible = false;
            // 
            // ShortenedURLsTextbox
            // 
            this.ShortenedURLsTextbox.Location = new System.Drawing.Point(824, 46);
            this.ShortenedURLsTextbox.MaxLength = 0;
            this.ShortenedURLsTextbox.Multiline = true;
            this.ShortenedURLsTextbox.Name = "ShortenedURLsTextbox";
            this.ShortenedURLsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ShortenedURLsTextbox.Size = new System.Drawing.Size(263, 629);
            this.ShortenedURLsTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Long URLs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Shortened URLs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1130, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "QR Codes:";
            // 
            // QRCodesTextbox
            // 
            this.QRCodesTextbox.Location = new System.Drawing.Point(1135, 46);
            this.QRCodesTextbox.MaxLength = 0;
            this.QRCodesTextbox.Multiline = true;
            this.QRCodesTextbox.Name = "QRCodesTextbox";
            this.QRCodesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QRCodesTextbox.Size = new System.Drawing.Size(200, 630);
            this.QRCodesTextbox.TabIndex = 4;
            // 
            // QRCodeFilePathTextbox
            // 
            this.QRCodeFilePathTextbox.Location = new System.Drawing.Point(639, 97);
            this.QRCodeFilePathTextbox.Multiline = true;
            this.QRCodeFilePathTextbox.Name = "QRCodeFilePathTextbox";
            this.QRCodeFilePathTextbox.Size = new System.Drawing.Size(163, 170);
            this.QRCodeFilePathTextbox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(646, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "QRCode File path:";
            // 
            // SecondHalfNamesTextbox
            // 
            this.SecondHalfNamesTextbox.Location = new System.Drawing.Point(368, 46);
            this.SecondHalfNamesTextbox.MaxLength = 0;
            this.SecondHalfNamesTextbox.Multiline = true;
            this.SecondHalfNamesTextbox.Name = "SecondHalfNamesTextbox";
            this.SecondHalfNamesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SecondHalfNamesTextbox.Size = new System.Drawing.Size(253, 629);
            this.SecondHalfNamesTextbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Second Half Names:";
            // 
            // BitlyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1347, 733);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SecondHalfNamesTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QRCodeFilePathTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QRCodesTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShortenedURLsTextbox);
            this.Controls.Add(this.ResponseProgress);
            this.Controls.Add(this.ConvertToBitly);
            this.Controls.Add(this.LongURLsTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(970, 570);
            this.Name = "BitlyConverter";
            this.Text = "OneShell URL Shortner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LongURLsTextbox;
        private System.Windows.Forms.Button ConvertToBitly;
        private System.Windows.Forms.ProgressBar ResponseProgress;
        private System.Windows.Forms.TextBox ShortenedURLsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QRCodesTextbox;
        private System.Windows.Forms.TextBox QRCodeFilePathTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SecondHalfNamesTextbox;
        private System.Windows.Forms.Label label5;
    }
}

