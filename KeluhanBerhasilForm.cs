using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPBO
{
    public partial class KeluhanBerhasilForm : Form
    {
        public KeluhanBerhasilForm()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnKonsultasi_Click(object sender, EventArgs e)
        {
            TindakanForm tindakanForm = new TindakanForm();
            tindakanForm.Show();
            this.Hide();
        }
    }
}
