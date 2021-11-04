using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FormIslemleri;
using WindowsFormsApp1.OgrIsleri;

namespace WindowsFormsApp1
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
        void Paneller()
        {
            gb_Sol.Visible = true;
            pnl_1.Visible = false;
            pnl_2.Visible = false;
            pnl_3.Visible = false;
            pnl_4.Visible = false;
            pnl_5.Visible = false;
            pnl_6.Visible = false;
            pnl_7.Visible = false;
        }

        #region Pnl_Ust Paneli
        private void button1_Click(object sender, EventArgs e)
        {
            gb_Sol.Text = button1.Text;
            Paneller();
            pnl_1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gb_Sol.Text = button2.Text;
            Paneller();
            pnl_2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gb_Sol.Text = button3.Text;
            Paneller();
            pnl_3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gb_Sol.Text = button4.Text;
            Paneller();
            pnl_4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gb_Sol.Text = button5.Text;
            Paneller();
            pnl_5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gb_Sol.Text = button6.Text;
            Paneller();
            pnl_6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gb_Sol.Text = button7.Text;
            Paneller();
            pnl_7.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Collaps_Click(object sender, EventArgs e)
        {
            if (gb_Sol.Visible == true)
            {
                gb_Sol.Visible = false;
                btn_Collaps.Text = "GOSTER";
            }
            else if (gb_Sol.Visible == false)
            {
                gb_Sol.Visible = true;
                btn_Collaps.Text = "GİZLE";
            }
        }
        #endregion

        #region Form İşlemleri
        private void btn_gonderProp_Click(object sender, EventArgs e)
        {
            frmGonder_Prop frm = new frmGonder_Prop();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btn_gonderCons_Click(object sender, EventArgs e)
        {
            frmGonder_Cons frm = new frmGonder_Cons();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        #endregion

        private void btn_urunGiris_Click(object sender, EventArgs e)
        {
            UrunGirisi urunGiris = new UrunGirisi();
            urunGiris.MdiParent = Application.OpenForms["AnaForm"] as AnaForm;
            urunGiris.WindowState = FormWindowState.Maximized;
            urunGiris.Show();
        }

        private void btn_urunListele_Click(object sender, EventArgs e)
        {
            UrunlerListesi urunListe = new UrunlerListesi();
            urunListe.MdiParent = Form.ActiveForm;
            urunListe.WindowState = FormWindowState.Maximized;
            urunListe.Show();

        }

        private void btn_Departmens_Click(object sender, EventArgs e)
        {
            frmBolumGiris frm = new frmBolumGiris();
            frm.ShowDialog();
        }
    }
}
