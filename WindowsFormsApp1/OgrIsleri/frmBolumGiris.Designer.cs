
namespace WindowsFormsApp1.OgrIsleri
{
    partial class frmBolumGiris
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
            this.sBolumler = new System.Windows.Forms.SplitContainer();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sBolumler)).BeginInit();
            this.sBolumler.Panel1.SuspendLayout();
            this.sBolumler.Panel2.SuspendLayout();
            this.sBolumler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // sBolumler
            // 
            this.sBolumler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sBolumler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sBolumler.Location = new System.Drawing.Point(0, 0);
            this.sBolumler.Name = "sBolumler";
            this.sBolumler.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sBolumler.Panel1
            // 
            this.sBolumler.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.sBolumler.Panel1.Controls.Add(this.btn_kayit);
            this.sBolumler.Panel1.Controls.Add(this.textBox1);
            this.sBolumler.Panel1.Controls.Add(this.label1);
            // 
            // sBolumler.Panel2
            // 
            this.sBolumler.Panel2.Controls.Add(this.liste);
            this.sBolumler.Size = new System.Drawing.Size(404, 361);
            this.sBolumler.SplitterDistance = 134;
            this.sBolumler.TabIndex = 0;
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BolumAdi});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(400, 219);
            this.liste.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Sira No";
            this.Id.Name = "Id";
            this.Id.Width = 67;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bölüm Adı";
            this.BolumAdi.Name = "BolumAdi";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kayit.Location = new System.Drawing.Point(294, 83);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(96, 44);
            this.btn_kayit.TabIndex = 2;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // frmBolumGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 361);
            this.Controls.Add(this.sBolumler);
            this.Name = "frmBolumGiris";
            this.Text = "frmBolumGiris";
            this.Load += new System.EventHandler(this.frmBolumGiris_Load);
            this.sBolumler.Panel1.ResumeLayout(false);
            this.sBolumler.Panel1.PerformLayout();
            this.sBolumler.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sBolumler)).EndInit();
            this.sBolumler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sBolumler;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
    }
}