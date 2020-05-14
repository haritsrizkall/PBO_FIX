using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPBO
{
    public partial class InfoProfile : Form
    {
        public InfoProfile()
        {
            InitializeComponent();
        }

        private void InfoProfile_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                Akun akun = context.Akuns.FirstOrDefault(a => a.Id == VariablePublic.UserId);
                lblNama.Text = akun.Nama;
                lblEmail.Text = akun.Email;
                lblTanggalLahir.Text = akun.TanggalLahir;
                lblAlamat.Text = akun.Alamat;
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
