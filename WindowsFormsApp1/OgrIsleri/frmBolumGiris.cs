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

namespace WindowsFormsApp1.OgrIsleri
{
    public partial class frmBolumGiris : Form
    {
        readonly StudentEntities sdb = new StudentEntities();
        public frmBolumGiris()
        {
            InitializeComponent();
        }
        private void Listele() 
        {
            int i = 0;
            var lst = from s in sdb.tblDeparments select s;
            foreach (var k in lst)
            {
                liste.Rows.Add();
                liste.Rows[i].Cells[0].Value = k.Id;
                liste.Rows[i].Cells[1].Value = k.BolumAdi;
                i++;;
            }
            liste.AllowUserToAddRows = false;
        } 
       
        private void frmBolumGiris_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {

        }
    }
}
