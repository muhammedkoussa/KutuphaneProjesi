
namespace CAS
{
    partial class abone
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
            this.label1 = new System.Windows.Forms.Label();
            this.aboneAdıTxt = new System.Windows.Forms.TextBox();
            this.soyadTxt = new System.Windows.Forms.Label();
            this.aboneSoyadTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aboneTelTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.aboneAdresTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aboneDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.aboneMailTxt = new System.Windows.Forms.TextBox();
            this.aboneKytButon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guncelleRadio = new System.Windows.Forms.RadioButton();
            this.silRadio = new System.Windows.Forms.RadioButton();
            this.ekleRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // aboneAdıTxt
            // 
            this.aboneAdıTxt.Location = new System.Drawing.Point(76, 32);
            this.aboneAdıTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneAdıTxt.Name = "aboneAdıTxt";
            this.aboneAdıTxt.Size = new System.Drawing.Size(132, 22);
            this.aboneAdıTxt.TabIndex = 0;
            // 
            // soyadTxt
            // 
            this.soyadTxt.AutoSize = true;
            this.soyadTxt.Location = new System.Drawing.Point(217, 36);
            this.soyadTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(48, 17);
            this.soyadTxt.TabIndex = 0;
            this.soyadTxt.Text = "Soyad";
            // 
            // aboneSoyadTxt
            // 
            this.aboneSoyadTxt.Location = new System.Drawing.Point(275, 32);
            this.aboneSoyadTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneSoyadTxt.Name = "aboneSoyadTxt";
            this.aboneSoyadTxt.Size = new System.Drawing.Size(132, 22);
            this.aboneSoyadTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon";
            // 
            // aboneTelTxt
            // 
            this.aboneTelTxt.Location = new System.Drawing.Point(473, 32);
            this.aboneTelTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneTelTxt.Name = "aboneTelTxt";
            this.aboneTelTxt.Size = new System.Drawing.Size(132, 22);
            this.aboneTelTxt.TabIndex = 2;
            this.aboneTelTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aboneTelTxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres";
            // 
            // aboneAdresTxt
            // 
            this.aboneAdresTxt.Location = new System.Drawing.Point(76, 64);
            this.aboneAdresTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneAdresTxt.Multiline = true;
            this.aboneAdresTxt.Name = "aboneAdresTxt";
            this.aboneAdresTxt.Size = new System.Drawing.Size(331, 58);
            this.aboneAdresTxt.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kayıt Tarihi";
            // 
            // aboneDate
            // 
            this.aboneDate.Location = new System.Drawing.Point(504, 68);
            this.aboneDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneDate.Name = "aboneDate";
            this.aboneDate.Size = new System.Drawing.Size(179, 22);
            this.aboneDate.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "E-Mail";
            // 
            // aboneMailTxt
            // 
            this.aboneMailTxt.Location = new System.Drawing.Point(675, 32);
            this.aboneMailTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneMailTxt.Name = "aboneMailTxt";
            this.aboneMailTxt.Size = new System.Drawing.Size(283, 22);
            this.aboneMailTxt.TabIndex = 3;
            // 
            // aboneKytButon
            // 
            this.aboneKytButon.Location = new System.Drawing.Point(8, 14);
            this.aboneKytButon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneKytButon.Name = "aboneKytButon";
            this.aboneKytButon.Size = new System.Drawing.Size(144, 49);
            this.aboneKytButon.TabIndex = 6;
            this.aboneKytButon.Text = "Kaydet";
            this.aboneKytButon.UseVisualStyleBackColor = true;
            this.aboneKytButon.Click += new System.EventHandler(this.aboneKytButon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 292);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guncelleRadio);
            this.groupBox1.Controls.Add(this.silRadio);
            this.groupBox1.Controls.Add(this.ekleRadio);
            this.groupBox1.Controls.Add(this.aboneKytButon);
            this.groupBox1.Location = new System.Drawing.Point(692, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(267, 101);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // guncelleRadio
            // 
            this.guncelleRadio.AutoSize = true;
            this.guncelleRadio.Location = new System.Drawing.Point(163, 70);
            this.guncelleRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guncelleRadio.Name = "guncelleRadio";
            this.guncelleRadio.Size = new System.Drawing.Size(85, 21);
            this.guncelleRadio.TabIndex = 22;
            this.guncelleRadio.TabStop = true;
            this.guncelleRadio.Text = "Güncelle";
            this.guncelleRadio.UseVisualStyleBackColor = true;
            this.guncelleRadio.Click += new System.EventHandler(this.guncelleRadio_Click);
            // 
            // silRadio
            // 
            this.silRadio.AutoSize = true;
            this.silRadio.Location = new System.Drawing.Point(163, 42);
            this.silRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.silRadio.Name = "silRadio";
            this.silRadio.Size = new System.Drawing.Size(44, 21);
            this.silRadio.TabIndex = 23;
            this.silRadio.TabStop = true;
            this.silRadio.Text = "Sil";
            this.silRadio.UseVisualStyleBackColor = true;
            // 
            // ekleRadio
            // 
            this.ekleRadio.AutoSize = true;
            this.ekleRadio.Location = new System.Drawing.Point(163, 14);
            this.ekleRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ekleRadio.Name = "ekleRadio";
            this.ekleRadio.Size = new System.Drawing.Size(56, 21);
            this.ekleRadio.TabIndex = 24;
            this.ekleRadio.TabStop = true;
            this.ekleRadio.Text = "Ekle";
            this.ekleRadio.UseVisualStyleBackColor = true;
            this.ekleRadio.Click += new System.EventHandler(this.ekleRadio_Click);
            // 
            // abone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(976, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.aboneDate);
            this.Controls.Add(this.aboneMailTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aboneTelTxt);
            this.Controls.Add(this.aboneSoyadTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.aboneAdresTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aboneAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "abone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "aboneEkle";
            this.Load += new System.EventHandler(this.abone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aboneAdıTxt;
        private System.Windows.Forms.Label soyadTxt;
        private System.Windows.Forms.TextBox aboneSoyadTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aboneTelTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox aboneAdresTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker aboneDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aboneMailTxt;
        private System.Windows.Forms.Button aboneKytButon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton guncelleRadio;
        private System.Windows.Forms.RadioButton silRadio;
        private System.Windows.Forms.RadioButton ekleRadio;
    }
}