using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_KINJO
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistration reg  = new frmRegistration();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmMasterlist().Show();
            this.Hide();
        }
    }
}
