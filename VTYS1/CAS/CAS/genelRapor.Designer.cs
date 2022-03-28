
namespace CAS
{
    partial class genelRapor
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
            this.kalanKullanim_rb = new System.Windows.Forms.RadioButton();
            this.turHasilat_rb = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kalanKullanim_rb
            // 
            this.kalanKullanim_rb.AutoSize = true;
            this.kalanKullanim_rb.Location = new System.Drawing.Point(10, 95);
            this.kalanKullanim_rb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kalanKullanim_rb.Name = "kalanKullanim_rb";
            this.kalanKullanim_rb.Size = new System.Drawing.Size(94, 17);
            this.kalanKullanim_rb.TabIndex = 1;
            this.kalanKullanim_rb.TabStop = true;
            this.kalanKullanim_rb.Text = "Kalan Kullanım";
            this.kalanKullanim_rb.UseVisualStyleBackColor = true;
            this.kalanKullanim_rb.CheckedChanged += new System.EventHandler(this.kalanKullanim_rb_CheckedChanged);
            // 
            // turHasilat_rb
            // 
            this.turHasilat_rb.AutoSize = true;
            this.turHasilat_rb.Location = new System.Drawing.Point(106, 95);
            this.turHasilat_rb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.turHasilat_rb.Name = "turHasilat_rb";
            this.turHasilat_rb.Size = new System.Drawing.Size(90, 17);
            this.turHasilat_rb.TabIndex = 2;
            this.turHasilat_rb.TabStop = true;
            this.turHasilat_rb.Text = "Türün Hasılatı";
            this.turHasilat_rb.UseVisualStyleBackColor = true;
            this.turHasilat_rb.CheckedChanged += new System.EventHandler(this.turHasilat_rb_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(10, 118);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(735, 237);
            this.dataGridView.TabIndex = 26;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(655, 361);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(90, 25);
            this.export.TabIndex = 40;
            this.export.Text = "Expor to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // genelRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 394);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.turHasilat_rb);
            this.Controls.Add(this.kalanKullanim_rb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "genelRapor";
            this.Text = "genelRapor";
            this.Load += new System.EventHandler(this.genelRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton kalanKullanim_rb;
        private System.Windows.Forms.RadioButton turHasilat_rb;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button export;
    }
}