namespace CAS
{
    partial class abonelikRapor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.icerikAdıCombo = new System.Windows.Forms.ComboBox();
            this.aboneAdıCombo = new System.Windows.Forms.ComboBox();
            this.bitisDate = new System.Windows.Forms.DateTimePicker();
            this.icerikLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboneLbl = new System.Windows.Forms.Label();
            this.baslangıcDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.baslangic_cb = new System.Windows.Forms.CheckBox();
            this.bitis_cb = new System.Windows.Forms.CheckBox();
            this.export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(909, 256);
            this.dataGridView1.TabIndex = 35;
            // 
            // icerikAdıCombo
            // 
            this.icerikAdıCombo.FormattingEnabled = true;
            this.icerikAdıCombo.Location = new System.Drawing.Point(655, 26);
            this.icerikAdıCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.icerikAdıCombo.Name = "icerikAdıCombo";
            this.icerikAdıCombo.Size = new System.Drawing.Size(181, 24);
            this.icerikAdıCombo.TabIndex = 1;
            this.icerikAdıCombo.SelectedIndexChanged += new System.EventHandler(this.icerikAdıCombo_SelectedIndexChanged);
            // 
            // aboneAdıCombo
            // 
            this.aboneAdıCombo.FormattingEnabled = true;
            this.aboneAdıCombo.Location = new System.Drawing.Point(133, 25);
            this.aboneAdıCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboneAdıCombo.Name = "aboneAdıCombo";
            this.aboneAdıCombo.Size = new System.Drawing.Size(209, 24);
            this.aboneAdıCombo.TabIndex = 0;
            this.aboneAdıCombo.SelectedIndexChanged += new System.EventHandler(this.aboneAdıCombo_SelectedIndexChanged);
            // 
            // bitisDate
            // 
            this.bitisDate.Location = new System.Drawing.Point(651, 76);
            this.bitisDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bitisDate.Name = "bitisDate";
            this.bitisDate.Size = new System.Drawing.Size(181, 22);
            this.bitisDate.TabIndex = 3;
            this.bitisDate.ValueChanged += new System.EventHandler(this.bitisDate_ValueChanged);
            // 
            // icerikLbl
            // 
            this.icerikLbl.AutoSize = true;
            this.icerikLbl.Location = new System.Drawing.Point(579, 32);
            this.icerikLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.icerikLbl.Name = "icerikLbl";
            this.icerikLbl.Size = new System.Drawing.Size(65, 17);
            this.icerikLbl.TabIndex = 27;
            this.icerikLbl.Text = "İçerik Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Bitiş Tarihi";
            // 
            // aboneLbl
            // 
            this.aboneLbl.AutoSize = true;
            this.aboneLbl.Location = new System.Drawing.Point(47, 30);
            this.aboneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboneLbl.Name = "aboneLbl";
            this.aboneLbl.Size = new System.Drawing.Size(73, 17);
            this.aboneLbl.TabIndex = 29;
            this.aboneLbl.Text = "Abone Adı";
            // 
            // baslangıcDate
            // 
            this.baslangıcDate.Location = new System.Drawing.Point(160, 73);
            this.baslangıcDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.baslangıcDate.Name = "baslangıcDate";
            this.baslangıcDate.Size = new System.Drawing.Size(179, 22);
            this.baslangıcDate.TabIndex = 2;
            this.baslangıcDate.ValueChanged += new System.EventHandler(this.baslangıcDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Başlangıç Tarihi";
            // 
            // baslangic_cb
            // 
            this.baslangic_cb.AutoSize = true;
            this.baslangic_cb.Location = new System.Drawing.Point(347, 76);
            this.baslangic_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.baslangic_cb.Name = "baslangic_cb";
            this.baslangic_cb.Size = new System.Drawing.Size(18, 17);
            this.baslangic_cb.TabIndex = 36;
            this.baslangic_cb.UseVisualStyleBackColor = true;
            this.baslangic_cb.CheckedChanged += new System.EventHandler(this.baslangic_cb_CheckedChanged);
            // 
            // bitis_cb
            // 
            this.bitis_cb.AutoSize = true;
            this.bitis_cb.Location = new System.Drawing.Point(839, 78);
            this.bitis_cb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bitis_cb.Name = "bitis_cb";
            this.bitis_cb.Size = new System.Drawing.Size(18, 17);
            this.bitis_cb.TabIndex = 37;
            this.bitis_cb.UseVisualStyleBackColor = true;
            this.bitis_cb.CheckedChanged += new System.EventHandler(this.bitis_cb_CheckedChanged);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(799, 401);
            this.export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(120, 31);
            this.export.TabIndex = 38;
            this.export.Text = "Expor to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // abonelikRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 447);
            this.Controls.Add(this.export);
            this.Controls.Add(this.bitis_cb);
            this.Controls.Add(this.baslangic_cb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.icerikAdıCombo);
            this.Controls.Add(this.aboneAdıCombo);
            this.Controls.Add(this.bitisDate);
            this.Controls.Add(this.icerikLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboneLbl);
            this.Controls.Add(this.baslangıcDate);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "abonelikRapor";
            this.Text = "abonelikRapor";
            this.Load += new System.EventHandler(this.abonelikRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox icerikAdıCombo;
        private System.Windows.Forms.ComboBox aboneAdıCombo;
        private System.Windows.Forms.DateTimePicker bitisDate;
        private System.Windows.Forms.Label icerikLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aboneLbl;
        private System.Windows.Forms.DateTimePicker baslangıcDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox baslangic_cb;
        private System.Windows.Forms.CheckBox bitis_cb;
        private System.Windows.Forms.Button export;
    }
}