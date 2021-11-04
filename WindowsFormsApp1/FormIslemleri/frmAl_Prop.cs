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
    public partial class frmAl_Prop : Form
    {
        public List<ModelKisi> elist 
        { 
            set { dataGridView1.DataSource = value; }
        }
        public frmAl_Prop()
        {
            InitializeComponent();
        }

        private void frmAl_Prop_Load(object sender, EventArgs e)
        {

        }
    }
}
