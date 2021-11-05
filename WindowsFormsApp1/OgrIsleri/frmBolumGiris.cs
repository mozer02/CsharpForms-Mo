using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.OgrIsleri.OgrEntity;
using System.Windows.Forms;
using WindowsFormsApp1.Fonksiyonlar;

namespace WindowsFormsApp1.OgrIsleri
{
    public partial class frmBolumGiris : Form
    {
        readonly StudentEntities sdb = new StudentEntities();
        Mesajlar m = new Mesajlar();

        private int secimId = -1;
        private bool edit = false;
        public frmBolumGiris()
        {
            InitializeComponent();
        }
        private void Listele() 
        {
            try
            {
                liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblDeparments where s.isActive == true select s).ToList();
                foreach (var k in lst)
                {
                    liste.Rows.Add();
                    liste.Rows[i].Cells[0].Value = k.Id;
                    liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    liste.Rows[i].Cells[2].Value = k.isActive;
                    i++; ;
                }
                liste.AllowUserToAddRows = false;
                liste.AllowUserToDeleteRows = false;
                liste.AllowUserToOrderColumns = false;
            }
            catch (Exception e)
            {
                m.Listele(e);
                Close();
            }
        }
        private void PasifListele() 
        {
            try
            {
                liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblDeparments where s.isActive == false select s).ToList();
                foreach (var k in lst)
                {
                    liste.Rows.Add();
                    liste.Rows[i].Cells[0].Value = k.Id;
                    liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    liste.Rows[i].Cells[2].Value = k.isActive;
                    i++; ;
                }
                liste.AllowUserToAddRows = false;
                liste.AllowUserToDeleteRows = false;
                liste.AllowUserToOrderColumns = false;
            }
            catch (Exception e)
            {
                m.Listele(e);
                Close();
            }
        }
        private void TumListele() 
        {
            try
            {
                liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblDeparments select s).ToList();
                foreach (var k in lst)
                {
                    liste.Rows.Add();
                    liste.Rows[i].Cells[0].Value = k.Id;
                    liste.Rows[i].Cells[1].Value = k.BolumAdi;
                    liste.Rows[i].Cells[2].Value = k.isActive;
                    i++; ;
                }
                liste.AllowUserToAddRows = false;
                liste.AllowUserToDeleteRows = false;
                liste.AllowUserToOrderColumns = false;
            }
            catch (Exception e)
            {
                m.Listele(e);
                Close();
            }
        }
        private void YeniKayit()
        {
            try
            {
                tblDeparments blm = new tblDeparments();
                blm.BolumAdi = txt_bolumAdi.Text;
                blm.isActive = true;
                //blm.Id =22222;//Hata alabilmek için değiştirdik.
                sdb.tblDeparments.Add(blm);
                sdb.SaveChanges();
                m.YeniKayit("Yeni Kayıt Oluşturuldu");
                //MessageBox.Show("Yeni Kayıt Oluşturuldu");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e);               
            }
        }
        private void Guncelle()
        {
            try
            {
                tblDeparments blm = sdb.tblDeparments.Find(secimId);
                blm.BolumAdi = txt_bolumAdi.Text;
                sdb.SaveChanges();
                m.Guncelle(true);
                //MessageBox.Show("Kayıt Güncelleştirildi");
            }
            catch (Exception e)
            {
                m.Guncelle(false);
                m.Guncelle(e);
                Close();
            }
        }
        private void frmBolumGiris_Load(object sender, EventArgs e)
        {
            cmb_Control.SelectedIndex = 2;
            if (rb_Aktif.Checked == true)
            {
                Listele();
            }
            else if (rb_Pasif.Checked == true)
            {
                PasifListele();
            }
            else if (rb_Tum.Checked == true)
            {
                TumListele();
            }

        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            if(secimId>0 && edit == true && m.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else if(edit==false)
            {
                YeniKayit();
            }
            Listele();
            Temizle();
        }

        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int)liste.CurrentRow.Cells[0].Value;
            txt_bolumAdi.Text =liste.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show(secimId.ToString());

            if (secimId>0)
            {
                edit = true;
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            try
            {
                secimId = -1;
                edit = false;
                txt_bolumAdi.Clear();
            }
            catch (Exception e)
            {
                m.Sil(e);
                Close();
            }
        }

        private void txt_bolumAdi_TextChanged(object sender, EventArgs e)
        {
            //if (txt_bolumAdi.Text=="")
            //{
            //    edit = false;
            //}
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Sil();
            Temizle();
            Listele();
        }
        private void Sil()
        {
            try
            {
                if (txt_bolumAdi.Text!="")
                {
                    tblDeparments blm = sdb.tblDeparments.Find(secimId);
                    blm.isActive = false;
                    sdb.SaveChanges();
                    MessageBox.Show("Kayıt Silinmiştir.");
                }
                else if (txt_bolumAdi.Text == "")
                {
                    MessageBox.Show("Lütfen Seçim Yapınız");
                }
            }
            catch (Exception e)
            {
                m.Sil(e);
                Close();
            }
        }
        private void TamSil()
        {
            try
            {
                sdb.tblDeparments.Remove(sdb.tblDeparments.Find(secimId));
                sdb.SaveChanges();
                MessageBox.Show("Kayıt Tam Silinmiştir.");
            }
            catch (Exception e)
            {
                m.Sil(e);
                Close();
            }
        }

        private void btn_tamSil_Click(object sender, EventArgs e)
        {
            TamSil();
            Temizle();
            Listele();
        }

        private void chk_Pasif_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Pasif.Checked==true)
            {
                PasifListele();
            }
            else
            {
                Listele();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Control.Text == "Aktif")
            {
                Listele();
            }
            else if (cmb_Control.Text == "Pasif")
            {
                PasifListele();
            }          
            else if (cmb_Control.Text == "Tümü")
            {
                TumListele();
            }

        }

        private void rb_Aktif_CheckedChanged(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void rb_Pasif_CheckedChanged(object sender, EventArgs e)
        {
            PasifListele();
            Temizle();
        }

        private void rb_Tum_CheckedChanged(object sender, EventArgs e)
        {
            TumListele();
            Temizle();
        }
    }
}
