using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj,"Yeni Kayıt Giriş",MessageBoxButtons.OK,MessageBoxIcon.Information);
        } 
        public void Guncelle(bool guncelleme)
        {
            if (guncelleme==true)
            {
                MessageBox.Show("Kayıt Güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            }
            else
            {
                MessageBox.Show("Güncelleme İşlemi İptal Edildi", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public DialogResult Guncelle()
        {
            if (true)
            {
                return MessageBox.Show("Seçili olan kayıt güncellenecektir\nGüncelleme işlemini onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }            
        }
        public void Guncelle(Exception e)
        {
            MessageBox.Show(""+e, "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        public void Sil(Exception e)
        {
            MessageBox.Show(""+e, "Kayıt Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 
        public void Listele(Exception e)
        {
            MessageBox.Show(""+e, "Listeleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
