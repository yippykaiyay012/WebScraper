namespace WebScraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartScrape = new System.Windows.Forms.Button();
            this.resultsTextbox = new System.Windows.Forms.RichTextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartPage = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartScrape
            // 
            this.btnStartScrape.Location = new System.Drawing.Point(704, 346);
            this.btnStartScrape.Name = "btnStartScrape";
            this.btnStartScrape.Size = new System.Drawing.Size(147, 43);
            this.btnStartScrape.TabIndex = 0;
            this.btnStartScrape.Text = "Start Scrape";
            this.btnStartScrape.UseVisualStyleBackColor = true;
            this.btnStartScrape.Click += new System.EventHandler(this.btnStartScrape_Click);
            // 
            // resultsTextbox
            // 
            this.resultsTextbox.Location = new System.Drawing.Point(12, 41);
            this.resultsTextbox.Name = "resultsTextbox";
            this.resultsTextbox.Size = new System.Drawing.Size(686, 397);
            this.resultsTextbox.TabIndex = 1;
            this.resultsTextbox.Text = "";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(49, 12);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(649, 23);
            this.txtURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            // 
            // txtStartPage
            // 
            this.txtStartPage.Location = new System.Drawing.Point(780, 76);
            this.txtStartPage.Name = "txtStartPage";
            this.txtStartPage.Size = new System.Drawing.Size(71, 23);
            this.txtStartPage.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(780, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "startPage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(721, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "endPage";
            // 
            // btnOpenCSV
            // 
            this.btnOpenCSV.Location = new System.Drawing.Point(704, 395);
            this.btnOpenCSV.Name = "btnOpenCSV";
            this.btnOpenCSV.Size = new System.Drawing.Size(147, 43);
            this.btnOpenCSV.TabIndex = 0;
            this.btnOpenCSV.Text = "Open CSV";
            this.btnOpenCSV.UseVisualStyleBackColor = true;
            this.btnOpenCSV.Click += new System.EventHandler(this.btnOpenCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.btnStartScrape);
            this.Controls.Add(this.btnOpenCSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtStartPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.resultsTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartScrape;
        private System.Windows.Forms.RichTextBox resultsTextbox;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartPage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenCSV;
    }
}

