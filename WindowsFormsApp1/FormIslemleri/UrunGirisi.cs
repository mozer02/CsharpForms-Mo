using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.FormIslemleri
{
    public partial class UrunGirisi : Form
    {
        public UrunGirisi()
        {
            InitializeComponent();
        }
        private void UrunGirisi_Load(object sender, EventArgs e)
        {

        }
        void Temizle()
        {
            txt_urunAd.Text = "";
            txt_urunFiyat.Text = "";
        }
        private void btn_gonder_Click(object sender, EventArgs e)
        {
            UrunlerListesi hedef = new UrunlerListesi();
            AnaForm anaform = new AnaForm();
            hedef.lbl_urunAdı.Text = txt_urunAd.Text;
            hedef.lbl_urunFiyat.Text = txt_urunFiyat.Text;
            hedef.lbl_Kdv.Text = "1.18";
            hedef.lbl_kdvDahil.Text = Convert.ToString(Convert.ToDouble(txt_urunFiyat.Text) * 1.18);
            hedef.Show();
            Temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();          
        }
    }
}
