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
    public partial class InfoRumahSakitForm : Form
    {
        public InfoRumahSakitForm()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            TindakanForm tindakanForm = new TindakanForm();
            tindakanForm.Show();
            this.Close();
        }
    }
}
