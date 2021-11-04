
namespace WindowsFormsApp1.FormIslemleri
{
    partial class frmGonder_Prop
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
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Gonder.Location = new System.Drawing.Point(179, 77);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(443, 256);
            this.btn_Gonder.TabIndex = 0;
            this.btn_Gonder.Text = "GÖNDER";
            this.btn_Gonder.UseVisualStyleBackColor = true;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // frmGonder_Prop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Gonder);
            this.Name = "frmGonder_Prop";
            this.Text = "frmGonder_Prop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Gonder;
    }
}