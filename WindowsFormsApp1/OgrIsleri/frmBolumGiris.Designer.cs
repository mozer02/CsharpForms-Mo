
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
            this.rb_Tum = new System.Windows.Forms.RadioButton();
            this.rb_Pasif = new System.Windows.Forms.RadioButton();
            this.rb_Aktif = new System.Windows.Forms.RadioButton();
            this.cmb_Control = new System.Windows.Forms.ComboBox();
            this.chk_Pasif = new System.Windows.Forms.CheckBox();
            this.btn_tamSil = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.txt_bolumAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.sBolumler.Panel1.Controls.Add(this.rb_Tum);
            this.sBolumler.Panel1.Controls.Add(this.rb_Pasif);
            this.sBolumler.Panel1.Controls.Add(this.rb_Aktif);
            this.sBolumler.Panel1.Controls.Add(this.cmb_Control);
            this.sBolumler.Panel1.Controls.Add(this.chk_Pasif);
            this.sBolumler.Panel1.Controls.Add(this.btn_tamSil);
            this.sBolumler.Panel1.Controls.Add(this.btn_sil);
            this.sBolumler.Panel1.Controls.Add(this.btn_temizle);
            this.sBolumler.Panel1.Controls.Add(this.btn_kayit);
            this.sBolumler.Panel1.Controls.Add(this.txt_bolumAdi);
            this.sBolumler.Panel1.Controls.Add(this.label1);
            // 
            // sBolumler.Panel2
            // 
            this.sBolumler.Panel2.Controls.Add(this.liste);
            this.sBolumler.Size = new System.Drawing.Size(404, 361);
            this.sBolumler.SplitterDistance = 134;
            this.sBolumler.TabIndex = 0;
            // 
            // rb_Tum
            // 
            this.rb_Tum.AutoSize = true;
            this.rb_Tum.Checked = true;
            this.rb_Tum.Location = new System.Drawing.Point(209, 102);
            this.rb_Tum.Name = "rb_Tum";
            this.rb_Tum.Size = new System.Drawing.Size(52, 17);
            this.rb_Tum.TabIndex = 10;
            this.rb_Tum.TabStop = true;
            this.rb_Tum.Text = "Tümü";
            this.rb_Tum.UseVisualStyleBackColor = true;
            this.rb_Tum.CheckedChanged += new System.EventHandler(this.rb_Tum_CheckedChanged);
            // 
            // rb_Pasif
            // 
            this.rb_Pasif.AutoSize = true;
            this.rb_Pasif.Location = new System.Drawing.Point(209, 80);
            this.rb_Pasif.Name = "rb_Pasif";
            this.rb_Pasif.Size = new System.Drawing.Size(48, 17);
            this.rb_Pasif.TabIndex = 9;
            this.rb_Pasif.Text = "Pasif";
            this.rb_Pasif.UseVisualStyleBackColor = true;
            this.rb_Pasif.CheckedChanged += new System.EventHandler(this.rb_Pasif_CheckedChanged);
            // 
            // rb_Aktif
            // 
            this.rb_Aktif.AutoSize = true;
            this.rb_Aktif.Location = new System.Drawing.Point(209, 61);
            this.rb_Aktif.Name = "rb_Aktif";
            this.rb_Aktif.Size = new System.Drawing.Size(46, 17);
            this.rb_Aktif.TabIndex = 8;
            this.rb_Aktif.Text = "Aktif";
            this.rb_Aktif.UseVisualStyleBackColor = true;
            this.rb_Aktif.CheckedChanged += new System.EventHandler(this.rb_Aktif_CheckedChanged);
            // 
            // cmb_Control
            // 
            this.cmb_Control.FormattingEnabled = true;
            this.cmb_Control.Items.AddRange(new object[] {
            "Aktif",
            "Pasif",
            "Tümü"});
            this.cmb_Control.Location = new System.Drawing.Point(92, 61);
            this.cmb_Control.Name = "cmb_Control";
            this.cmb_Control.Size = new System.Drawing.Size(83, 21);
            this.cmb_Control.TabIndex = 7;
            this.cmb_Control.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chk_Pasif
            // 
            this.chk_Pasif.Location = new System.Drawing.Point(294, 0);
            this.chk_Pasif.Name = "chk_Pasif";
            this.chk_Pasif.Size = new System.Drawing.Size(96, 23);
            this.chk_Pasif.TabIndex = 6;
            this.chk_Pasif.Text = "Pasif";
            this.chk_Pasif.UseVisualStyleBackColor = true;
            this.chk_Pasif.CheckedChanged += new System.EventHandler(this.chk_Pasif_CheckedChanged);
            // 
            // btn_tamSil
            // 
            this.btn_tamSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tamSil.Location = new System.Drawing.Point(92, 92);
            this.btn_tamSil.Name = "btn_tamSil";
            this.btn_tamSil.Size = new System.Drawing.Size(83, 27);
            this.btn_tamSil.TabIndex = 5;
            this.btn_tamSil.Text = "Tam Silme";
            this.btn_tamSil.UseVisualStyleBackColor = true;
            this.btn_tamSil.Click += new System.EventHandler(this.btn_tamSil_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sil.Location = new System.Drawing.Point(3, 92);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(83, 27);
            this.btn_sil.TabIndex = 4;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_temizle.Location = new System.Drawing.Point(3, 61);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(83, 27);
            this.btn_temizle.TabIndex = 3;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kayit
            // 
            this.btn_kayit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kayit.Location = new System.Drawing.Point(301, 83);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(96, 44);
            this.btn_kayit.TabIndex = 2;
            this.btn_kayit.Text = "Kayıt";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // txt_bolumAdi
            // 
            this.txt_bolumAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_bolumAdi.Location = new System.Drawing.Point(0, 23);
            this.txt_bolumAdi.Name = "txt_bolumAdi";
            this.txt_bolumAdi.Size = new System.Drawing.Size(400, 20);
            this.txt_bolumAdi.TabIndex = 1;
            this.txt_bolumAdi.TextChanged += new System.EventHandler(this.txt_bolumAdi_TextChanged);
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
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BolumAdi,
            this.isActive});
            this.liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.liste.Location = new System.Drawing.Point(0, 0);
            this.liste.MultiSelect = false;
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(400, 219);
            this.liste.TabIndex = 0;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Sira No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 67;
            // 
            // BolumAdi
            // 
            this.BolumAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BolumAdi.HeaderText = "Bölüm Adı";
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Durum";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
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
        private System.Windows.Forms.TextBox txt_bolumAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_tamSil;
        private System.Windows.Forms.CheckBox chk_Pasif;
        private System.Windows.Forms.ComboBox cmb_Control;
        private System.Windows.Forms.RadioButton rb_Pasif;
        private System.Windows.Forms.RadioButton rb_Aktif;
        private System.Windows.Forms.RadioButton rb_Tum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}