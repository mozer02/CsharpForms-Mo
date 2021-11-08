
namespace WindowsFormsApp1.OgrIsleri
{
    partial class frmOgrBilgiGiris
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
            this.pnl_ust = new System.Windows.Forms.Panel();
            this.lbl_ust = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_tcNo = new System.Windows.Forms.Label();
            this.lbl_OgrNo = new System.Windows.Forms.Label();
            this.lbl_bolumAdi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.cmb_bolumAdi = new System.Windows.Forms.ComboBox();
            this.cmb_sehirAdi = new System.Windows.Forms.ComboBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.liste = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tcno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolumAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mtxt_tcNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_ogrNo = new System.Windows.Forms.MaskedTextBox();
            this.pnl_ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_ust
            // 
            this.pnl_ust.BackColor = System.Drawing.Color.Silver;
            this.pnl_ust.Controls.Add(this.lbl_ust);
            this.pnl_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ust.Location = new System.Drawing.Point(0, 0);
            this.pnl_ust.Name = "pnl_ust";
            this.pnl_ust.Size = new System.Drawing.Size(937, 70);
            this.pnl_ust.TabIndex = 0;
            // 
            // lbl_ust
            // 
            this.lbl_ust.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ust.Location = new System.Drawing.Point(217, 9);
            this.lbl_ust.Name = "lbl_ust";
            this.lbl_ust.Size = new System.Drawing.Size(470, 48);
            this.lbl_ust.TabIndex = 0;
            this.lbl_ust.Text = "ÖĞRENCİ BİLGİ GİRİŞİ";
            this.lbl_ust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ad
            // 
            this.lbl_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(41, 87);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(79, 18);
            this.lbl_ad.TabIndex = 1;
            this.lbl_ad.Text = "Ad:";
            this.lbl_ad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.Location = new System.Drawing.Point(41, 117);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(79, 21);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Soyad :";
            this.lbl_soyad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tcNo
            // 
            this.lbl_tcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tcNo.Location = new System.Drawing.Point(307, 87);
            this.lbl_tcNo.Name = "lbl_tcNo";
            this.lbl_tcNo.Size = new System.Drawing.Size(79, 20);
            this.lbl_tcNo.TabIndex = 3;
            this.lbl_tcNo.Text = "Tc No:";
            this.lbl_tcNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_OgrNo
            // 
            this.lbl_OgrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OgrNo.Location = new System.Drawing.Point(307, 115);
            this.lbl_OgrNo.Name = "lbl_OgrNo";
            this.lbl_OgrNo.Size = new System.Drawing.Size(79, 20);
            this.lbl_OgrNo.TabIndex = 4;
            this.lbl_OgrNo.Text = "Öğrenci No :";
            this.lbl_OgrNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bolumAdi
            // 
            this.lbl_bolumAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bolumAdi.Location = new System.Drawing.Point(597, 88);
            this.lbl_bolumAdi.Name = "lbl_bolumAdi";
            this.lbl_bolumAdi.Size = new System.Drawing.Size(79, 17);
            this.lbl_bolumAdi.TabIndex = 5;
            this.lbl_bolumAdi.Text = "Bölüm Adı :";
            this.lbl_bolumAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(597, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şehir Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(136, 85);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(121, 20);
            this.txt_ad.TabIndex = 7;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(136, 117);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(121, 20);
            this.txt_soyad.TabIndex = 8;
            // 
            // cmb_bolumAdi
            // 
            this.cmb_bolumAdi.DisplayMember = "Id";
            this.cmb_bolumAdi.FormattingEnabled = true;
            this.cmb_bolumAdi.Location = new System.Drawing.Point(692, 88);
            this.cmb_bolumAdi.Name = "cmb_bolumAdi";
            this.cmb_bolumAdi.Size = new System.Drawing.Size(121, 21);
            this.cmb_bolumAdi.TabIndex = 11;
            this.cmb_bolumAdi.ValueMember = "Id";
            // 
            // cmb_sehirAdi
            // 
            this.cmb_sehirAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_sehirAdi.DisplayMember = "id";
            this.cmb_sehirAdi.FormattingEnabled = true;
            this.cmb_sehirAdi.Location = new System.Drawing.Point(692, 121);
            this.cmb_sehirAdi.Name = "cmb_sehirAdi";
            this.cmb_sehirAdi.Size = new System.Drawing.Size(121, 21);
            this.cmb_sehirAdi.TabIndex = 12;
            this.cmb_sehirAdi.ValueMember = "id";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(847, 88);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(78, 25);
            this.btn_temizle.TabIndex = 13;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(735, 165);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(78, 25);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // liste
            // 
            this.liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ad,
            this.Soyad,
            this.OgrNo,
            this.Tcno,
            this.BolumAdi,
            this.sehir,
            this.isActive});
            this.liste.Location = new System.Drawing.Point(67, 212);
            this.liste.MultiSelect = false;
            this.liste.Name = "liste";
            this.liste.ReadOnly = true;
            this.liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.liste.Size = new System.Drawing.Size(746, 212);
            this.liste.TabIndex = 15;
            this.liste.DoubleClick += new System.EventHandler(this.liste_DoubleClick);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(651, 165);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(78, 25);
            this.btn_sil.TabIndex = 16;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Sıra No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Ad
            // 
            this.Ad.HeaderText = "Ad";
            this.Ad.Name = "Ad";
            this.Ad.ReadOnly = true;
            // 
            // Soyad
            // 
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.Name = "Soyad";
            this.Soyad.ReadOnly = true;
            // 
            // OgrNo
            // 
            this.OgrNo.HeaderText = "Öğrenci No";
            this.OgrNo.Name = "OgrNo";
            this.OgrNo.ReadOnly = true;
            // 
            // Tcno
            // 
            this.Tcno.HeaderText = "Tc";
            this.Tcno.Name = "Tcno";
            this.Tcno.ReadOnly = true;
            // 
            // BolumAdi
            // 
            this.BolumAdi.HeaderText = "Bölüm";
            this.BolumAdi.Name = "BolumAdi";
            this.BolumAdi.ReadOnly = true;
            // 
            // sehir
            // 
            this.sehir.HeaderText = "Şehir";
            this.sehir.Name = "sehir";
            this.sehir.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.HeaderText = "Durum";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mtxt_tcNo
            // 
            this.mtxt_tcNo.Location = new System.Drawing.Point(402, 85);
            this.mtxt_tcNo.Mask = "00000000000";
            this.mtxt_tcNo.Name = "mtxt_tcNo";
            this.mtxt_tcNo.Size = new System.Drawing.Size(121, 20);
            this.mtxt_tcNo.TabIndex = 17;
            // 
            // mtxt_ogrNo
            // 
            this.mtxt_ogrNo.Location = new System.Drawing.Point(402, 115);
            this.mtxt_ogrNo.Mask = "0000000000";
            this.mtxt_ogrNo.Name = "mtxt_ogrNo";
            this.mtxt_ogrNo.Size = new System.Drawing.Size(121, 20);
            this.mtxt_ogrNo.TabIndex = 18;
            // 
            // frmOgrBilgiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 465);
            this.Controls.Add(this.mtxt_ogrNo);
            this.Controls.Add(this.mtxt_tcNo);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.liste);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.cmb_sehirAdi);
            this.Controls.Add(this.cmb_bolumAdi);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_bolumAdi);
            this.Controls.Add(this.lbl_OgrNo);
            this.Controls.Add(this.lbl_tcNo);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.pnl_ust);
            this.Name = "frmOgrBilgiGiris";
            this.Text = "frmOgrBilgiGiris";
            this.Load += new System.EventHandler(this.frmOgrBilgiGiris_Load);
            this.pnl_ust.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_ust;
        private System.Windows.Forms.Label lbl_ust;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_tcNo;
        private System.Windows.Forms.Label lbl_OgrNo;
        private System.Windows.Forms.Label lbl_bolumAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.ComboBox cmb_bolumAdi;
        private System.Windows.Forms.ComboBox cmb_sehirAdi;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.DataGridView liste;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tcno;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolumAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.MaskedTextBox mtxt_tcNo;
        private System.Windows.Forms.MaskedTextBox mtxt_ogrNo;
    }
}