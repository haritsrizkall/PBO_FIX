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
    public partial class MainForm : Form
    {
        private string email;
        public MainForm()
        {
            InitializeComponent();
        }
       
        public string _textBox
        {
            set { email = value; }
        }
        public string _lblNama
        {
            get { return lblNama.Text;}
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                Akun akun = context.Akuns.FirstOrDefault(a => a.Email == email);
                lblNama.Text = akun.Nama;
            }
                
        }

        private void btnBuatKeluhan_Click(object sender, EventArgs e)
        {
            KeluhanForm keluhanForm = new KeluhanForm();
            keluhanForm._SetNama = lblNama.Text;
            keluhanForm.Show();
            this.Hide();
        }
    }
}
