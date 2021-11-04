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
    public partial class frmGonder_Prop : Form
    {
        public frmGonder_Prop()
        {
            InitializeComponent();
        }

        private void btn_Gonder_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();

            frmAl_Prop frm = new frmAl_Prop();
            frm.elist = db.Employees.Select(x => new ModelKisi
            {
                Ad = x.FirstName,
                Soyad = x.FirstName
            }).ToList();
            frm.Show();
        }
    }
}
