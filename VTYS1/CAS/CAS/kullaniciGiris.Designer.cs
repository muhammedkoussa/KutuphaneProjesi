
namespace CAS
{
    partial class kullaniciGiris
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
            this.girisButon = new System.Windows.Forms.Button();
            this.kullaniciText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisButon
            // 
            this.girisButon.Location = new System.Drawing.Point(77, 59);
            this.girisButon.Margin = new System.Windows.Forms.Padding(2);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(56, 24);
            this.girisButon.TabIndex = 2;
            this.girisButon.Text = "Giriş";
            this.girisButon.UseVisualStyleBackColor = true;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // kullaniciText
            // 
            this.kullaniciText.Location = new System.Drawing.Point(77, 12);
            this.kullaniciText.Margin = new System.Windows.Forms.Padding(2);
            this.kullaniciText.Name = "kullaniciText";
            this.kullaniciText.Size = new System.Drawing.Size(133, 20);
            this.kullaniciText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(77, 35);
            this.sifreText.Margin = new System.Windows.Forms.Padding(2);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(133, 20);
            this.sifreText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(154, 60);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(58, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Kapat";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // kullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(224, 95);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kullaniciText);
            this.Controls.Add(this.girisButon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "kullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullaniciGiris";
            this.Load += new System.EventHandler(this.kullaniciGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.TextBox kullaniciText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
    }
}