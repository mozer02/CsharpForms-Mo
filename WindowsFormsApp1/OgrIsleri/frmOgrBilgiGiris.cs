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
        public int sehirId=-1;
        public int bolumId=-1;

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
                mtxt_tcNo.Clear();
                mtxt_ogrNo.Clear();
                cmb_sehirAdi.Text = "";
                cmb_bolumAdi.Text = "";

            }
            catch (Exception e)
            {
                m.Sil(e);
                Close();
            }
            secimId = -1;
            edit = false;
            sehirId = -1;
            bolumId = -1;
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
                    liste.Rows[i].Cells[3].Value = k.OgrNo;
                    liste.Rows[i].Cells[4].Value = k.Tcno;
                    liste.Rows[i].Cells[5].Value = k.tblDeparments.BolumAdi;
                    liste.Rows[i].Cells[6].Value = k.tbl_sehirler.sehir;
                    liste.Rows[i].Cells[7].Value = k.isActive;
                    i++; ;
                }
                liste.AllowUserToAddRows = false;
                liste.AllowUserToDeleteRows = false;
                liste.AllowUserToOrderColumns = false;

                cmb_sehirAdi.DataSource = sdb.tbl_sehirler.ToList();
                cmb_sehirAdi.ValueMember = "id";
                cmb_sehirAdi.DisplayMember = "sehir";

                cmb_bolumAdi.DataSource = sdb.tblDeparments.ToList();
                cmb_bolumAdi.ValueMember = "Id";
                cmb_bolumAdi.DisplayMember = "BolumAdi";

                cmb_sehirAdi.Text = "";
                cmb_bolumAdi.Text = "";
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
                ogrbilgi.Ad = txt_ad.Text;
                ogrbilgi.Soyad = txt_soyad.Text;
                ogrbilgi.Tcno = mtxt_tcNo.Text;
                ogrbilgi.OgrNo = mtxt_ogrNo.Text;
                //ogrbilgi.SehirId = sehirId;
                ogrbilgi.SehirId = sdb.tbl_sehirler.First(x => x.sehir == cmb_sehirAdi.Text).id;
                //ogrbilgi.BolumId = bolumId;
                ogrbilgi.BolumId = sdb.tblDeparments.First(x => x.BolumAdi == cmb_bolumAdi.Text).Id;
                //blm.Id =22222;//Hata alabilmek için değiştirdik.
                ogrbilgi.isActive = true;
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
                ogrbilgi.OgrNo = mtxt_ogrNo.Text;
                ogrbilgi.Tcno = mtxt_tcNo.Text;
                //ogrbilgi.SehirId = sehirId;
                ogrbilgi.SehirId = sdb.tbl_sehirler.First(x => x.sehir == cmb_sehirAdi.Text).id;
                //ogrbilgi.BolumId = bolumId;
                ogrbilgi.BolumId = sdb.tblDeparments.First(x => x.BolumAdi == cmb_bolumAdi.Text).Id;
                sdb.SaveChanges();
                m.Guncelle(true);
                //MessageBox.Show("Kayıt Güncelleştirildi");
                Temizle();
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
            //Combobox çağırma
            //combolar();

            Listele();           
        }

        //private void combolar()
        //{
        //    cmb_sehirAdi.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //    AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
        //    var lst = sdb.tbl_sehirler.Select(x => x.sehir).Distinct();

        //    foreach (string s in lst)
        //    {
        //        veri.Add(s);
        //        cmb_sehirAdi.Items.Add(s);
        //    }
        //    cmb_sehirAdi.AutoCompleteSource = veri;
        //}

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
            Temizle();
            Listele();
        }
        private void liste_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                edit = true;
                secimId = (int)liste.CurrentRow.Cells[0].Value;
                txt_ad.Text = liste.CurrentRow.Cells[1].Value.ToString();
                txt_soyad.Text = liste.CurrentRow.Cells[2].Value.ToString();
                mtxt_ogrNo.Text = liste.CurrentRow.Cells[3].Value.ToString();
                mtxt_tcNo.Text = liste.CurrentRow.Cells[4].Value.ToString();
                cmb_bolumAdi.Text = liste.CurrentRow.Cells[5].Value.ToString();
                cmb_sehirAdi.Text = liste.CurrentRow.Cells[6].Value.ToString();
                //MessageBox.Show(secimId.ToString());
            }
            catch (Exception)
            {

                secimId = -1;
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            TamSil();
            Listele();
        }
    }
}
