
namespace WindowsFormsApp1.FormIslemleri
{
    partial class UrunlerListesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_kdvDahil = new System.Windows.Forms.Label();
            this.lbl_Kdv = new System.Windows.Forms.Label();
            this.lbl_urunFiyat = new System.Windows.Forms.Label();
            this.lbl_urunAdı = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜNLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 70);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(217, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Fiyatı:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(221, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(221, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kdv Oranı :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(173, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kdv Dahil Fiyatı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_kdvDahil
            // 
            this.lbl_kdvDahil.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_kdvDahil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kdvDahil.Location = new System.Drawing.Point(332, 234);
            this.lbl_kdvDahil.Name = "lbl_kdvDahil";
            this.lbl_kdvDahil.Size = new System.Drawing.Size(205, 20);
            this.lbl_kdvDahil.TabIndex = 3;
            this.lbl_kdvDahil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Kdv
            // 
            this.lbl_Kdv.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Kdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kdv.Location = new System.Drawing.Point(332, 199);
            this.lbl_Kdv.Name = "lbl_Kdv";
            this.lbl_Kdv.Size = new System.Drawing.Size(205, 20);
            this.lbl_Kdv.TabIndex = 3;
            this.lbl_Kdv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_urunFiyat
            // 
            this.lbl_urunFiyat.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_urunFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunFiyat.Location = new System.Drawing.Point(332, 162);
            this.lbl_urunFiyat.Name = "lbl_urunFiyat";
            this.lbl_urunFiyat.Size = new System.Drawing.Size(205, 20);
            this.lbl_urunFiyat.TabIndex = 3;
            this.lbl_urunFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_urunAdı
            // 
            this.lbl_urunAdı.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_urunAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunAdı.Location = new System.Drawing.Point(332, 127);
            this.lbl_urunAdı.Name = "lbl_urunAdı";
            this.lbl_urunAdı.Size = new System.Drawing.Size(205, 20);
            this.lbl_urunAdı.TabIndex = 3;
            this.lbl_urunAdı.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UrunlerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_urunAdı);
            this.Controls.Add(this.lbl_urunFiyat);
            this.Controls.Add(this.lbl_Kdv);
            this.Controls.Add(this.lbl_kdvDahil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UrunlerListesi";
            this.Text = "UrunlerListesi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lbl_kdvDahil;
        public System.Windows.Forms.Label lbl_Kdv;
        public System.Windows.Forms.Label lbl_urunFiyat;
        public System.Windows.Forms.Label lbl_urunAdı;
    }
}