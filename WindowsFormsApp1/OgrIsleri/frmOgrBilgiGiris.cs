using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Fonksiyonlar;
using WindowsFormsApp1.OgrIsleri.OgrEntity;

namespace WindowsFormsApp1.OgrIsleri
{
    public partial class frmOgrBilgiGiris : Form
    {
        readonly StudentsEntities sdb = new StudentsEntities();
        Mesajlar m = new Mesajlar();

        private int secimId = -1;
        private bool edit = false;
        public frmOgrBilgiGiris()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            try
            {
                secimId = -1;
                edit = false;
                txt_ad.Clear();
                txt_soyad.Clear();
                txt_tcNo.Clear();
                txt_ogrNo.Clear();
                cmb_sehirAdi.SelectedIndex = 0;
                cmb_bolumAdi.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                m.Sil(e);
                Close();
            }
        }
        private void Listele()
        {
            try
            {
                liste.Rows.Clear();
                int i = 0;
                var lst = (from s in sdb.tblOgrBilgi select s).ToList();
                foreach (var k in lst)
                {
                    liste.Rows.Add();
                    liste.Rows[i].Cells[0].Value = k.Id;
                    liste.Rows[i].Cells[1].Value = k.Ad;
                    liste.Rows[i].Cells[2].Value = k.Soyad;
                    liste.Rows[i].Cells[3].Value = k.Tcno;
                    liste.Rows[i].Cells[4].Value = k.OgrNo;
                    liste.Rows[i].Cells[5].Value = k.tblDeparments.BolumAdi;
                    liste.Rows[i].Cells[6].Value = k.tbl_sehirler.sehir;
                    i++; ;
                }
                liste.AllowUserToAddRows = false;
                liste.AllowUserToDeleteRows = false;
                liste.AllowUserToOrderColumns = false;
                //Dropdownlist
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
                tblOgrBilgi ogrbilgi = new tblOgrBilgi();
                tblDeparments tbl = new tblDeparments();
                tbl_sehirler sehir = new tbl_sehirler();
                ogrbilgi.Ad = txt_ad.Text;
                ogrbilgi.Soyad = txt_soyad.Text;
                ogrbilgi.Tcno = txt_tcNo.Text;
                ogrbilgi.OgrNo = txt_ogrNo.Text;
                ogrbilgi.SehirId = cmb_sehirAdi.SelectedIndex;
                ogrbilgi.BolumId = cmb_bolumAdi.SelectedIndex;
                //blm.Id =22222;//Hata alabilmek için değiştirdik.
                sdb.tblOgrBilgi.Add(ogrbilgi);
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
                tblOgrBilgi ogrbilgi = sdb.tblOgrBilgi.Find(secimId);
                ogrbilgi.Ad = txt_ad.Text;
                ogrbilgi.Soyad = txt_soyad.Text;
                ogrbilgi.OgrNo = txt_ogrNo.Text;
                ogrbilgi.Tcno = txt_tcNo.Text;                
                ogrbilgi.BolumId=cmb_bolumAdi.SelectedIndex;
                ogrbilgi.SehirId = cmb_sehirAdi.SelectedIndex;
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
        private void TamSil()
        {
            try
            {
                sdb.tblOgrBilgi.Remove(sdb.tblOgrBilgi.Find(secimId));
                sdb.SaveChanges();
                MessageBox.Show("Kayıt Silinmiştir.");
            }
            catch (Exception e)
            {
                m.Sil(e);
                Close();
            }
        }
        private void frmOgrBilgiGiris_Load(object sender, EventArgs e)
        {
            Listele();
            cmb_sehirAdi.DataSource = sdb.tbl_sehirler.ToList();
            cmb_sehirAdi.ValueMember = "id";
            cmb_sehirAdi.DisplayMember = "sehir";

            cmb_bolumAdi.DataSource = sdb.tblDeparments.ToList();
            cmb_bolumAdi.ValueMember = "Id";
            cmb_bolumAdi.DisplayMember = "BolumAdi";
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (secimId > 0 && edit == true && m.Guncelle() == DialogResult.Yes)
            {
                Guncelle();
            }
            else if (edit == false)
            {
                YeniKayit();
            }
            Listele();
            Temizle();
        }
        private void liste_DoubleClick(object sender, EventArgs e)
        {
            secimId = (int)liste.CurrentRow.Cells[0].Value;
            txt_ad.Text = liste.CurrentRow.Cells[1].Value.ToString();
            txt_soyad.Text = liste.CurrentRow.Cells[2].Value.ToString();
            txt_ogrNo.Text = liste.CurrentRow.Cells[3].Value.ToString();
            txt_tcNo.Text = liste.CurrentRow.Cells[4].Value.ToString();
            cmb_bolumAdi.Text = liste.CurrentRow.Cells[5].Value.ToString();
            cmb_sehirAdi.Text = liste.CurrentRow.Cells[6].Value.ToString();
            //MessageBox.Show(secimId.ToString());
            if (secimId > 0)
            {
                edit = true;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            TamSil();
            Listele();
        }
    }
}
