namespace CAS
{
    partial class fiyatRapor
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
            this.fiyatTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipAdıTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 210);
            this.dataGridView1.TabIndex = 33;
            // 
            // fiyatTxt
            // 
            this.fiyatTxt.Location = new System.Drawing.Point(275, 15);
            this.fiyatTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fiyatTxt.Name = "fiyatTxt";
            this.fiyatTxt.Size = new System.Drawing.Size(132, 22);
            this.fiyatTxt.TabIndex = 2;
            this.fiyatTxt.TextChanged += new System.EventHandler(this.fiyatTxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ücreti";
            // 
            // tipAdıTxt
            // 
            this.tipAdıTxt.Location = new System.Drawing.Point(69, 15);
            this.tipAdıTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tipAdıTxt.Name = "tipAdıTxt";
            this.tipAdıTxt.Size = new System.Drawing.Size(132, 22);
            this.tipAdıTxt.TabIndex = 1;
            this.tipAdıTxt.TextChanged += new System.EventHandler(this.tipAdıTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tip Adı";
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(293, 316);
            this.export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(120, 31);
            this.export.TabIndex = 40;
            this.export.Text = "Expor to Excel";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // fiyatRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 358);
            this.Controls.Add(this.export);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fiyatTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipAdıTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fiyatRapor";
            this.Text = "fiyatRapor";
            this.Load += new System.EventHandler(this.fiyatRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox fiyatTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tipAdıTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button export;
    }
}