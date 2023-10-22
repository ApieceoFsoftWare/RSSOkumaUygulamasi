namespace RSSOkumaUygulamasi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Getir = new System.Windows.Forms.Button();
            this.textRSS_URL = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_Baslik = new System.Windows.Forms.ListBox();
            this.web_Browser = new System.Windows.Forms.WebBrowser();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Getir);
            this.groupBox1.Controls.Add(this.textRSS_URL);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RSS URL";
            // 
            // btn_Getir
            // 
            this.btn_Getir.Location = new System.Drawing.Point(871, 27);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(179, 35);
            this.btn_Getir.TabIndex = 1;
            this.btn_Getir.Text = "Getir";
            this.btn_Getir.UseVisualStyleBackColor = true;
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // textRSS_URL
            // 
            this.textRSS_URL.Location = new System.Drawing.Point(6, 35);
            this.textRSS_URL.Name = "textRSS_URL";
            this.textRSS_URL.Size = new System.Drawing.Size(844, 20);
            this.textRSS_URL.TabIndex = 0;
            this.textRSS_URL.Text = " https://www.sabah.com.tr/rss/spor.xml";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_Baslik);
            this.groupBox2.Location = new System.Drawing.Point(18, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 579);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber Başlıkları";
            // 
            // lst_Baslik
            // 
            this.lst_Baslik.FormattingEnabled = true;
            this.lst_Baslik.Location = new System.Drawing.Point(6, 19);
            this.lst_Baslik.Name = "lst_Baslik";
            this.lst_Baslik.Size = new System.Drawing.Size(213, 550);
            this.lst_Baslik.TabIndex = 0;
            this.lst_Baslik.SelectedIndexChanged += new System.EventHandler(this.lst_Baslik_SelectedIndexChanged);
            // 
            // web_Browser
            // 
            this.web_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_Browser.Location = new System.Drawing.Point(3, 16);
            this.web_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_Browser.Name = "web_Browser";
            this.web_Browser.Size = new System.Drawing.Size(833, 560);
            this.web_Browser.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.web_Browser);
            this.groupBox3.Location = new System.Drawing.Point(246, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 579);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Haber Detay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 699);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS OKUMA UYGULAMASI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Getir;
        private System.Windows.Forms.TextBox textRSS_URL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_Baslik;
        private System.Windows.Forms.WebBrowser web_Browser;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

