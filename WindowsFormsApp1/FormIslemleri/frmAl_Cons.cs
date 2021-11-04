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
    public partial class frmAl_Cons : Form
    {
        public frmAl_Cons()
        {
            InitializeComponent();
        }
        public frmAl_Cons(List<ModelKisi> elist)
        {
            InitializeComponent();
            dataGridView1.DataSource = elist;
        }

        private void frmAl_Cons_Load(object sender, EventArgs e)
        {
            
        }
    }
}
