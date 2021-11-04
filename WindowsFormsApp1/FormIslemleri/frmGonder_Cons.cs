using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entity;

namespace WindowsFormsApp1.FormIslemleri
{
    public partial class frmGonder_Cons : Form
    {
        public frmGonder_Cons()
        {
            InitializeComponent();
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            List<ModelKisi> elist = db.Employees.Select(x => new ModelKisi
            {
                Ad = x.FirstName,
                Soyad = x.LastName
            }).ToList();

            frmAl_Cons frm = new frmAl_Cons(elist);
            frm.Show();
        }
    }
}
