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
        
        public MainForm()
        {
            InitializeComponent();
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {
            using (CekDokEntities context = new CekDokEntities())
            {
                Akun akun = context.Akuns.FirstOrDefault(a => a.Id == VariablePublic.UserId);
                lblNama.Text = akun.Nama;
            }
                
        }

        private void btnBuatKeluhan_Click(object sender, EventArgs e)
        {
            KeluhanForm keluhanForm = new KeluhanForm();
            
            keluhanForm.Show();
            this.Hide();
        }
    }
}
